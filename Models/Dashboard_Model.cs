using Dashboard_Store_App.Database;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Globalization;

namespace Dashboard_Store_App.Models
{
    // Structures

    // Revenue_by_date struct represents a record of revenue, with the date it was earned and the amount
    public struct Revenue_by_date
    {
        // Date when the revenue was earned
        public string Date { get; set; }

        // The total amount of revenue earned on the date
        public decimal Total_amount { get; set; }
    }

    // Classes

    // Dashboard_Model class contains the data and methods needed to generate the dashboard data
    // This class inherits from Database_Connection class which manages connections to the database
    public class Dashboard_Model : Database_Connection
    {
        // The constructor initializes the properties with default values
        public Dashboard_Model(IConfiguration configuration) : base(configuration)
        {
            // Initializing lists so they are not null and are ready to hold data
            Top_products = new List<KeyValuePair<string, int>>();
            Low_stock_products = new List<KeyValuePair<string, int>>();
            Gross_revenue = new List<Revenue_by_date>();
        }

        // Variables --------------------------------------------------------------------------------------------------------

        // Database_table enum represents the possible database tables this dashboard model can interact with
        public enum Database_table
        {
            Customer,
            Supplier,
            Product,
            Order,
            Order_Item
        }

        // Fields for start and end dates, and the number of days

        private DateTime start_date;
        private DateTime end_date;
        private DateTime previous_start_date;
        private DateTime previous_end_date;
        private int days;

        // Properties to store counts of various entities in the database

        public int Number_of_customers { get; private set; }
        public int Number_of_suppliers { get; private set; }
        public int Number_of_products { get; private set; }

        // Lists to store top products, low stock products and gross revenue data

        public List<KeyValuePair<string, int>> Top_products { get; private set; }
        public List<KeyValuePair<string, int>> Low_stock_products { get; private set; }
        public List<Revenue_by_date> Gross_revenue { get; private set; }

        // Properties store the number of orders, total revenue and total profit

        public int Number_of_orders { get; set; }
        public decimal Total_revenue { get; set; }
        public decimal Total_profit { get; set; }
        public int Previous_number_of_orders { get; set; }
        public decimal Previous_total_revenue { get; set; }
        public decimal Previous_total_profit { get; set; }

        // Variables --------------------------------------------------------------------------------------------------------

        // Functions --------------------------------------------------------------------------------------------------------

        // GER NUMBER ITEMS ASYNC ------------------------------------------

        // Get the count of rows in a given database table
        private static async Task<int> Get_Count_Async(SqlConnection connection, Database_table table_name)
        {
            // Command to count rows in a specific table
            using var command = new SqlCommand($"SELECT count(id) FROM {table_name}", connection);

            // Execute the command and return the count, with a null check in case the command returns null
            return (int)(await command.ExecuteScalarAsync() ?? 0);
        }

        // Get the number of orders within a given date range
        private static async Task<int> Get_Order_Count_Async(SqlConnection connection, DateTime start_date, DateTime end_date)
        {
            // Ensure the connection is open
            if (connection.State != ConnectionState.Open)
                await connection.OpenAsync();

            // Command to count orders within the specified date range
            using var command = new SqlCommand("SELECT count(id) FROM Orders " +
                                               "WHERE order_date BETWEEN @start_date AND @end_date", connection);

            // Adding start and end dates as parameters to the command
            command.Parameters.Add("@start_date", System.Data.SqlDbType.DateTime).Value = start_date;
            command.Parameters.Add("@end_date", System.Data.SqlDbType.DateTime).Value = end_date;

            // Execute the command and return the count, with a null check in case the command returns null
            var count = (int)(await command.ExecuteScalarAsync() ?? 0);

            // Close the connection once you are done
            connection.Close();

            return count;
        }

        // Fetch all the counts for the dashboard
        private async Task Get_Number_Items_Async()
        {
            try
            {
                // Opening a connection to the database
                using var connection = Get_Connection();
                await connection.OpenAsync();

                // Fetching the counts and storing them in the corresponding properties
                Number_of_customers = await Get_Count_Async(connection, Database_table.Customer);
                Number_of_suppliers = await Get_Count_Async(connection, Database_table.Supplier);
                Number_of_products = await Get_Count_Async(connection, Database_table.Product);
                Number_of_orders = await Get_Order_Count_Async(connection, start_date, end_date);
            }
            catch (SqlException ex)
            {
                // SQL exceptions are related to issues with SQL commands, such as syntax errors or missing tables/columns
                Console.WriteLine($"An error occurred while communicating with the database: {ex.Message}");
            }
            catch (InvalidOperationException ex)
            {
                // InvalidOperationExceptions are thrown when trying to do something that the current state of the object does not allow
                Console.WriteLine($"An error occurred with the database connection: {ex.Message}");
            }
            catch (Exception ex)
            {
                // Catching any other types of exceptions
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
        }

        // GER NUMBER ITEMS ASYNC ------------------------------------------

        // GET OREDR STATISTICS --------------------------------------------

        // Querying the data from the database
        private async Task<List<KeyValuePair<DateTime, decimal>>> Query_Order_Data_Async()
        {
            var result_table = new List<KeyValuePair<DateTime, decimal>>();
            try
            {
                // Opening a connection to the database
                using var connection = Get_Connection();
                await connection.OpenAsync();

                // Preparing the SQL command
                using var command = new SqlCommand();
                command.Connection = connection;

                // SQL command is used to fetch data about all orders made within a specific date range.
                command.CommandText = @"SELECT order_date, sum(total_amount) FROM Orders
                                        WHERE order_date BETWEEN @start_date AND @end_date
                                        GROUP BY order_date";

                // Adding start and end dates as parameters to the command
                command.Parameters.Add("@start_date", System.Data.SqlDbType.DateTime).Value = start_date;
                command.Parameters.Add("@end_date", System.Data.SqlDbType.DateTime).Value = end_date;

                // Executing the command and processing the results
                using var reader = await command.ExecuteReaderAsync();
                while (await reader.ReadAsync())
                {
                    result_table.Add(new KeyValuePair<DateTime, decimal>((DateTime)reader[0], (decimal)reader[1]));
                    Total_revenue += (decimal)reader[1];
                }
            }
            catch (SqlException ex)
            {
                // SQL exceptions are related to issues with SQL commands, such as syntax errors or missing tables/columns
                Console.WriteLine($"An error occurred while communicating with the database: {ex.Message}");
            }
            catch (InvalidOperationException ex)
            {
                // InvalidOperationExceptions are thrown when trying to do something that the current state of the object does not allow
                Console.WriteLine($"An error occurred with the database connection: {ex.Message}");
            }
            catch (Exception ex)
            {
                // Catching any other types of exceptions
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
            return result_table;
        }

        // Calculates the profit
        private void Calculate_Profit(decimal total_revenue, decimal profit_margin)
        {
            // Calculating the profit by multiplying the total revenue by the profit margin
            Total_profit = total_revenue * profit_margin;
        }

        // Group the revenue by date
        //
        // Func delegate: Func<DateTime, string> is a delegate that represents a function taking in a DateTime and returning a string.
        // In this case, it's a function that formats a DateTime to a string.
        //
        // Switch expressions: The switch keyword is followed by an expression (in this case, days).
        // The switch expression evaluates its expression, and then finds the first switch expression case that matches and evaluates the corresponding expression.
        //
        // Pattern matching: In the switch expression, there are several cases (<= 1, <= 30, <= 92, <= (365 * 2), _).
        // In this context, they are called relational patterns. The _ pattern is a discard pattern that matches any input.
        //
        // Lambda expressions: In each case, a lambda expression (dt => ...) is used to define the formatting of the DateTime.
        // These are inline anonymous functions that take a DateTime (dt) and return a formatted string.
        //
        // <= 1 => : This is a case in the switch expression. <= 1 is a pattern that matches when days is less than or equal to 1. => is used to separate the pattern from the expression that will be evaluated if the pattern matches.
        // dt => dt.ToString("hh tt") : This is a lambda expression that takes a DateTime dt and returns a formatted string.
        private void Group_Revenue_By_Date(List<KeyValuePair<DateTime, decimal>> result_table)
        {
            // This function determines the format in which we display dates
            // It changes based on the number of days: for less than a day it shows hours, for less than a month it shows days,
            // for less than three months it shows weeks, for less than two years it shows months, and for more than that it shows years.
            Func<DateTime, string> key_selector = days switch
            {
                <= 1 => dt => dt.ToString("hh tt"),
                <= 30 => dt => dt.ToString("dd MMM"),
                <= 92 => dt => CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(dt, CalendarWeekRule.FirstDay, DayOfWeek.Monday).ToString(),
                <= (365 * 2) => dt => days <= 365 ? dt.ToString("MMM") : dt.ToString("MMM yyyy"),
                _ => dt => dt.ToString("yyyy")
            };

            // This LINQ query groups orders by date and calculates the total amount of each group.
            // It then constructs a list of Revenue_by_date, where each item represents the revenue of one date.
            // For each order_list in result_table, group it by the result of keySelector(order_list.Key).
            // For each group, create a new Revenue_by_date where the Date is the group key and the Total_amount is the sum of all the Values in the group.
            // Convert the resulting sequence to a list.
            // Assign this list to Gross_revenue.
            Gross_revenue = (from order_list in result_table
                             group order_list by key_selector(order_list.Key) into order
                             select new Revenue_by_date { Date = order.Key, Total_amount = order.Sum(amount => amount.Value) }).ToList();
        }

        // Get the order statistics
        private async Task Get_Order_Statistics()
        {
            // Initializing necessary variables
            Total_profit = 0;
            Total_revenue = 0;
            const decimal profit_margin = 0.3m;

            // Querying the order data
            var order_data = await Query_Order_Data_Async();

            // Calculating profit
            Calculate_Profit(Total_revenue, profit_margin);

            // Grouping revenue by date
            Group_Revenue_By_Date(order_data);
        }

        // GET OREDR STATISTICS --------------------------------------------

        // GET PRODUCT STATISTICS ------------------------------------------

        // This method retrieves the top 5 products, ranked by the quantity ordered in a specified date range.
        private async Task Get_Top_Products_Async()
        {
            // Clear them each time a new date is picked
            Top_products.Clear();

            // Opening a connection to the database
            using var connection = Get_Connection();
            await connection.OpenAsync();

            // Preparing the SQL command
            using var command = new SqlCommand();
            command.Connection = connection;

            // This SQL query gets the top 5 products by quantity sold from to a specific date
            command.CommandText = @"SELECT TOP 5 Product.product_name, SUM(Order_Item.quantity) AS Q FROM Order_Item
                                    INNER JOIN Product ON Product.id = Order_Item.product_id
                                    INNER JOIN Orders ON Orders.id = Order_Item.order_id
                                    WHERE Orders.order_date BETWEEN @start_date AND @end_date
                                    GROUP BY Product.product_name
                                    ORDER BY Q DESC";

            // Adding start and end dates as parameters to the command
            command.Parameters.Add("@start_date", System.Data.SqlDbType.DateTime).Value = start_date;
            command.Parameters.Add("@end_date", System.Data.SqlDbType.DateTime).Value = end_date;

            // Executing the command and processing the results
            using var reader = await command.ExecuteReaderAsync();
            while (await reader.ReadAsync())
            {
                // Add product_name and quantity pair to Top_products list
                // If product_name is null, it will be replaced with an empty string
                Top_products.Add(new KeyValuePair<string, int>(reader[0]?.ToString() ?? string.Empty, (int)reader[1]));
            }
        }

        // Get the products that are low in stock (stock <= 1000) and not discontinued.
        private async Task Get_Low_Stock_Products_Async()
        {
            // Opening a connection to the database
            using var connection = Get_Connection();
            await connection.OpenAsync();

            // Preparing the SQL command
            using var command = new SqlCommand();
            command.Connection = connection;

            // This SQL query selects all products with a stock count of 1000 or less and which are not discontinued.
            command.CommandText = @"SELECT product_name, stock FROM Product
                                    WHERE stock <= 1000 AND is_discontinued = 0";

            // Executing the command and processing the results
            using var reader = await command.ExecuteReaderAsync();
            while (await reader.ReadAsync())
            {
                // Add product_name and stock pair to Low_stock_products list
                // If product_name is null, it will be replaced with an empty string
                Low_stock_products.Add(new KeyValuePair<string, int>(reader[0]?.ToString() ?? string.Empty, (int)reader[1]));
            }
        }

        // Get the product statistics
        private async Task Get_Product_Statistics()
        {
            try
            {
                await Get_Top_Products_Async();
                await Get_Low_Stock_Products_Async();
            }
            catch (SqlException ex)
            {
                // SQL exceptions are related to issues with SQL commands, such as syntax errors or missing tables/columns
                Console.WriteLine($"An error occurred while communicating with the database: {ex.Message}");
            }
            catch (InvalidOperationException ex)
            {
                // InvalidOperationExceptions are thrown when trying to do something that the current state of the object does not allow
                Console.WriteLine($"An error occurred with the database connection: {ex.Message}");
            }
            catch (Exception ex)
            {
                // Catching any other types of exceptions
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
        }

        // GET PRODUCT STATISTICS ------------------------------------------

        // Load data for the specified date range returns a bool so the user doesn't refresh it multiple times, that way this function does nothing if the dates are the same
        public async Task<bool> Load_Data(DateTime start_date, DateTime end_date, DateTime previous_start_date, DateTime previous_end_date)
        {
            // Adjust the end_date to include the last minute of the day
            end_date = new DateTime(end_date.Year, end_date.Month, end_date.Day, end_date.Hour, end_date.Minute, 59);

            // Check if the new date range is different from the current one
            if (start_date != this.start_date || end_date != this.end_date)
            {
                // If the date range is different, update the stored start_date, end_date, and days
                this.start_date = start_date;
                this.end_date = end_date;
                this.previous_start_date = previous_start_date;
                this.previous_end_date = previous_end_date;
                days = (end_date - start_date).Days; // Calculate the number of days in the range

                // Load the data asynchronously for the previous date range
                DateTime temp_start = this.start_date;
                DateTime temp_end = this.end_date;

                this.start_date = previous_start_date;
                this.end_date = previous_end_date;

                Previous_number_of_orders = await Get_Order_Count_Async(Get_Connection(), previous_start_date, previous_end_date);
                await Get_Order_Statistics(); // Load order statistics for the previous period
                Previous_total_revenue = Total_revenue; // Store the total revenue for the previous period
                Previous_total_profit = Total_profit; // Store the total profit for the previous period

                this.start_date = temp_start;
                this.end_date = temp_end;

                // Load the data asynchronously for the new date range
                await Get_Number_Items_Async(); // Load the number of items
                await Get_Order_Statistics(); // Load order statistics
                await Get_Product_Statistics(); // Load product statistics

                // Log a message indicating that new data has been loaded
                Console.WriteLine("NEW DATA: {0} - {1}", start_date.ToString(), end_date.ToString());

                // Return true indicating that new data has been loaded
                return true;
            }
            else
            {
                // If the date range is the same as the current one, log a message and return false
                Console.WriteLine("SAME DATA: {0} - {1}", start_date.ToString(), end_date.ToString());

                // Return false indicating that no new data has been loaded
                return false;
            }
        }

        // Functions --------------------------------------------------------------------------------------------------------
    }
}
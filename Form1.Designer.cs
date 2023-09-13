namespace Dashboard_Store_App
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            date_time_picker_start = new DateTimePicker();
            date_time_picker_end = new DateTimePicker();
            button_this_month = new Button();
            button_last_30_days = new Button();
            button_last_7_days = new Button();
            button_today = new Button();
            button_custom_date = new Button();
            button_set_dates = new Button();
            panel_number_of_orders = new Panel();
            label_previous_orders_number = new Label();
            pictureBox_number_of_orders = new PictureBox();
            label_orders_number = new Label();
            label_number_of_orders = new Label();
            panel_total_profit = new Panel();
            label_previous_total_profit_number = new Label();
            pictureBox_total_profit = new PictureBox();
            label_total_profit_number = new Label();
            label_total_profit = new Label();
            panel_total_revenue = new Panel();
            label_previous_total_revenue_number = new Label();
            pictureBox_total_revenue = new PictureBox();
            label_total_revenue_number = new Label();
            label_total_revenue = new Label();
            chart_gross_revenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chart_top_products = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel_number_of_customers = new Panel();
            pictureBox_customers = new PictureBox();
            label_customers_number = new Label();
            label_number_of_customers = new Label();
            panel_number_of_suppliers = new Panel();
            pictureBox_suppliers = new PictureBox();
            label_suppliers_number = new Label();
            label_number_of_suppliers = new Label();
            panel_number_of_products = new Panel();
            pictureBox_products = new PictureBox();
            label_product_number = new Label();
            label_number_of_products = new Label();
            panel_low_stock = new Panel();
            pictureBox1 = new PictureBox();
            dataGridView_low_stock = new DataGridView();
            label_low_products = new Label();
            label_title = new Label();
            label_from = new Label();
            label_to = new Label();
            label_start_mask = new Label();
            label_end_mask = new Label();
            button_previous = new Button();
            label_greet = new Label();
            linkLabel_me = new LinkLabel();
            label_heart = new Label();
            panel_number_of_orders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_number_of_orders).BeginInit();
            panel_total_profit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_total_profit).BeginInit();
            panel_total_revenue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_total_revenue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart_gross_revenue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart_top_products).BeginInit();
            panel_number_of_customers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_customers).BeginInit();
            panel_number_of_suppliers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_suppliers).BeginInit();
            panel_number_of_products.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_products).BeginInit();
            panel_low_stock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_low_stock).BeginInit();
            SuspendLayout();
            // 
            // date_time_picker_start
            // 
            date_time_picker_start.CustomFormat = "MMM dd, yyyy";
            date_time_picker_start.Enabled = false;
            date_time_picker_start.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point);
            date_time_picker_start.Format = DateTimePickerFormat.Custom;
            date_time_picker_start.Location = new Point(447, 19);
            date_time_picker_start.Name = "date_time_picker_start";
            date_time_picker_start.Size = new Size(145, 21);
            date_time_picker_start.TabIndex = 0;
            date_time_picker_start.ValueChanged += Date_Time_Picker_Start_ValueChanged;
            // 
            // date_time_picker_end
            // 
            date_time_picker_end.CustomFormat = "MMM dd, yyyy";
            date_time_picker_end.Enabled = false;
            date_time_picker_end.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point);
            date_time_picker_end.Format = DateTimePickerFormat.Custom;
            date_time_picker_end.Location = new Point(447, 46);
            date_time_picker_end.Name = "date_time_picker_end";
            date_time_picker_end.Size = new Size(145, 21);
            date_time_picker_end.TabIndex = 1;
            date_time_picker_end.ValueChanged += Date_Time_Picker_End_ValueChanged;
            // 
            // button_this_month
            // 
            button_this_month.FlatAppearance.BorderColor = Color.FromArgb(44, 51, 51);
            button_this_month.FlatAppearance.BorderSize = 2;
            button_this_month.FlatStyle = FlatStyle.Flat;
            button_this_month.Font = new Font("Cascadia Code SemiBold", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            button_this_month.ForeColor = Color.White;
            button_this_month.Location = new Point(838, 13);
            button_this_month.Name = "button_this_month";
            button_this_month.Size = new Size(122, 56);
            button_this_month.TabIndex = 2;
            button_this_month.Text = "This Month";
            button_this_month.UseVisualStyleBackColor = true;
            button_this_month.Click += Button_This_Month_Click;
            // 
            // button_last_30_days
            // 
            button_last_30_days.FlatAppearance.BorderColor = Color.FromArgb(44, 51, 51);
            button_last_30_days.FlatAppearance.BorderSize = 2;
            button_last_30_days.FlatStyle = FlatStyle.Flat;
            button_last_30_days.Font = new Font("Cascadia Code SemiBold", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            button_last_30_days.ForeColor = Color.White;
            button_last_30_days.Location = new Point(718, 13);
            button_last_30_days.Name = "button_last_30_days";
            button_last_30_days.Size = new Size(122, 56);
            button_last_30_days.TabIndex = 3;
            button_last_30_days.Text = "Last 30 days";
            button_last_30_days.UseVisualStyleBackColor = true;
            button_last_30_days.Click += Button_Last_30_Days_Click;
            // 
            // button_last_7_days
            // 
            button_last_7_days.FlatAppearance.BorderColor = Color.FromArgb(44, 51, 51);
            button_last_7_days.FlatAppearance.BorderSize = 2;
            button_last_7_days.FlatStyle = FlatStyle.Flat;
            button_last_7_days.Font = new Font("Cascadia Code SemiBold", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            button_last_7_days.ForeColor = Color.White;
            button_last_7_days.Location = new Point(958, 13);
            button_last_7_days.Name = "button_last_7_days";
            button_last_7_days.Size = new Size(122, 56);
            button_last_7_days.TabIndex = 4;
            button_last_7_days.Text = "Last 7 days";
            button_last_7_days.UseVisualStyleBackColor = true;
            button_last_7_days.Click += Button_Last_7_Days_Click;
            // 
            // button_today
            // 
            button_today.FlatAppearance.BorderColor = Color.FromArgb(44, 51, 51);
            button_today.FlatAppearance.BorderSize = 2;
            button_today.FlatStyle = FlatStyle.Flat;
            button_today.Font = new Font("Cascadia Code SemiBold", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            button_today.ForeColor = Color.White;
            button_today.Location = new Point(1078, 13);
            button_today.Name = "button_today";
            button_today.Size = new Size(122, 56);
            button_today.TabIndex = 5;
            button_today.Text = "Today";
            button_today.UseVisualStyleBackColor = true;
            button_today.Click += Button_Today_Click;
            // 
            // button_custom_date
            // 
            button_custom_date.FlatAppearance.BorderColor = Color.FromArgb(44, 51, 51);
            button_custom_date.FlatAppearance.BorderSize = 2;
            button_custom_date.FlatStyle = FlatStyle.Flat;
            button_custom_date.Font = new Font("Cascadia Code SemiBold", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            button_custom_date.ForeColor = Color.White;
            button_custom_date.Location = new Point(598, 13);
            button_custom_date.Name = "button_custom_date";
            button_custom_date.Size = new Size(122, 29);
            button_custom_date.TabIndex = 6;
            button_custom_date.Text = "Custom";
            button_custom_date.UseVisualStyleBackColor = true;
            button_custom_date.Click += Button_Custom_Date_Click;
            // 
            // button_set_dates
            // 
            button_set_dates.BackColor = Color.FromArgb(167, 209, 41);
            button_set_dates.Enabled = false;
            button_set_dates.FlatAppearance.BorderColor = Color.FromArgb(44, 51, 51);
            button_set_dates.FlatAppearance.BorderSize = 2;
            button_set_dates.FlatStyle = FlatStyle.Flat;
            button_set_dates.Font = new Font("Cascadia Code SemiBold", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            button_set_dates.ForeColor = Color.Black;
            button_set_dates.Location = new Point(598, 40);
            button_set_dates.Name = "button_set_dates";
            button_set_dates.Size = new Size(122, 29);
            button_set_dates.TabIndex = 7;
            button_set_dates.Text = "Set";
            button_set_dates.UseVisualStyleBackColor = false;
            button_set_dates.Visible = false;
            button_set_dates.Click += Button_Set_Dates_Click;
            // 
            // panel_number_of_orders
            // 
            panel_number_of_orders.BackColor = Color.FromArgb(44, 51, 51);
            panel_number_of_orders.Controls.Add(label_previous_orders_number);
            panel_number_of_orders.Controls.Add(pictureBox_number_of_orders);
            panel_number_of_orders.Controls.Add(label_orders_number);
            panel_number_of_orders.Controls.Add(label_number_of_orders);
            panel_number_of_orders.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point);
            panel_number_of_orders.Location = new Point(12, 88);
            panel_number_of_orders.Name = "panel_number_of_orders";
            panel_number_of_orders.Size = new Size(326, 77);
            panel_number_of_orders.TabIndex = 8;
            // 
            // label_previous_orders_number
            // 
            label_previous_orders_number.AutoSize = true;
            label_previous_orders_number.Font = new Font("Cascadia Code", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label_previous_orders_number.ForeColor = Color.FromArgb(147, 168, 87);
            label_previous_orders_number.Location = new Point(230, 40);
            label_previous_orders_number.Name = "label_previous_orders_number";
            label_previous_orders_number.Size = new Size(36, 20);
            label_previous_orders_number.TabIndex = 3;
            label_previous_orders_number.Text = "00%";
            // 
            // pictureBox_number_of_orders
            // 
            pictureBox_number_of_orders.Image = (Image)resources.GetObject("pictureBox_number_of_orders.Image");
            pictureBox_number_of_orders.Location = new Point(0, 0);
            pictureBox_number_of_orders.Name = "pictureBox_number_of_orders";
            pictureBox_number_of_orders.Size = new Size(92, 77);
            pictureBox_number_of_orders.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_number_of_orders.TabIndex = 2;
            pictureBox_number_of_orders.TabStop = false;
            // 
            // label_orders_number
            // 
            label_orders_number.AutoSize = true;
            label_orders_number.Font = new Font("Cascadia Code", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label_orders_number.ForeColor = Color.FromArgb(167, 209, 41);
            label_orders_number.Location = new Point(113, 32);
            label_orders_number.Name = "label_orders_number";
            label_orders_number.Size = new Size(48, 28);
            label_orders_number.TabIndex = 1;
            label_orders_number.Text = "100";
            // 
            // label_number_of_orders
            // 
            label_number_of_orders.AutoSize = true;
            label_number_of_orders.Font = new Font("Cascadia Code", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label_number_of_orders.ForeColor = Color.FromArgb(147, 168, 87);
            label_number_of_orders.Location = new Point(98, 12);
            label_number_of_orders.Name = "label_number_of_orders";
            label_number_of_orders.Size = new Size(153, 20);
            label_number_of_orders.TabIndex = 0;
            label_number_of_orders.Text = "Number of Orders";
            // 
            // panel_total_profit
            // 
            panel_total_profit.BackColor = Color.FromArgb(44, 51, 51);
            panel_total_profit.Controls.Add(label_previous_total_profit_number);
            panel_total_profit.Controls.Add(pictureBox_total_profit);
            panel_total_profit.Controls.Add(label_total_profit_number);
            panel_total_profit.Controls.Add(label_total_profit);
            panel_total_profit.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point);
            panel_total_profit.Location = new Point(790, 88);
            panel_total_profit.Name = "panel_total_profit";
            panel_total_profit.Size = new Size(410, 77);
            panel_total_profit.TabIndex = 9;
            // 
            // label_previous_total_profit_number
            // 
            label_previous_total_profit_number.AutoSize = true;
            label_previous_total_profit_number.Font = new Font("Cascadia Code", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label_previous_total_profit_number.ForeColor = Color.FromArgb(147, 168, 87);
            label_previous_total_profit_number.Location = new Point(314, 40);
            label_previous_total_profit_number.Name = "label_previous_total_profit_number";
            label_previous_total_profit_number.Size = new Size(36, 20);
            label_previous_total_profit_number.TabIndex = 5;
            label_previous_total_profit_number.Text = "00%";
            // 
            // pictureBox_total_profit
            // 
            pictureBox_total_profit.Image = (Image)resources.GetObject("pictureBox_total_profit.Image");
            pictureBox_total_profit.Location = new Point(0, 0);
            pictureBox_total_profit.Name = "pictureBox_total_profit";
            pictureBox_total_profit.Size = new Size(92, 77);
            pictureBox_total_profit.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_total_profit.TabIndex = 4;
            pictureBox_total_profit.TabStop = false;
            // 
            // label_total_profit_number
            // 
            label_total_profit_number.AutoSize = true;
            label_total_profit_number.Font = new Font("Cascadia Code", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label_total_profit_number.ForeColor = Color.FromArgb(167, 209, 41);
            label_total_profit_number.Location = new Point(108, 32);
            label_total_profit_number.Name = "label_total_profit_number";
            label_total_profit_number.Size = new Size(48, 28);
            label_total_profit_number.TabIndex = 1;
            label_total_profit_number.Text = "100";
            // 
            // label_total_profit
            // 
            label_total_profit.AutoSize = true;
            label_total_profit.Font = new Font("Cascadia Code", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label_total_profit.ForeColor = Color.FromArgb(147, 168, 87);
            label_total_profit.Location = new Point(97, 12);
            label_total_profit.Name = "label_total_profit";
            label_total_profit.Size = new Size(117, 20);
            label_total_profit.TabIndex = 0;
            label_total_profit.Text = "Total Profit";
            // 
            // panel_total_revenue
            // 
            panel_total_revenue.BackColor = Color.FromArgb(44, 51, 51);
            panel_total_revenue.Controls.Add(label_previous_total_revenue_number);
            panel_total_revenue.Controls.Add(pictureBox_total_revenue);
            panel_total_revenue.Controls.Add(label_total_revenue_number);
            panel_total_revenue.Controls.Add(label_total_revenue);
            panel_total_revenue.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point);
            panel_total_revenue.Location = new Point(344, 88);
            panel_total_revenue.Name = "panel_total_revenue";
            panel_total_revenue.Size = new Size(440, 77);
            panel_total_revenue.TabIndex = 9;
            // 
            // label_previous_total_revenue_number
            // 
            label_previous_total_revenue_number.AutoSize = true;
            label_previous_total_revenue_number.Font = new Font("Cascadia Code", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label_previous_total_revenue_number.ForeColor = Color.FromArgb(147, 168, 87);
            label_previous_total_revenue_number.Location = new Point(344, 40);
            label_previous_total_revenue_number.Name = "label_previous_total_revenue_number";
            label_previous_total_revenue_number.Size = new Size(36, 20);
            label_previous_total_revenue_number.TabIndex = 4;
            label_previous_total_revenue_number.Text = "00%";
            // 
            // pictureBox_total_revenue
            // 
            pictureBox_total_revenue.Image = (Image)resources.GetObject("pictureBox_total_revenue.Image");
            pictureBox_total_revenue.Location = new Point(0, 0);
            pictureBox_total_revenue.Name = "pictureBox_total_revenue";
            pictureBox_total_revenue.Size = new Size(92, 77);
            pictureBox_total_revenue.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_total_revenue.TabIndex = 3;
            pictureBox_total_revenue.TabStop = false;
            // 
            // label_total_revenue_number
            // 
            label_total_revenue_number.AutoSize = true;
            label_total_revenue_number.Font = new Font("Cascadia Code", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label_total_revenue_number.ForeColor = Color.FromArgb(167, 209, 41);
            label_total_revenue_number.Location = new Point(108, 32);
            label_total_revenue_number.Name = "label_total_revenue_number";
            label_total_revenue_number.Size = new Size(48, 28);
            label_total_revenue_number.TabIndex = 1;
            label_total_revenue_number.Text = "100";
            // 
            // label_total_revenue
            // 
            label_total_revenue.AutoSize = true;
            label_total_revenue.Font = new Font("Cascadia Code", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label_total_revenue.ForeColor = Color.FromArgb(147, 168, 87);
            label_total_revenue.Location = new Point(98, 12);
            label_total_revenue.Name = "label_total_revenue";
            label_total_revenue.Size = new Size(126, 20);
            label_total_revenue.TabIndex = 0;
            label_total_revenue.Text = "Total Revenue";
            // 
            // chart_gross_revenue
            // 
            chart_gross_revenue.BackColor = Color.FromArgb(44, 51, 51);
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.IsMarginVisible = false;
            chartArea1.AxisX.LabelStyle.Font = new Font("Cascadia Code", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            chartArea1.AxisX.LabelStyle.ForeColor = Color.FromArgb(147, 168, 87);
            chartArea1.AxisX.LineColor = Color.FromArgb(147, 168, 87);
            chartArea1.AxisX.MajorGrid.LineWidth = 0;
            chartArea1.AxisX.MajorTickMark.LineColor = Color.FromArgb(147, 168, 87);
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new Font("Cascadia Code", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            chartArea1.AxisY.LabelStyle.ForeColor = Color.FromArgb(147, 168, 87);
            chartArea1.AxisY.LabelStyle.Format = "€{0}";
            chartArea1.AxisY.LineColor = Color.FromArgb(147, 168, 87);
            chartArea1.AxisY.LineWidth = 0;
            chartArea1.AxisY.MajorGrid.LineColor = Color.FromArgb(147, 168, 87);
            chartArea1.AxisY.MajorTickMark.LineColor = Color.FromArgb(147, 168, 87);
            chartArea1.BackColor = Color.FromArgb(44, 51, 51);
            chartArea1.BorderColor = Color.Bisque;
            chartArea1.Name = "ChartArea1";
            chart_gross_revenue.ChartAreas.Add(chartArea1);
            legend1.BackColor = Color.FromArgb(44, 51, 51);
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Font = new Font("Cascadia Code", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            legend1.ForeColor = Color.White;
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            chart_gross_revenue.Legends.Add(legend1);
            chart_gross_revenue.Location = new Point(12, 171);
            chart_gross_revenue.Name = "chart_gross_revenue";
            series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            series1.BackSecondaryColor = Color.FromArgb(147, 168, 87);
            series1.BorderColor = Color.White;
            series1.BorderWidth = 5;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series1.Color = Color.FromArgb(167, 209, 41);
            series1.Legend = "Legend1";
            series1.MarkerColor = Color.FromArgb(167, 209, 41);
            series1.MarkerSize = 11;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Diamond;
            series1.Name = "Series1";
            series1.YValuesPerPoint = 2;
            chart_gross_revenue.Series.Add(series1);
            chart_gross_revenue.Size = new Size(1188, 320);
            chart_gross_revenue.TabIndex = 10;
            chart_gross_revenue.Text = "chart2";
            title1.Alignment = ContentAlignment.TopLeft;
            title1.Font = new Font("Cascadia Code", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            title1.ForeColor = Color.FromArgb(147, 168, 87);
            title1.Name = "Gross Revenue";
            title1.Text = "Gross Revenue";
            chart_gross_revenue.Titles.Add(title1);
            // 
            // chart_top_products
            // 
            chart_top_products.BackColor = Color.FromArgb(44, 51, 51);
            chartArea2.BackColor = Color.FromArgb(44, 51, 51);
            chartArea2.Name = "ChartArea1";
            chart_top_products.ChartAreas.Add(chartArea2);
            legend2.BackColor = Color.FromArgb(44, 51, 51);
            legend2.Font = new Font("Cascadia Code", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            legend2.ForeColor = Color.FromArgb(147, 168, 87);
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend1";
            chart_top_products.Legends.Add(legend2);
            chart_top_products.Location = new Point(718, 497);
            chart_top_products.Name = "chart_top_products";
            series2.BorderColor = Color.FromArgb(44, 51, 51);
            series2.BorderWidth = 5;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.Font = new Font("Cascadia Code", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            series2.IsValueShownAsLabel = true;
            series2.LabelForeColor = Color.White;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            chart_top_products.Series.Add(series2);
            chart_top_products.Size = new Size(482, 288);
            chart_top_products.TabIndex = 11;
            chart_top_products.Text = "chart2";
            title2.Alignment = ContentAlignment.TopLeft;
            title2.Font = new Font("Cascadia Code", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            title2.ForeColor = Color.FromArgb(147, 168, 87);
            title2.Name = "Top Products";
            title2.Text = "Top Products";
            chart_top_products.Titles.Add(title2);
            // 
            // panel_number_of_customers
            // 
            panel_number_of_customers.BackColor = Color.FromArgb(44, 51, 51);
            panel_number_of_customers.Controls.Add(pictureBox_customers);
            panel_number_of_customers.Controls.Add(label_customers_number);
            panel_number_of_customers.Controls.Add(label_number_of_customers);
            panel_number_of_customers.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point);
            panel_number_of_customers.Location = new Point(12, 497);
            panel_number_of_customers.Name = "panel_number_of_customers";
            panel_number_of_customers.Size = new Size(231, 77);
            panel_number_of_customers.TabIndex = 10;
            // 
            // pictureBox_customers
            // 
            pictureBox_customers.Image = (Image)resources.GetObject("pictureBox_customers.Image");
            pictureBox_customers.Location = new Point(0, 0);
            pictureBox_customers.Name = "pictureBox_customers";
            pictureBox_customers.Size = new Size(92, 77);
            pictureBox_customers.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_customers.TabIndex = 3;
            pictureBox_customers.TabStop = false;
            // 
            // label_customers_number
            // 
            label_customers_number.AutoSize = true;
            label_customers_number.Font = new Font("Cascadia Code", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label_customers_number.ForeColor = Color.FromArgb(167, 209, 41);
            label_customers_number.Location = new Point(101, 38);
            label_customers_number.Name = "label_customers_number";
            label_customers_number.Size = new Size(48, 28);
            label_customers_number.TabIndex = 1;
            label_customers_number.Text = "100";
            // 
            // label_number_of_customers
            // 
            label_number_of_customers.AutoSize = true;
            label_number_of_customers.Font = new Font("Cascadia Code", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label_number_of_customers.ForeColor = Color.FromArgb(147, 168, 87);
            label_number_of_customers.Location = new Point(98, 13);
            label_number_of_customers.Name = "label_number_of_customers";
            label_number_of_customers.Size = new Size(90, 20);
            label_number_of_customers.TabIndex = 0;
            label_number_of_customers.Text = "Customers";
            // 
            // panel_number_of_suppliers
            // 
            panel_number_of_suppliers.BackColor = Color.FromArgb(44, 51, 51);
            panel_number_of_suppliers.Controls.Add(pictureBox_suppliers);
            panel_number_of_suppliers.Controls.Add(label_suppliers_number);
            panel_number_of_suppliers.Controls.Add(label_number_of_suppliers);
            panel_number_of_suppliers.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point);
            panel_number_of_suppliers.Location = new Point(12, 580);
            panel_number_of_suppliers.Name = "panel_number_of_suppliers";
            panel_number_of_suppliers.Size = new Size(231, 122);
            panel_number_of_suppliers.TabIndex = 11;
            // 
            // pictureBox_suppliers
            // 
            pictureBox_suppliers.Image = (Image)resources.GetObject("pictureBox_suppliers.Image");
            pictureBox_suppliers.Location = new Point(3, 24);
            pictureBox_suppliers.Name = "pictureBox_suppliers";
            pictureBox_suppliers.Size = new Size(92, 77);
            pictureBox_suppliers.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_suppliers.TabIndex = 4;
            pictureBox_suppliers.TabStop = false;
            // 
            // label_suppliers_number
            // 
            label_suppliers_number.AutoSize = true;
            label_suppliers_number.Font = new Font("Cascadia Code", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label_suppliers_number.ForeColor = Color.FromArgb(167, 209, 41);
            label_suppliers_number.Location = new Point(98, 58);
            label_suppliers_number.Name = "label_suppliers_number";
            label_suppliers_number.Size = new Size(48, 28);
            label_suppliers_number.TabIndex = 1;
            label_suppliers_number.Text = "100";
            // 
            // label_number_of_suppliers
            // 
            label_number_of_suppliers.AutoSize = true;
            label_number_of_suppliers.Font = new Font("Cascadia Code", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label_number_of_suppliers.ForeColor = Color.FromArgb(147, 168, 87);
            label_number_of_suppliers.Location = new Point(98, 33);
            label_number_of_suppliers.Name = "label_number_of_suppliers";
            label_number_of_suppliers.Size = new Size(90, 20);
            label_number_of_suppliers.TabIndex = 0;
            label_number_of_suppliers.Text = "Suppliers";
            // 
            // panel_number_of_products
            // 
            panel_number_of_products.BackColor = Color.FromArgb(44, 51, 51);
            panel_number_of_products.Controls.Add(pictureBox_products);
            panel_number_of_products.Controls.Add(label_product_number);
            panel_number_of_products.Controls.Add(label_number_of_products);
            panel_number_of_products.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point);
            panel_number_of_products.Location = new Point(12, 708);
            panel_number_of_products.Name = "panel_number_of_products";
            panel_number_of_products.Size = new Size(231, 77);
            panel_number_of_products.TabIndex = 12;
            // 
            // pictureBox_products
            // 
            pictureBox_products.Image = (Image)resources.GetObject("pictureBox_products.Image");
            pictureBox_products.Location = new Point(0, 0);
            pictureBox_products.Name = "pictureBox_products";
            pictureBox_products.Size = new Size(92, 77);
            pictureBox_products.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_products.TabIndex = 5;
            pictureBox_products.TabStop = false;
            // 
            // label_product_number
            // 
            label_product_number.AutoSize = true;
            label_product_number.Font = new Font("Cascadia Code", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label_product_number.ForeColor = Color.FromArgb(167, 209, 41);
            label_product_number.Location = new Point(98, 40);
            label_product_number.Name = "label_product_number";
            label_product_number.Size = new Size(48, 28);
            label_product_number.TabIndex = 1;
            label_product_number.Text = "100";
            // 
            // label_number_of_products
            // 
            label_number_of_products.AutoSize = true;
            label_number_of_products.Font = new Font("Cascadia Code", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label_number_of_products.ForeColor = Color.FromArgb(147, 168, 87);
            label_number_of_products.Location = new Point(98, 15);
            label_number_of_products.Name = "label_number_of_products";
            label_number_of_products.Size = new Size(81, 20);
            label_number_of_products.TabIndex = 0;
            label_number_of_products.Text = "Products";
            // 
            // panel_low_stock
            // 
            panel_low_stock.BackColor = Color.FromArgb(44, 51, 51);
            panel_low_stock.Controls.Add(pictureBox1);
            panel_low_stock.Controls.Add(dataGridView_low_stock);
            panel_low_stock.Controls.Add(label_low_products);
            panel_low_stock.Location = new Point(249, 497);
            panel_low_stock.Name = "panel_low_stock";
            panel_low_stock.Size = new Size(463, 288);
            panel_low_stock.TabIndex = 13;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(58, 43);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // dataGridView_low_stock
            // 
            dataGridView_low_stock.AllowUserToResizeRows = false;
            dataGridView_low_stock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_low_stock.BackgroundColor = Color.FromArgb(44, 51, 51);
            dataGridView_low_stock.BorderStyle = BorderStyle.None;
            dataGridView_low_stock.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView_low_stock.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(44, 51, 51);
            dataGridViewCellStyle1.Font = new Font("Cascadia Code", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(167, 209, 41);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(44, 51, 51);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(167, 209, 41);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView_low_stock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView_low_stock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(44, 51, 51);
            dataGridViewCellStyle2.Font = new Font("Cascadia Code", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(147, 168, 87);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(167, 209, 41);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView_low_stock.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView_low_stock.EnableHeadersVisualStyles = false;
            dataGridView_low_stock.GridColor = Color.FromArgb(44, 51, 51);
            dataGridView_low_stock.Location = new Point(7, 42);
            dataGridView_low_stock.Margin = new Padding(10);
            dataGridView_low_stock.Name = "dataGridView_low_stock";
            dataGridView_low_stock.RowHeadersVisible = false;
            dataGridView_low_stock.RowTemplate.Height = 33;
            dataGridView_low_stock.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_low_stock.Size = new Size(449, 240);
            dataGridView_low_stock.TabIndex = 1;
            // 
            // label_low_products
            // 
            label_low_products.AutoSize = true;
            label_low_products.Font = new Font("Cascadia Code", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label_low_products.ForeColor = Color.FromArgb(147, 168, 87);
            label_low_products.Location = new Point(64, 0);
            label_low_products.Name = "label_low_products";
            label_low_products.Size = new Size(90, 20);
            label_low_products.TabIndex = 0;
            label_low_products.Text = "Low Stock";
            // 
            // label_title
            // 
            label_title.AutoSize = true;
            label_title.BackColor = Color.Black;
            label_title.Font = new Font("Cascadia Code", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label_title.ForeColor = Color.White;
            label_title.Location = new Point(12, 5);
            label_title.Name = "label_title";
            label_title.Size = new Size(239, 35);
            label_title.TabIndex = 14;
            label_title.Text = "My Fancy Store";
            // 
            // label_from
            // 
            label_from.AutoSize = true;
            label_from.Font = new Font("Cascadia Code", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label_from.ForeColor = Color.FromArgb(147, 168, 87);
            label_from.Location = new Point(401, 18);
            label_from.Name = "label_from";
            label_from.Size = new Size(40, 17);
            label_from.TabIndex = 15;
            label_from.Text = "From";
            // 
            // label_to
            // 
            label_to.AutoSize = true;
            label_to.Font = new Font("Cascadia Code", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label_to.ForeColor = Color.FromArgb(147, 168, 87);
            label_to.Location = new Point(401, 46);
            label_to.Name = "label_to";
            label_to.Size = new Size(24, 17);
            label_to.TabIndex = 16;
            label_to.Text = "To";
            // 
            // label_start_mask
            // 
            label_start_mask.AutoSize = true;
            label_start_mask.Font = new Font("Cascadia Code", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label_start_mask.ForeColor = Color.FromArgb(147, 168, 87);
            label_start_mask.Location = new Point(447, 14);
            label_start_mask.MinimumSize = new Size(145, 25);
            label_start_mask.Name = "label_start_mask";
            label_start_mask.Size = new Size(145, 25);
            label_start_mask.TabIndex = 17;
            label_start_mask.Text = "Jan 01, 2023";
            label_start_mask.TextAlign = ContentAlignment.MiddleCenter;
            label_start_mask.Click += Label_Start_Mask_Click;
            // 
            // label_end_mask
            // 
            label_end_mask.AutoSize = true;
            label_end_mask.Font = new Font("Cascadia Code", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label_end_mask.ForeColor = Color.FromArgb(147, 168, 87);
            label_end_mask.Location = new Point(447, 41);
            label_end_mask.MinimumSize = new Size(145, 25);
            label_end_mask.Name = "label_end_mask";
            label_end_mask.Size = new Size(145, 25);
            label_end_mask.TabIndex = 18;
            label_end_mask.Text = "Jan 01, 2023";
            label_end_mask.TextAlign = ContentAlignment.MiddleCenter;
            label_end_mask.Click += Label_End_Mask_Click;
            // 
            // button_previous
            // 
            button_previous.FlatAppearance.BorderColor = Color.FromArgb(44, 51, 51);
            button_previous.FlatAppearance.BorderSize = 2;
            button_previous.FlatStyle = FlatStyle.Flat;
            button_previous.Font = new Font("Cascadia Code SemiBold", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            button_previous.ForeColor = Color.White;
            button_previous.Location = new Point(598, 40);
            button_previous.Name = "button_previous";
            button_previous.Size = new Size(122, 29);
            button_previous.TabIndex = 19;
            button_previous.Text = "Previous";
            button_previous.UseVisualStyleBackColor = true;
            button_previous.Click += Button_Previous_Click;
            // 
            // label_greet
            // 
            label_greet.AutoSize = true;
            label_greet.BackColor = Color.Black;
            label_greet.Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label_greet.ForeColor = Color.White;
            label_greet.Location = new Point(17, 43);
            label_greet.Name = "label_greet";
            label_greet.Size = new Size(203, 16);
            label_greet.TabIndex = 20;
            label_greet.Text = "Looking forward to work with";
            // 
            // linkLabel_me
            // 
            linkLabel_me.AutoSize = true;
            linkLabel_me.LinkColor = Color.FromArgb(167, 209, 41);
            linkLabel_me.Location = new Point(37, 64);
            linkLabel_me.Name = "linkLabel_me";
            linkLabel_me.Size = new Size(182, 16);
            linkLabel_me.TabIndex = 21;
            linkLabel_me.TabStop = true;
            linkLabel_me.Text = "Made by Hristijan Stavrov";
            linkLabel_me.LinkClicked += LinkLabel_Me_LinkClicked;
            // 
            // label_heart
            // 
            label_heart.AutoSize = true;
            label_heart.BackColor = Color.Black;
            label_heart.Font = new Font("Cascadia Code", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label_heart.ForeColor = Color.IndianRed;
            label_heart.Location = new Point(220, 43);
            label_heart.Name = "label_heart";
            label_heart.Size = new Size(27, 18);
            label_heart.TabIndex = 22;
            label_heart.Text = "❤";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1212, 798);
            Controls.Add(label_heart);
            Controls.Add(linkLabel_me);
            Controls.Add(label_greet);
            Controls.Add(button_previous);
            Controls.Add(label_end_mask);
            Controls.Add(label_start_mask);
            Controls.Add(label_to);
            Controls.Add(label_from);
            Controls.Add(label_title);
            Controls.Add(panel_low_stock);
            Controls.Add(panel_number_of_products);
            Controls.Add(panel_number_of_suppliers);
            Controls.Add(panel_number_of_customers);
            Controls.Add(chart_top_products);
            Controls.Add(chart_gross_revenue);
            Controls.Add(panel_total_profit);
            Controls.Add(panel_total_revenue);
            Controls.Add(panel_number_of_orders);
            Controls.Add(button_set_dates);
            Controls.Add(button_custom_date);
            Controls.Add(button_today);
            Controls.Add(button_last_7_days);
            Controls.Add(button_last_30_days);
            Controls.Add(button_this_month);
            Controls.Add(date_time_picker_end);
            Controls.Add(date_time_picker_start);
            Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Dashboard";
            Load += Form1_Load;
            panel_number_of_orders.ResumeLayout(false);
            panel_number_of_orders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_number_of_orders).EndInit();
            panel_total_profit.ResumeLayout(false);
            panel_total_profit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_total_profit).EndInit();
            panel_total_revenue.ResumeLayout(false);
            panel_total_revenue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_total_revenue).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart_gross_revenue).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart_top_products).EndInit();
            panel_number_of_customers.ResumeLayout(false);
            panel_number_of_customers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_customers).EndInit();
            panel_number_of_suppliers.ResumeLayout(false);
            panel_number_of_suppliers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_suppliers).EndInit();
            panel_number_of_products.ResumeLayout(false);
            panel_number_of_products.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_products).EndInit();
            panel_low_stock.ResumeLayout(false);
            panel_low_stock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_low_stock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker date_time_picker_start;
        private DateTimePicker date_time_picker_end;
        private Button button_this_month;
        private Button button_last_30_days;
        private Button button_last_7_days;
        private Button button_today;
        private Button button_custom_date;
        private Button button_set_dates;
        private Panel panel_number_of_orders;
        private Label label_orders_number;
        private Label label_number_of_orders;
        private Panel panel_total_profit;
        private Label label_total_profit_number;
        private Label label_total_profit;
        private Panel panel_total_revenue;
        private Label label_total_revenue_number;
        private Label label_total_revenue;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_gross_revenue;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_top_products;
        private Panel panel_number_of_customers;
        private Label label_customers_number;
        private Label label_number_of_customers;
        private Panel panel_number_of_suppliers;
        private Label label_suppliers_number;
        private Label label_number_of_suppliers;
        private Panel panel_number_of_products;
        private Label label_product_number;
        private Label label_number_of_products;
        private Panel panel_low_stock;
        private Label label_low_products;
        private DataGridView dataGridView_low_stock;
        private Label label_title;
        private Label label_from;
        private Label label_to;
        private Label label_start_mask;
        private Label label_end_mask;
        private PictureBox pictureBox_number_of_orders;
        private PictureBox pictureBox_total_profit;
        private PictureBox pictureBox_total_revenue;
        private PictureBox pictureBox_customers;
        private PictureBox pictureBox_suppliers;
        private PictureBox pictureBox_products;
        private Label label_previous_orders_number;
        private Label label_previous_total_profit_number;
        private Label label_previous_total_revenue_number;
        private Button button_previous;
        private PictureBox pictureBox1;
        private Label label_greet;
        private LinkLabel linkLabel_me;
        private Label label_heart;
    }
}
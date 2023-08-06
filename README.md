# Dashboard-Store-App
Application for stores to track their profits!

 ## How to run the app
   1. Either fork or download the app and open the folder in your preferred IDE.
   2. To actually start this program, you must change the `ConnectionStrings` in the `appsettings.json` file.
      - Navigate to `Dashboard-Store-App > appsettings.json`.
      - ``` c#
            {
              "ConnectionStrings": {
                "MyDatabase": "Enter server name; DataBase=My_Fancy_Store; Integrated Security=true; Encrypt=False;"
              }
            }
        ```
      - Next use the `my_fancy_store_database.sql` file to create the database in your server.
        - For this I just run the `my_fancy_store_database.sql` file in the [SQL Server Management Studio (SSMS)](https://learn.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?redirectedfrom=MSDN&view=sql-server-ver16)
   3. Enjoy
    
 ## Features
- Presentation of detailed statistics.
- Fancy count up animation.
- Quick and easy swap between the days and months.
- Custom date pick.

 ## Database
- `NOTE: Database has data up to 2026`
- `Data created with: ` [Mockaroo](https://www.mockaroo.com/)

 ## How the app looks
![alt text](https://github.com/PinkFlamingoz/Dashboard-Statistics-App/blob/master/dsa1.png)
![alt text](https://github.com/PinkFlamingoz/Dashboard-Statistics-App/blob/master/dsa2.png)
![alt text](https://github.com/PinkFlamingoz/Dashboard-Statistics-App/blob/master/dsa3.png)

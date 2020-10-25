using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStore
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating object of Bronze card and giving to it Turnover and Purchase values
            Bronze bronze = new Bronze();

            // Case Prime
            bronze.Turnover = 0.0;
            bronze.PurchaseValue = 150.0; 

            /* Case 1
            bronze.Turnover = 90.0;
            bronze.PurchaseValue = 1000.0; */

            /* Case 2
            bronze.Turnover = 250.0; 
            bronze.PurchaseValue = 1000.0;  */

            /* Case 3
            bronze.Turnover = 350.0;
            bronze.PurchaseValue = 1000.0; */

            /* Case ERR
            bronze.Turnover = -150.0;
            bronze.PurchaseValue = 1000.0; */

            Console.WriteLine(bronze.report(bronze.PurchaseValue).ToString());


            // Creating object of Silver card and giving to it Turnover and Purchase values 
            Silver silver = new Silver();

            // Case Prime
            silver.Turnover = 600.0;
            silver.PurchaseValue = 850.0; 

            /* Case 1
            silver.Turnover = 250.0;
            silver.PurchaseValue = 1000.0; */

            /* Case 2
            silver.Turnover = 1000.0;
            silver.PurchaseValue = 1000.0; */

            /* Case ERR
            silver.Turnover = -1000.0;
            silver.PurchaseValue = 1000.0; */

            Console.WriteLine(silver.report(silver.PurchaseValue).ToString());


            // Creating object od Gold card and giving to it Turnover and Purchase values 
            Gold gold = new Gold();

            // Case Prime
            gold.Turnover = 1500.0;
            gold.PurchaseValue = 1300.0; 

            /* Case 1
            gold.Turnover = 90.0;
            gold.PurchaseValue = 1000.0; */

            /* Case 2
            gold.Turnover = 100.0;
            gold.PurchaseValue = 1000.0; */

            /* Case 3
            gold.Turnover = 650.0;
            gold.PurchaseValue = 1000.0; */

            /* Case 4
            gold.Turnover = 950.0;
            gold.PurchaseValue = 1000.0; */

            /* Case ERR
            gold.Turnover = -1505.0;
            gold.PurchaseValue = 1000.0; */

            Console.WriteLine(gold.report(gold.PurchaseValue).ToString());
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace LINQDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            AddDetails();

            Console.ReadLine();
        }

        public static void AddDetails()
        {
            DataTable table = new DataTable();

            //Crating Data base Columns
            table.Columns.Add("ID");
            table.Columns.Add("ProductName");

            //Adding Rows
            table.Rows.Add("1", "Arjun");
            table.Rows.Add("2", "Raj");
            table.Rows.Add("3", "Ram");

            DisplayDetails(table);

        }

        public static void DisplayDetails(DataTable table)
        {
            var productNames = from products in table.AsEnumerable() select products.Field<string>("productName");

            Console.WriteLine("Product Name: ");

            foreach(var item in productNames)
            {
                Console.WriteLine(item);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProduct
{
    public class LinqToDataTable
    {
        public void AddDataTable()
        {
            DataTable table = new DataTable();
            table.Columns.Add("ID");
            table.Columns.Add("ProductName");

            table.Rows.Add("1", "Tops");
            table.Rows.Add("2", "Shirts");
            table.Rows.Add("3", "T-shirt");
            table.Rows.Add("4", "jeanspant");
            table.Rows.Add("5", "Tops");
            table.Rows.Add("6", "yetr");
            table.Rows.Add("7", "Hoodies");
            table.Rows.Add("8", "JumpSuits");
            table.Rows.Add("9", "Froks");
            table.Rows.Add("10", "Pantns");
            table.Rows.Add("11", "Dupata");
            table.Rows.Add("12", "Lehanga");
            displayProductsFromTable(table);
        }
        public void displayProductsFromTable(DataTable table)
        {
            //method syntax
            var productNames = from products in table.AsEnumerable() select products.Field<string>("ProductName");
            Console.WriteLine("productNames:");
            foreach (string product in productNames)
            {
                Console.WriteLine(product);
            }
        }
    }
}

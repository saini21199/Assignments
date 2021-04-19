using System;
using System.Collections.Generic;

namespace product_catalog
{
    class Program
    {

        List<Category> categoryList = new List<Category>();
        static void Main(string[] args)
        {

            int input;
            Console.WriteLine("Select any option \n 1.Category \n 2.Product \n 3.Exit the App!");

            input = int.Parse(Console.ReadLine());

            switch (input) {
                case 1: Console.WriteLine("1. Enter a Category \n 2. List all Categories \n 3. Delete a Category \n  4. Search a Category");
                    input= int.Parse(Console.ReadLine());
                    operationOnCategory(input,"category");
                    break;

                case 2: Console.WriteLine("1. Enter a Product \n 2. List all products \n 3. Delete a Product \n  4. Search a Product");
                    break;

                case 3: return;
            }

        }

        public static void operationOnCategory(int input,string operationOn)
        {

            switch (input) {
                case 1: enteringDetails(operationOn);
                    break;
            }
        }

        private static void enteringDetails(string operationOn)
        {
            if (operationOn == "category")
            {
                string Name = Console.ReadLine();
                char[] Code = (Console.ReadLine()).ToCharArray();
                String Description = Console.ReadLine();
                
            }
            else {

                String Name = Console.ReadLine();
                String manufacturer = Console.ReadLine();
                char[] Code = (Console.ReadLine()).ToCharArray();
                String Description = Console.ReadLine();
                String sellingPrice = Console.ReadLine();
            }
        }
    }
}

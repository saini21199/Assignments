using System;
using System.Collections.Generic;
using System.Text;

namespace product_catalog
{
    public class Category
    {
        public static int Id { get; set; }
        public string Name { get; set; }
        public char[] Code { get; set; }
        public string Description { get; set; }

        
        public void addCategory(string name, char[] code, string description) {
            Category.Id++;
            Name = name;
            Code = code;
            Description = description;
        }

        public void displayAllCategories(List<Category> list) {
            for (int i = 0; i < list.Length - 1; i++) {
                if (list[i] != null)
                {
                    Console.WriteLine(Category.Id);
                    Console.WriteLine(list[i].Name);
                    Console.WriteLine(list[i].Code);
                    Console.WriteLine(list[i].Description);

                }
            }
        }

        public void deleteCategory(char [] code , int id) {

        }

        }
    }


using System;
using System.Threading.Tasks;

namespace ProductCatalog
{
    class Program
    {
        static void Main(string[] args)
        {
            EntitySelection select = new EntitySelection();

            CustomerChoice choice = new CustomerChoice();

            while (true)
            {
                int input = choice.selectAnOption();

                switch (input) {
                    case 1:
                        select.categorySelected();
                        break;
                    case 2:
                        select.productSelected();
                        break;
                    default:
                        Console.WriteLine("Invalid input!! Enter Again \n");
                        break;
                }
                Task.Delay(900);
                Console.Clear();

            }
        }
    }
}

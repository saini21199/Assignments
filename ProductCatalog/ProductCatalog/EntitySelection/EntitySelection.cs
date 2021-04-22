using System;
using System.Collections.Generic;
using System.Text;

namespace ProductCatalog
{
    public class EntitySelection
    {
        CustomerChoice choice = new CustomerChoice();
        Operations operations = new Operations();
        public void categorySelected()
        {
                int option1 = choice.selectInCategory();

            switch (option1) {
                case 1:
                    operations.AddCategory();
                    break;
                case 2:
                    operations.ListAllCategories();
                    break;
                case 3:
                    operations.DeleteCategory();
                    break;
                case 4:
                    operations.SearchCategory();
                    break;
            }

        }
        public void productSelected()
        {           
                int option1 = choice.selectInProduct();

            switch (option1)
            {
                case 1:
                    operations.AddProduct();
                    break;
                case 2:
                    operations.ListAllProducts();
                    break;
                case 3:
                    operations.DeleteProduct();
                    break;
                case 4:
                    operations.SearchProduct();
                    break;
            }
        }
    }
}

    


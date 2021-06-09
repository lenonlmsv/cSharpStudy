using _04_console_classes.structs;

namespace _04_console_classes.classes
{
    class Products {
        public Product ProductStr;
        public Product[] ProductList;

        public static int index = 0;

        public void AddProduct(Product productStr) {
            ProductList[index] = productStr;
            index ++;
        }
    } //End Product
}

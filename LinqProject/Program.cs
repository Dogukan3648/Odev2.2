
List<Category> categories = new List<Category>
{
    new Category{CattegoryId =1,CategoryName="Bilgisayar"},
    new Category{CattegoryId =2,CategoryName="Telefon"}
};

List<Product> products = new List<Product>
{
    new Product{ProductId=1,CategoryId=1,ProductName="Acer Laptop",QuantityPerUnit="32 GB RAM",UnitPrice=10000,UnitInStock=5},
    new Product{ProductId=2,CategoryId=1,ProductName="Asus Laptop",QuantityPerUnit="16 GB RAM",UnitPrice=9000,UnitInStock=3},
    new Product{ProductId=3,CategoryId=1,ProductName="HP Laptop",QuantityPerUnit="8 GB RAM",UnitPrice=7000,UnitInStock=2},
    new Product{ProductId=4,CategoryId=2,ProductName="Samsung Telefon",QuantityPerUnit="4 GB RAM",UnitPrice=5000,UnitInStock=15},
    new Product{ProductId=5,CategoryId=2,ProductName="Apple Telefon",QuantityPerUnit="8 GB RAM",UnitPrice=8000,UnitInStock=0}

};

Console.WriteLine("Algoritmik-----------------");

foreach (var product in products)
{
    if (product.UnitPrice > 5000 && product.UnitInStock>3)
    {
        Console.WriteLine(product.ProductName);
    }
   


}

Console.WriteLine("LİNQ--------------------");


var result = products.Where(product=>product.UnitPrice > 5000 && product.UnitInStock>3);

foreach (var product in result)
{
    Console.WriteLine(product.ProductName);


}

static List<Product> GetProducts(List<Product> products) {
    
    
    List<Product> filterProduct = new List<Product>();
    foreach (var product in products)
    {
        if (product.UnitPrice > 5000 && product.UnitInStock > 3)
        {
            filterProduct.Add(product);
        }

    }
    return filterProduct;
}


static List<Product> GetProductsLinq(List<Product> products)
{
    return products.Where(product => product.UnitPrice > 5000 && product.UnitInStock > 3).ToList();
}

class Product
{
    public int ProductId { get; set; }
    public int CategoryId { get; set; }
    public string ProductName { get; set; }
    public string QuantityPerUnit { get; set; }
    public decimal UnitPrice { get; set; }
    public int  UnitInStock { get; set; }

}

class Category
{
    public int CattegoryId { get; set; }
    public string CategoryName { get; set; }
}
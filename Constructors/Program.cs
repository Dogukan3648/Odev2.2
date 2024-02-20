
Customer customer1 = new Customer { Id = 1,FirstName= "Doğukan",LastName = "Bozkır",City = "İstanbul" };

Customer customer2 = new Customer();
customer2.Id = 2;
customer2.FirstName = "Muhammed";
customer2.LastName = "Emen";
customer2.City = "Batman";

Customer customer3 = new Customer(3,"Esra","Özcan","İstanbul");


Console.WriteLine(customer1.FirstName);
Console.WriteLine(customer2.FirstName);
Console.WriteLine(customer3.FirstName);



class Customer
{
    public Customer()
    {
        
    }
    public Customer(int id,string firstName,string lastName,string city)
    {
       Id = id;
        FirstName = firstName;
        LastName = lastName;
        City = city;
    }
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string City { get; set; }

}
int sayi1 = 10;
int sayi2 = 20;
sayi1 = sayi2;
sayi2 = 100;


Console.WriteLine("Sayı 1 = " + sayi1);

int[] numbers1 = new int[3] { 1, 2, 3 };
int[] numbers2 = new int[3] { 4, 5, 6 };

numbers1 = numbers2;
numbers2[0] = 1000;

Console.WriteLine("Sayılar 1 = " + numbers1[0]);

Person person1 = new Person();
Person person2 = new Person();

person1.FirstName = "Doğukan";
person2 = person1;
person1.FirstName = "Muhammed";
Console.WriteLine(person2.FirstName);

Customer customer = new Customer();
customer.FirstName = "Gülüzar";
customer.CreditCardNumber = "123456789";
Employee employee = new Employee();

Person person3 = customer;
Console.WriteLine(customer.CreditCardNumber);

PersonManager personManager = new PersonManager();
personManager.Add(person3);
personManager.Add(customer);
 personManager.Add(employee);




        class Person
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

class Customer : Person
{
    public string CreditCardNumber { get; set; }
}

class Employee : Person
{
    public string EmployeeNuber { get; set; }
}

class PersonManager
{
    public void Add(Person person)
    {
        Console.WriteLine(person.FirstName);
    }
}
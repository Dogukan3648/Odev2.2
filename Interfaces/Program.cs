
IPersonManager personManager = new CustonerManger();
personManager.Add();

IPersonManager personManager2 = new EmplyeeManager();
personManager2.Update();

IPersonManager personManager1 = new CustonerManger();
personManager1.Delete();

ProjectManager projectManager = new ProjectManager();
projectManager.Add(new InternManager());

interface IPersonManager
{
    public void Add();
    public void Update();
    public void Delete();
}

class CustonerManger : IPersonManager
{
    public void Add()
    {
        Console.WriteLine("Müşteri Eklendi");
    }

    public void Delete()
    {
        Console.WriteLine("Müşteri Silindi");
    }

    public void Update()
    {
        Console.WriteLine("Müşteri Güncellendi");
    }
}

class EmplyeeManager : IPersonManager
{
    public void Add()
    {
        Console.WriteLine("Personel Eklendi");
    }

    public void Delete()
    {
        Console.WriteLine("Personel Silindi");
    }

    public void Update()
    {
        Console.WriteLine("Personel Güncellendi");
    }
}

class InternManager : IPersonManager
{
    public void Add()
    {
        Console.WriteLine("Stajyer Eklendi");
    }

    public void Delete()
    {
        Console.WriteLine("Stajyer Silindi");
    }

    public void Update()
    {
        Console.WriteLine("Stajyer Güncellendi");
    }
}

class ProjectManager
{
    public void Add(IPersonManager personManager)
    {
        personManager.Add();
    }

}
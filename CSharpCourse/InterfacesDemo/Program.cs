IWorker[] workers = new IWorker[3]
{
    new Manager(),
    new Worker(),
    new Robot()
};

foreach (var worker in workers )
{
    worker.Work();
}

IEat[] eats = new IEat[2]
{
    new Manager(),
    new Worker()
};

foreach(var eat in eats )
{
    eat.Eat();
}


interface IWorker
{
    void Work();
}
interface IEat
{
    void Eat();
}
interface ISalary
{
    void GetSalary();
}


class Manager : IWorker, ISalary, IEat
{
    public void Work()
    {

    }
    public void Eat()
    {

    }
    public void GetSalary()
    {

    }
}
class Worker : IWorker, ISalary, IEat
{
    public void Work()
    {

    }
    public void Eat()
    {

    }
    public void GetSalary()
    {

    }

}
class Robot : IWorker
{
    public void Work()
    {

    }
}
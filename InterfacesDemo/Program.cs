using System;

namespace InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            IWorker[] workers = new IWorker[3]
            {
                new Worker(),
                new Robot(),
                new Managers()
            };

            foreach (var worker in workers)
            {
                worker.Work();
            }


            IEat[] eats = new IEat[]
            {
              new Worker(),
              new Managers()

            };

            foreach (var eat in eats )
            {
                eat.Eat();

            }


            ISalary[] salaries = new ISalary[2]
            {
                new Managers(),
                new Worker()

            };

            foreach (var salary in salaries)
            {
                salary.GetSalary();
            }




        }
    }



}

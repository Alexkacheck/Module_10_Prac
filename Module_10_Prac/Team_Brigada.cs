using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_10_Prac
{
    public class Team_Brigada
    {
        private List<IWorker> workers = new List<IWorker>();

        public void AddWorker(IWorker worker)
        {
            workers.Add(worker);
        }

        public void StartBuilding(House house)
        {
            foreach (var worker in workers)
            {
                worker.Work(new Basement());
                worker.Work(new Walls());
                worker.Work(new Walls());
                worker.Work(new Walls());
                worker.Work(new Walls());
                worker.Work(new Door());
                worker.Work(new Window());
                worker.Work(new Window());
                worker.Work(new Window());
                worker.Work(new Window());
                worker.Work(new Roof());
                worker.Work(new Basement());
               
                
            }

            Console.WriteLine("\nСтроительство завершено!");
            house.Show();
        }
    }
}

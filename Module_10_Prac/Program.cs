using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_10_Prac
{
    // Интерфейс для частей дома
    public interface IPart
    {
        string Name { get; set; }
        void Build();
    }

    // Интерфейс для строителей
    public interface IWorker
    {
        string Name { get; set; }
        void Work(IPart part);
    }

    // Класс строителя
    public class Worker : IWorker
    {
        public string Name { get; set; }

        public void Work(IPart part)
        {
            part.Build();
        }
    }

    // Класс бригадира
    public class TeamLeader : IWorker
    {
        public string Name { get; set; }

        public void Work(IPart part)
        {
            Console.WriteLine("Бригадир проверяет:");
            part.Build();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Создаем объекты
            House house = new House();
            Team_Brigada team = new Team_Brigada();
            team.AddWorker(new Worker { Name = "Строитель 1" });
            team.AddWorker(new Worker { Name = "Строитель 2" });
            team.AddWorker(new Worker { Name = "Строитель 3" });
            team.AddWorker(new TeamLeader { Name = "Бригадир" });

            // Запускаем строительство
            team.StartBuilding(house);

            Console.ReadKey();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_10_Prac
{
    // Класс дома
    public class House
    {
        private List<IPart> parts = new List<IPart>();

        public void AddPart(IPart part)
        {
            parts.Add(part);
        }

        public void Show()
        {
            Console.WriteLine("Дом построен. Состоит из:");

            Console.WriteLine("   /\\");
            Console.WriteLine("  /  \\");
            Console.WriteLine(" /    \\");
            Console.WriteLine("/______\\");

            Console.WriteLine("  |  |");
            Console.WriteLine(" /    \\");
            Console.WriteLine("|      |");

            Console.WriteLine("  /\\");
            Console.WriteLine(" /  \\");
            Console.WriteLine("/    \\");
            Console.WriteLine("|    |");

            Console.WriteLine("  /\\   /\\");
            Console.WriteLine(" /  \\ /  \\");
            Console.WriteLine("/    \\    \\");

            Console.WriteLine("   /\\   /\\");
            Console.WriteLine("  /  \\ /  \\");
            Console.WriteLine(" /    \\    \\");
            Console.WriteLine("/      \\    \\");
            Console.WriteLine("        \\    \\");
            Console.WriteLine("         \\____\\");
        }
    }
}

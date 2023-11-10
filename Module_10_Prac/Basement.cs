using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_10_Prac
{
    // Классы частей дома
    public class Basement : IPart
    {
        public string Name { get; set; } = "Фундамент";

        public void Build()
        {
            Console.WriteLine(Name);
        }
    }

    public class Walls : IPart
    {
        public string Name { get; set; } = "Стены";

        public void Build()
        {
            Console.WriteLine(Name);
        }
    }

    public class Door : IPart
    {
        public string Name { get; set; } = "Дверь";

        public void Build()
        {
            Console.WriteLine(Name);
        }
    }

    public class Window : IPart
    {
        public string Name { get; set; } = "Окно";

        public void Build()
        {
            Console.WriteLine(Name);
        }
    }

    public class Roof : IPart
    {
        public string Name { get; set; } = "Крыша";

        public void Build()
        {
            Console.WriteLine(Name);
        }
    }


}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
namespace Lab6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var eq1 = new QuadEquation(3,0,5);
            var i1 = new IntegratorQuad(eq1);
            var i2 = new IntegratorTrap(eq1);
            var i3 = new IntegratorSimpson(eq1);
            Console.WriteLine(i1.Integrate(-100, 100));
            Console.WriteLine(i2.Integrate(-100, 100));
            Console.WriteLine(i3.Integrate(-100, 100));
            Console.WriteLine(i1.TitleMethod);
            Console.WriteLine(i2.TitleMethod);
            Console.WriteLine(i3.TitleMethod);
            //ДопЗадание
        }
    }
}

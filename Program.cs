using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fantasy_Dice_Roller
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder b =Roller.Instance.MultipleDiceRoll(5, 20, 0,true);
            Console.WriteLine(b.ToString());
            Console.ReadLine();
        }
    }
}

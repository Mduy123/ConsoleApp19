using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    internal class Program
    {
        static void Main(string[] args)
        {
           tuong flotino = new tuong("flotino", 100, 100, 100);
            flotino.ten = "flotino";
            flotino.tancong = 100;
            flotino.phongthu = 100;
            flotino.HP = 100;

            flotino.chieu1();

            tuong bijan = new tuong();
            bijan.ten = "flotino";
            bijan.tancong = 100;
            bijan.phongthu = 500;
            bijan.HP = 100;
            bijan.HPchange(flotino.tancong, bijan.phongthu);

            var aya = new tuong("aya", 900);
            Console.ReadKey();
        }
    }
}

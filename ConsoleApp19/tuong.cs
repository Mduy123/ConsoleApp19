using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    public class tuong
    {
        public string ten { get; set; }
        public int tancong { get; set; }
        public int phongthu { get; set;}
        public int HP { get; set; }

        public tuong()
        {
            
        }

        public tuong(String ten, int HP)
        {
            this.ten = ten;
            this.HP = HP;
        }

        public tuong(string ten)
        {
            this.ten = ten;
        }

        public tuong(string ten, int tancong, int phongthu, int HP)
        {
            this.ten = ten;
            this.tancong = tancong;
            this.phongthu = phongthu;
            this.HP = HP;
        }
        public void chieu1()
        {
           this.tancong *= 2;
        }

        public void HPchange(int tancong, int phongthu)
        {
            this.HP -= (tancong - phongthu);
        }
    }
}

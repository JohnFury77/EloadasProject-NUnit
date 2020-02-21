using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EloadasProject
{
    public class Eloadas
    {
        bool[,] foglalasok;
        public Eloadas(int sorokSzama,int helyekSzama)
        {
            this.foglalasok = new bool[sorokSzama, helyekSzama];
        }


    }
}

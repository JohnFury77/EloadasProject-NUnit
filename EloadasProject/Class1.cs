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
            if (!(sorokSzama > 0) || !(helyekSzama > 0))  
            {
                throw new ArgumentException(String.Format("A paraméterek nem nagyobbak 0-nál."));
            }
            this.foglalasok = new bool[sorokSzama, helyekSzama];
            
        }


    }
}

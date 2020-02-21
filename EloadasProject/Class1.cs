using System;

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
        public bool Lefoglal()
        {
            bool vege = false;
            
                for (int i = 0; i < foglalasok.GetLength(0); i++)
                            {
                                for (int j = 0; j < foglalasok.GetLength(1); j++)
                                {
                    if (foglalasok[i, j] != true && vege == false) 
                                                {
                                                    foglalasok[i,j] = true;
                                                    vege = true;
                                                }
                                }
                            }
            return vege;
        }
        public int Szabadhelyek
        {
            get
            {
                int szabadhelyek = 0;
                
                return szabadhelyek;
            }
        }
        public bool Teli()
        {
            bool telivane = true;
            for (int i = 0; i < foglalasok.GetLength(0); i++)
            {
                for (int j = 0; j < foglalasok.GetLength(1); j++)
                {
                    if (foglalasok[i, j] == false)
                    {

                        telivane = false;

                    }
                }
            }
            return telivane;
        }
        public bool Foglalt(int sorSzam, int helySzam)
        {

            if (sorSzam<0||helySzam<0)
            {
                throw new ArgumentException();
            }
            return foglalasok[sorSzam, helySzam];
        }

    }
}

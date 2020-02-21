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
                for (int i = 0; i < foglalasok.GetLength(0); i++)
                {
                    for (int j = 0; j < foglalasok.GetLength(1); j++)
                    {
                        if (foglalasok[i, j] != true )
                        {

                            szabadhelyek++;
                            
                        }
                    }
                }
                return szabadhelyek;
            }
        }

    }
}

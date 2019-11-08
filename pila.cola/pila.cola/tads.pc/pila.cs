using System;
using System.Collections.Generic;
using System.Text;

namespace PilA.ColA.tads.pc
{
    class pila
    {
        private int[] datop = new int[3];

        public int[] DATAP
        {
            get { return datop; }
            set { datop = value; }
        }
        private int cima = -1;

        public int CIMA
        {
            get { return cima; }
            set { cima = value; }
        }
        public void Añadir(int num)
        {
            if (CIMA < DATAP.Length - 1)
            {
                CIMA++;
                DATAP[CIMA] = num;
            }

        }
        public void EliminarData()
        {
            if (CIMA == -1)
                throw new Exception("no hay datos dentro de la pila");
            else
                CIMA--;
        }
      
    }
}

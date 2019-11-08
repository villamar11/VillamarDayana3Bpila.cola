using System;
using System.Collections.Generic;
using System.Text;

namespace PilA.ColA.tads.pc
{
    class cola
    {

        private int[] dato = new int[3];

        public int[] DATO
        {
            get { return dato; }
            set { dato = value; }
        }
        private int ultimo = -1;

       
        private int Primero = -1;

        public int PRIMERO
        {
            get { return Primero; }
            set { Primero = value; }
        }
        public int ULTIMO
        {
            get { return ultimo; }
            set { ultimo = value; }
        }
        public void AÑadirdato(int numero)
        {
            if (ULTIMO < DATO.Length - 1)
            {
                ULTIMO++;
                DATO[ULTIMO] = numero;
            }
        }
        public void ELIMINARDATO()
        {
            if (ULTIMO == -1 && PRIMERO == -1)
                throw new Exception("No hay datos en la Pila");
            else
            {
                if (PRIMERO == ULTIMO)
                {
                    PRIMERO = -1;
                    ULTIMO = -1;
                }
                else
                {
                    PRIMERO++;
                }
            }

        }
      


    }
}

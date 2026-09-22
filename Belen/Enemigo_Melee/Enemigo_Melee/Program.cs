using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enemigo_Melee
{
    internal class Program
    {
        private int vida;
        private int daño;
        
        public void EnemigoMelee(int vidaInicial, int dañoInicial)
        {
            vida = vidaInicial;
            daño = dañoInicial;
        }

        public void RecibirDaño(int dañoRecibido)
        {
            vida -= dañoRecibido;

            if(vida < 0)
            {
                vida = 0;
            }
        }

        public int DañoRealizado()
        {
            return daño;
        }

        public bool EstaVivo()
        {
            return vida > 0;
        }

        public int VidaRestante()
        {
            return vida;
        }
    }
}

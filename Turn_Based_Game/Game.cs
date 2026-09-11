//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Clase3Progra
//{
//    internal class Game
//    {
//        private Jugador nuevoJugador;
//        private List<Enemigos> listaEnemigos = new List<Enemigos>();

//        public void Ejecutar()
//        {
//            Console.WriteLine("CREE A SU JUGADOR");

//            Console.WriteLine("Designe la vida de su jugador");

//            int vidaJugador = int.Parse(Console.ReadLine());

//            Console.WriteLine("Designe el daño que hará");
//            int dañoJugador = int.Parse(Console.ReadLine());

//            nuevoJugador = new Jugador(vidaJugador, dañoJugador);

//            Console.WriteLine("Su jugador ha sido creado exitosamente");

//            CrearEnemigos();
//            Combate();
//        }

//        public void CrearEnemigos()
//        {
//            Random randomAtributo = new Random();


//            Enemigo enemigo1 = new Enemigo(randomAtributo.Next(20, 36), randomAtributo.Next(20, 36));
//            Enemigo enemigo2 = new Enemigo(randomAtributo.Next(20, 36), randomAtributo.Next(20, 36));
//            Enemigo enemigo3 = new Enemigo(randomAtributo.Next(20, 36), randomAtributo.Next(20, 36));

//            listaEnemigos.Add(enemigo1);
//            listaEnemigos.Add(enemigo2);
//            listaEnemigos.Add(enemigo3);

//        }

//        public void Combate()
//        {
//            Console.WriteLine("COMBATE INICIADO");

//            while (listaEnemigos.Count > 0)
//            {
//                Console.WriteLine("Turno del Jugador");

//                int i = 1;
//                foreach (Enemigos enemigo in listaEnemigos)
//                {
//                    Console.WriteLine($"{i}.{enemigo.name} || {enemigo.vida} de vida || {enemigo.daño} de daño");
//                    i++;
//                }

//                Console.WriteLine("Seleccione el numero del enemigo que desee atacar");

//                int numeroEscogido = int.Parse(Console.ReadLine());

//                int dañoJugador = nuevoJugador.ObtenerDaño;

//                listaEnemigos[numeroEscogido - 1].vida -= dañoJugador;

//                if (listaEnemigos[numeroEscogido - 1].vida > 0)
//                {
//                    Console.WriteLine($"Enemigo atacado exitosamente");
//                }

//                else
//                {
//                    Console.WriteLine($"Enemigo derrotado");
//                    listaEnemigos.RemoveAt(numeroEscogido - 1);
//                }

//                if (listaEnemigos.Count == 0)
//                {
//                    Console.WriteLine("Enemigos derrotados");
//                    Console.WriteLine("VICTORIA");
//                    return;
//                }

//                else
//                {
//                    Console.WriteLine("Turno del Enemigo");

//                    foreach (Enemigos enemigo in listaEnemigos)
//                    {
//                        Console.WriteLine($"{enemigo.name} || {enemigo.vida} de vida || {enemigo.daño} de daño, ha atacado al jugador");

//                        nuevoJugador.RecibirDaño(enemigo.daño);
//                        Console.WriteLine("El jugador ha recibido daño");
//                        Console.WriteLine($"Vida restante del jugador: {nuevoJugador.vida}");

//                        if (nuevoJugador.vida <= 0)
//                        {
//                            Console.WriteLine("El jugador ha muerto");
//                            Console.WriteLine("DERROTA");
//                            return;
//                        }
//                    }
//                }
//            }

//        }
//    }
//}

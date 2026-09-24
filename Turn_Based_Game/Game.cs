//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Turn_Based_Game
//{
//    internal class Game
//    {
//        private Jugador nuevoJugador;
//        private List<Enemy> listaEnemigos = new List<Enemy>();

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
//            Random random = new Random();
//            for (int i = 0; i < 3; i++)
//            {
//                int tipo = random.Next(0, 2);
//                int randomAtributo = random.Next(20, 35);

//                if (tipo == 0)
//                {
//                    listaEnemigos.Add(new EnemyMele(randomAtributo, randomAtributo));
//                }
//                else
//                {
//                    listaEnemigos.Add(new EnemyRange(randomAtributo, randomAtributo));
//                }
//            }
//        }

//        public void Combate()
//        {
//            Console.WriteLine("COMBATE INICIADO");

//            while (listaEnemigos.Count > 0)
//            {
//                Console.WriteLine("Turno del Jugador");

//                int i = 1;

//                foreach (Enemy enemigo in listaEnemigos)
//                {
//                    Console.WriteLine($"{i}.{enemigo.name} || {enemigo.vida} de vida || {enemigo.daño} de daño");
//                    i++;
//                }

//                Console.WriteLine("Seleccione el numero del enemigo que desee atacar");

//                int numeroEscogido = int.Parse(Console.ReadLine());

//                int dañoJugador = nuevoJugador.GetDamage();

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

//                    foreach (Enemy enemigo in listaEnemigos)
//                    {
//                        if (enemigo is EnemyRange enemigoRango)
//                        {

//                            if (enemigoRango.Shoot() != 0)
//                            {
//                                Console.WriteLine($"{enemigoRango.GetType().Name} || {enemigoRango.vida} de vida || {enemigoRango.daño} de daño, ha atacado al jugador");

//                                nuevoJugador.TakeDamage(enemigo.GetDamage());
//                                Console.WriteLine("El jugador ha recibido daño");
//                                Console.WriteLine($"Vida restante del jugador: {nuevoJugador.Health}");

//                                if (!nuevoJugador.IsAlive())
//                                {
//                                    Console.WriteLine("El jugador ha muerto");
//                                    Console.WriteLine("DERROTA");
//                                    return;
//                                }
//                            }
//                        }

//                        else
//                        {
//                            Console.WriteLine($"{enemigo.GetType().Name} || {enemigo.vida} de vida || {enemigo.daño} de daño, ha atacado al jugador");

//                            nuevoJugador.TakeDamage(enemigo.GetDamage());
//                            Console.WriteLine("El jugador ha recibido daño");
//                            Console.WriteLine($"Vida restante del jugador: {nuevoJugador.Health}");

//                            if (!nuevoJugador.IsAlive())
//                            {
//                                Console.WriteLine("El jugador ha muerto");
//                                Console.WriteLine("DERROTA");
//                                return;
//                            }
//                        }

//                    }
//                }
//            }

//        }
//    }
//}
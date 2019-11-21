using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPOO
{
    class Game
    {
        private Player player;
        private Player[] players;
        private Board board;

        internal Player Player { get => player; set => player = value; }
        internal Player[] Players { get => players; set => players = value; }
        internal Board Board { get => board; set => board = value; }

        Board board1 = new Board();

        public void addBoat1() //revisa largo tablero y si el bote fue puesto
        {
            Console.WriteLine("Que bote desea agregar?: 1.Portaaviones   2.Fragata   3.Submarino    4.Reparador   5.Radar   escribir string");
            int bote = Console.Read();
            Console.WriteLine("ingrese posicion X del bote");
            int posicionX = Console.Read();
            Console.WriteLine("ingrese posicion Y del bote");
            int posicionY = Console.Read();
            Console.WriteLine("ingrese 0 para poner el bote horizontal y 1 para vertical");
            int orientacion = Console.Read();

            List<int> botes1 = new List<int>();
            while (botes1.Count < 5)
            {
                if (botes1.Contains(bote))
                {
                    Console.WriteLine("bote ya agregado");
                }
                else
                {
                    if (posicionX > 10 || posicionX < 0 || posicionY > 10 || posicionY < 0)
                    {
                        Console.WriteLine("fuera de rango");
                    }
                    else
                    {
                        if (bote == 5)
                        {

                        }
                    }

                }

            }


        }
        public void revTablero() //revisa que no halla un bote en el lugar y pone el bote si no hay
        {
            Console.WriteLine("Que bote desea agregar?: 1.Portaaviones   2.Fragata   3.Submarino    4.Reparador   5.Radar   escribir string");
            int bote = Console.Read();
            Console.WriteLine("ingrese posicion X del bote");
            int posicionX = Console.Read();
            Console.WriteLine("ingrese posicion Y del bote");
            int posicionY = Console.Read();
            Console.WriteLine("ingrese 0 para poner el bote horizontal y 1 para vertical");
            int orientacion = Console.Read();

            
            if (orientacion== 0)
            {
                if (posicionX + bote > 10)
                {
                    Console.WriteLine("pasa las coordenadas");
                }
                else
                {
                    if (board.horizontal[posicionY] != 0)
                    {
                        int i = posicionX;
                        int ocupado = 0;
                        while (i < posicionX + bote)
                        {
                            ocupado = 0;
                            if (board.horizontal[i] !=0 && board.vertical[posicionY] != 0)
                            {
                                Console.WriteLine("Espacio ocupado");
                                ocupado = 1;
                            }
                           
                        }
                        if (ocupado != 1)
                        {
                            while (i < posicionX + bote)
                            {
                                board.horizontal[i] = bote;
                                board.vertical[posicionY] = bote;
                                
                            }

                        }
                        
                    }
                }
            }
            else if (orientacion == 1)
            {
                if (posicionY + bote>10)
                {
                    Console.WriteLine("pasa las coordenadas");
                }
                else
                {
                    if(board.vertical[posicionX] != 0)
                    {
                        int i = posicionY;
                        int ocupado = 0;
                        while (i < posicionY + bote)
                        {
                            ocupado = 0;
                            if (board.vertical[i] != 0 && board.horizontal[posicionX] != 0)
                            {
                                Console.WriteLine("Espacio ocupado");
                                ocupado = 1;
                            }

                        }
                        if (ocupado != 1)
                        {
                            while (i < posicionY + bote)
                            {
                                board.vertical[i] = bote;
                                board.horizontal[posicionX] = bote;

                            }

                        }

                    }

                }
            }
        }
        public void ataqueNormal(Board board2)
        {

            Console.WriteLine("Ingrese coordenadas de ataque, ingrese numeros de 1 a 10");
            int x = Console.Read();
            int y = Console.Read();

            if (board2.horizontal[x]!=0 && board2.vertical[y]!=0 && board2.horizontal[x] == board2.vertical[x])
            {
                Console.WriteLine("Has derribado un bote");
                board2.horizontal[x] = 0;
                board2.vertical[y] = 0;
            }
                

        }
    }
}

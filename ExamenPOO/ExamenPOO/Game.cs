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

        public void addBoat1()
        {
            Console.WriteLine("Que bote desea agregar?: 1.Portaaviones   2.Fragata   3.Submarino    4.Reparador   5.Radar   escribir string");
            string bote = Console.ReadLine();
            Console.WriteLine("ingrese posicion X del bote");
            int posicionX = Console.Read();
            Console.WriteLine("ingrese posicion Y del bote");
            int posicionY = Console.Read();
            Console.WriteLine("ingrese 0 para poner el bote horizontal y 1 para vertical");
            int orientacion = Console.Read();

            List<string> botes1 = new List<string>();
            while (botes1.Count < 5)
            {
                if (botes1.Contains(bote))
                {
                    Console.WriteLine("bote ya agregado");
                }
                else
                {
                    if (posicionX>10 || posicionX < 0 || posicionY>10 || posicionY<0)
                    {
                        Console.WriteLine("fuera de rango");
                    }
                    else
                    {
                        if (bote == "portaaviones")
                        {
                            
                        }
                    }

                }

            }
            
            
        }
        public void revTablero()
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPOO
{
    class Embarcacion
    {
        private int name;//1 Radar, 2 Reparador, 3 Submarino, 4 Fragata, 5 Portaaviones
        private int largo;
        private string especial;
        private int vidas;
        private int espacios;

        public int Name { get => name; set => name = value; }
        public int Largo { get => largo; set => largo = value; }
        public string Ataque { get => especial; set => especial = value; }
        public int Vidas { get => vidas; set => vidas = value; }
    }
}

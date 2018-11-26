using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EffectsModeldata
{
    public class TipoSol
    {
        private double PM;
        private string arreglo;
        private string tiposol;
        private bool _NAOH;
        private bool _organica;
        private bool _inprganica;
        private int _NoEfectos;

        public string Arreglo { get => arreglo; set => arreglo = value; }
        public double PM1 { get => PM; set => PM = value; }
        public bool NAOH { get => _NAOH; set => _NAOH = value; }
        public int NoEfectos { get => _NoEfectos; set => _NoEfectos = value; }
        public bool Organica { get => _organica; set => _organica = value; }
        public bool Inprganica { get => _inprganica; set => _inprganica = value; }
    }
}

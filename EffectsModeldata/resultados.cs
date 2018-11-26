using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EffectsModeldata
{
    public class resultados
    {
        private double _area;
        private double _Cevaporativa;
        private double _Csumisnistrado;
        private double _Economia;
        private double _gastoDeMasa;
        private double _MasaVApor;

        public double Area { get => _area; set => _area = value; }
        public double Cevaporativa { get => _Cevaporativa; set => _Cevaporativa = value; }
        public double Csumisnistrado { get => _Csumisnistrado; set => _Csumisnistrado = value; }
        public double Economia { get => _Economia; set => _Economia = value; }
        public double GastoDeMasa { get => _gastoDeMasa; set => _gastoDeMasa = value; }
        public double MasaVApor { get => _MasaVApor; set => _MasaVApor = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace EffectsModeldata
{
    public class TiposVaporModel 
    {
        private double _tscv;
        public double Tscv
        {
            get => _tscv;
            set => _tscv = value;
        }

        private double _calidad;
        public double Calidad
        {
            get => _calidad;
            set => _calidad = value;
        }

        private double _perdidas;
        public double Perdidas
        {
            get => _perdidas;
            set => _perdidas = value;
        }

        private double _humedad;
        public double Humedad
        {
            get => _humedad;
            set => _humedad = value;
        }

    }
}

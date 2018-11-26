using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace EffectsModeldata
{
    public class PresionModel
    {

        private double _presionV;
        public double PresionV
        {
            get => _presionV;
            set => _presionV = value;
        }

        private double _presionC;
        public double PresionC
        {
            get => _presionC;
            set => _presionC = value;
        }

        private double _presionEV;
        public double PresionEV
        {
            get => _presionEV;
            set => _presionEV = value;
        }

    }
}

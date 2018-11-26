using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace EffectsModeldata
{
    public class ConcetracionesModel
    {
       

        private double _InicialXA;

        public double InicialXA
        {
            get => _InicialXA;
            set => _InicialXA = value;
        }

        private double _FinalXP;
        public double FinalXP
        {
            get => _FinalXP;
            set => _FinalXP = value;
        }

    }
}

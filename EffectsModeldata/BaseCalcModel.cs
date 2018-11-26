using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
namespace EffectsModeldata
{
    public class BaseCalcModel
    {
        

        private double _BaseMA;
        public double BaseMA
        { get => _BaseMA; set => _BaseMA = value;}

        private double _BaseMP;
        public double BaseMP
        { get => _BaseMP; set => _BaseMP = value; }

    }
}

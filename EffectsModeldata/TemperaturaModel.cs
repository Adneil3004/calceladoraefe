using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
namespace EffectsModeldata
{
    public class TemperaturaModel
    {
        private double _temV;
        public double TemV
        {
            get => _temV;
            set => _temV = value;
        }

        private double _temC;
        public double TemC
        {
            get => _temC;
            set => _temC = value;
        }

        private double _temA;
        public double TemA
        {
            get => _temA;
            set => _temA = value;
        }

        private double _temWater;
        public double TemWater
        {
            get => _temWater;
            set => _temWater = value;
        }

       
    }
}

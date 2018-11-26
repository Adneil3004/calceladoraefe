using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EffectsModeldata
{
    public class Tarrego
    {
        private int _idCAdena;
        private string _tipoArreglo;
        private string _configuracion;

        
        public int IdCAdena { get => _idCAdena; set => _idCAdena = value; }
        public string TipoArreglo { get => _tipoArreglo; set => _tipoArreglo = value; }
        public string Configuracion { get => _configuracion; set => _configuracion = value; }
    }
}

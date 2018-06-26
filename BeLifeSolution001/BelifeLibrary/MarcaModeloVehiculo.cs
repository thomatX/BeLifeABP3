using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelifeLibrary
{
    public class MarcaModeloVehiculo
    {

        public MarcaModeloVehiculo()
        {
            InitClass();
        }

        private void InitClass()
        {
            IdMarca = 0;
            IdModelo = 0;
        }

        public int IdMarca { get; set; }
        public int IdModelo { get; set; }

    }
}

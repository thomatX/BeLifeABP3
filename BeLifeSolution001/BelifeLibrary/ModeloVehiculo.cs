using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelifeLibrary
{
    public class ModeloVehiculo
    {

        public ModeloVehiculo()
        {
            InitClass();
        }

        private void InitClass()
        {
            Id = 0;
            Descripcion = String.Empty;
        }

        public int Id { get; set; }
        public string Descripcion { get; set; }

    }
}

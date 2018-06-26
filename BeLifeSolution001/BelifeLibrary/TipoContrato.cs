using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelifeLibrary
{
    public class TipoContrato
    {
        private int _id { get; set; }
        private string _descripcion { get; set; }
        public int Id {
            get { return _id; }

            set {
                _id = value;
            }
        }

        public string Descripcion {

            get { return _descripcion; }

            set
            {
                if (Negocio.Configuracion.ValidarDescTipoContrato(value))
                {
                    _descripcion = value;
                }
                else
                {
                    throw new Exception("La descripción del tipo de contrato debe ser mayor a " + Negocio.Configuracion.MINDESCTIPOCONTRATO + " y menor o igual a "+Negocio.Configuracion.MAXDESCTIPOCONTRATO+" caracteres.");
                }
            }
        }

        public TipoContrato() {

            InitClass();

        }

        private void InitClass()
        {
            _id = 0;
            _descripcion = String.Empty;
        }
    }
}

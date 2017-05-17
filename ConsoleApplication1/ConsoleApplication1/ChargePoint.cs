using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication1
{
    public class ChargePoint
    {
        public string Identificador { get; set; }
        public string NombreOrganismo { get; set; }
        public string Descripcion_es { get; set; }
        public string DatosPersonales { get; set; }
        public string Direccion { get; set; }
        public string Calle { get; set; }

        public string CodigoPostal { get; set; }
        public string Telefono { get; set; }
        public string FaxOficial { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string PaginaWeb { get; set; }

        public string Localidad_ID { get; set; }
        public string Localidad_NombreLocalidad { get; set; }
        public string SoloClasificar { get; set; }

        public string Posicion { get; set; }
        public string IdentificadorDirectorioSuperior { get; set; }
        public string ultimaActualizacion { get; set; }

        public string EnlaceAlContenido { get; set; }

    }
}

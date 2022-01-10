using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repte01_Francesc_Bague
{
    public class Data
    {
        public String Tipus { get; set; }
        public String Nom { get; set; }
        public String Ruta { get; set; }
        public DateTime Creacio { get; set; }

        public Data() { }
        public Data(String Tipus, String Nom, String Ruta, DateTime Creacio)
        {
            this.Tipus = Tipus;
            this.Nom = Nom;
            this.Ruta = Ruta;
            this.Creacio = Creacio;
        }
        public Data(String Tipus, String Nom)
        {
            this.Tipus = Tipus;
            this.Nom = Nom;
        }
    }
}

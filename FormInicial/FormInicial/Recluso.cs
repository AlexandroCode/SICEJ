using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormInicial
{
    class Recluso
    {
        public int ID_expediente { get; set; }
        public string Nombre { get; set; }
        public string App { get; set; }
        public string Apm { get; set; }
        public string rfc { get; set; }
        public string Apodo { get; set; }
        public string Genero { get; set; }
        public string Fechanacimiento { get; set; }
        public string Lugarnacimiento { get; set; }
        public string estadocivil { get; set; }
        public int id_escolaridad { get; set; }
        public string ocupacion { get; set; }
        public string grupoetnico { get; set; }
        public string conyuge { get; set; }
        public string nombrepadre { get; set; }
        public string nombremadre { get; set; }
        public string telefono { get; set; }
        public string parentesco { get; set; }
        public int id_nacionalidad { get; set; }

        public Recluso() { }

        public Recluso(int aID_expediente, string aNombre, string aApp, string aApm, string arfc, string aApodo, string aGenero, string aFechanacimiento, string aLugarnacimiento,
            string aestadocivil, int aid_escolaridad, string aocupacion, string agrupoetnico, string aconyuge,
            string anombrepadre, string anombremadre, string atelefono, string aparentesco, int aid_nacionalidad)
        {
            this.ID_expediente = aID_expediente;
            this.Nombre = aNombre;
            this.App = aApp;
            this.Apm = aApm;
            this.rfc = arfc;
            this.Apodo = aApodo;
            this.Genero = aGenero;
            this.Fechanacimiento = aFechanacimiento;
            this.Lugarnacimiento = aLugarnacimiento;
            this.estadocivil = aestadocivil;
            this.id_escolaridad = aid_escolaridad;
            this.ocupacion = aocupacion;
            this.grupoetnico = agrupoetnico;
            this.conyuge = aconyuge;
            this.nombrepadre = anombrepadre;
            this.nombremadre = anombremadre;
            this.telefono = atelefono;
            this.parentesco = aparentesco;
            this.id_nacionalidad = aid_nacionalidad;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace FormInicial
{
    class ReclusosData
    {
        public static int Agregar(Recluso aRecluso)
        {
            int ret = 0;
            MySqlCommand comando = new MySqlCommand(string.Format("Insert into Recluso (Nombre, App, Apm, Rfc, Apodo, Genero, Lugarnacimiento, Fechanacimiento, EstadoCivil, ID_escolaridad, Ocupacion, GrupoEtnico, Conyuge, NomPat, NomMat, Telefono, Parentezco, ID_nacionalidad) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11},'{12}','{13}','{14},'{15}','{16}','{17}')",
                aRecluso.Nombre, aRecluso.App, aRecluso.Apm, aRecluso.rfc, aRecluso.Apodo, aRecluso.Genero, aRecluso.Lugarnacimiento, aRecluso.Fechanacimiento, aRecluso.estadocivil, aRecluso.id_escolaridad, aRecluso.ocupacion, aRecluso.grupoetnico, aRecluso.conyuge, aRecluso.nombrepadre, aRecluso.nombremadre, aRecluso.telefono, aRecluso.parentesco, aRecluso.id_nacionalidad),ConectorBD.ObtenerConexion());
            ret = comando.ExecuteNonQuery();
            return ret;
        }
    }
}

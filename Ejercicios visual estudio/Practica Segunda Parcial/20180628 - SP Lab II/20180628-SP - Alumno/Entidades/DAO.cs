using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Entidades
{
    public class DAO : IArchivos <Votacion>
    {

        private SqlCommand ConectarABase(string stringConecction)
        {
            SqlConnection conexion;
            conexion = new SqlConnection(stringConecction);
            SqlCommand comando;
            comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = conexion;
            return comando;
        }

        public bool Guardar(string consulta, Votacion votacion)
        {
            SqlCommand comando = this.ConectarABase("Data Source=.\\SQLEXPRESS;" +
                "Initial Catalog=votacion-sp-2018;Integrated Security=True");
            comando.CommandText = "INSERT INTO dbo.Votaciones (nombreLey, afirmativos, negativos, abstenciones, nombreAlumno)" +
                $"VALUES ('{votacion.NombreLey}', {votacion.ContadorAfirmativo}, {votacion.ContadorNegativo}, {votacion.ContadorAbstencion}, 'Rodrigo')";
            comando.Connection.Open();
            comando.ExecuteNonQuery();
            return true;
        }
        
        public Votacion Leer(string xD)
        {
            throw new NotImplementedException();
        }

    }
}

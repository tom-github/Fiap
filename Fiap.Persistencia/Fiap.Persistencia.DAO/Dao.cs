using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Fiap.Persistencia.Dao
{
    public class Dao
    {
        protected SqlConnection cn;
        protected SqlCommand cmd;
        protected SqlDataReader reader;
        protected SqlDataAdapter da;

        private string conexao = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=DBCadastro;Data Source=localhost";

        public Dao()
        {
            cn = new SqlConnection();
            cmd = new SqlCommand();
            da = new SqlDataAdapter();
        }

        protected void AbrirConexao()
        {
            try
            {
                cn.ConnectionString = conexao;
                cn.Open();
                cmd.Connection = cn;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        protected void FecharConexao()
        {
            cn.Close();
        }

    }

}

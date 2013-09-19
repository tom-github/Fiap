using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.TargetFactory.DAL
{
    public class Dao
    {
        protected SqlConnection cn;
        protected SqlCommand cmd;
        protected SqlDataReader reader;
        protected SqlDataAdapter da;

        private const string conexao = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=TARGETFACTORY;Data Source=.\\SQLEXPRESS";

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

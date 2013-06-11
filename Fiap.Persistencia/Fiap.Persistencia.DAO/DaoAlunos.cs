using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Persistencia.Dao
{
    public class DaoAlunos : Dao
    {
        public Alunos Aluno { get; set; }

        public int IncluirAluno()
        {
            int status = 0;

            try
            {
                AbrirConexao();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "p_incluir_aluno";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@rm", Aluno.RM);
                cmd.Parameters.AddWithValue("@nome", Aluno.Nome);
                cmd.Parameters.AddWithValue("@curso", Aluno.Curso);
                cmd.Parameters.AddWithValue("@dataNasc", Aluno.DataNasc);

                cmd.Parameters.Add("@status", System.Data.SqlDbType.Int).Direction = System.Data.ParameterDirection.Output;

                cmd.ExecuteNonQuery();

                status = (int)cmd.Parameters["@status"].Value;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                FecharConexao();
            }

            return status;
        }
    }
}

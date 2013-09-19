using Fiap.TargetFactory.DAL;
using Fiap.TargetFactory.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.TargetFactory.DAL
{
    public class DaoRecurso : Dao
    {
        public int CadastrarAtualizarRecurso(Recurso recurso)
        {
            int status = 0;

            try
            {
                AbrirConexao();

                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "p_incluir_atualizar_recurso";
                cmd.Parameters.Clear();

                if (recurso.Id != 0)
                    cmd.Parameters.AddWithValue("@id_Recurso", recurso.Id);

                cmd.Parameters.AddWithValue("@Descricao", recurso.Descricao);
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
        public DataTable ListarTodosRecursos()
        {
            DataTable dt = new DataTable();

            try
            {
                AbrirConexao();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "p_buscar_todos_recursos";
                da.SelectCommand = cmd;
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                FecharConexao();
            }
            return dt;
        }
        public Recurso BuscarRecurso(int id)
        {
            Recurso recurso = null;

            try
            {
                AbrirConexao();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "p_buscar_recurso";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id_Recurso", id);
                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    recurso = new Recurso();
                    recurso.Id = Convert.ToInt32(reader["Id_Recurso"]);
                    recurso.Descricao = reader["Descricao"].ToString();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                FecharConexao();
            }

            return recurso;
        }
        public int ExcluirRecurso(int id)
        {
            int registros = 0;

            try
            {
                AbrirConexao();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "p_excluir_recurso";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id_Recurso", id);
                registros = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                FecharConexao();
            }
            return registros;
        }
    }
}
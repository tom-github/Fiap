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
    public class DaoOperador : Dao
    {
        public int CadastrarAtualizarOperador(Operador operador)
        {
            int status = 0;

            try
            {
                AbrirConexao();

                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "p_incluir_atualizar_operador";
                cmd.Parameters.Clear();

                if (operador.Id != 0)
                    cmd.Parameters.AddWithValue("@id_Operador", operador.Id);

                cmd.Parameters.AddWithValue("@Nome", operador.Nome);
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
        public DataTable ListarTodosOperadores()
        {
            DataTable dt = new DataTable();

            try
            {
                AbrirConexao();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "p_buscar_todos_operadores";
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
        public Operador BuscarOperador(int id)
        {
            Operador operador = null;

            try
            {
                AbrirConexao();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "p_buscar_operador";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id_Operador", id);
                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    operador = new Operador();
                    operador.Id = Convert.ToInt32(reader["Id_Operador"]);
                    operador.Nome = reader["Nome"].ToString();
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

            return operador;
        }
        public int ExcluirOperador(int id)
        {
            int registros = 0;

            try
            {
                AbrirConexao();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "p_excluir_operador";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id_Operador", id);
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
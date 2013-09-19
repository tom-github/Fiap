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
    public class DaoItem : Dao
    {
        public int CadastrarAtualizarItem(Item item)
        {
            int status = 0;

            try
            {
                AbrirConexao();

                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "p_incluir_atualizar_item";
                cmd.Parameters.Clear();

                if (item.Id != 0)
                    cmd.Parameters.AddWithValue("@id_Item", item.Id);

                cmd.Parameters.AddWithValue("@Descricao", item.Descricao);
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
        public DataTable ListarTodosItens()
        {
            DataTable dt = new DataTable();

            try
            {
                AbrirConexao();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "p_buscar_todos_itens";
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
        public Item BuscarItem(int id)
        {
            Item item = null;

            try
            {
                AbrirConexao();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "p_buscar_item";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id_Item", id);
                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    item = new Item();
                    item.Id = Convert.ToInt32(reader["Id_Item"]);
                    item.Descricao = reader["Descricao"].ToString();
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

            return item;
        }
        public int ExcluirItem(int id)
        {
            int registros = 0;

            try
            {
                AbrirConexao();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "p_excluir_item";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id_Item", id);
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
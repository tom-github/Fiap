using Fiap.TargetFactory.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.TargetFactory.DAL
{
    public class DaoMeta : Dao
    {
        public int CadastrarMeta(Meta meta)
        {
            int status = 0;

            try
            {
                AbrirConexao();

                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "p_incluir_meta";
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@id_recurso", meta.Id_Recurso);
                cmd.Parameters.AddWithValue("@id_item", meta.Id_Item);
                cmd.Parameters.AddWithValue("@item_hora", meta.ItemHora);

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
        public DataTable ListarTodasMetas()
        {
            DataTable dt = new DataTable();

            try
            {
                AbrirConexao();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "p_buscar_todas_metas";
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
        public int ExcluirMeta(int id)
        {
            int registros = 0;

            try
            {
                AbrirConexao();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "p_excluir_meta";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id_Meta", id);
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

        public Meta BuscarMeta(int recurso, int item)
        {
            Meta meta = null;

            try
            {
                AbrirConexao();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "p_buscar_meta";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id_Recurso", recurso);
                cmd.Parameters.AddWithValue("@id_Item", item);
                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    meta = new Meta();
                    meta.ItemHora = Convert.ToInt32(reader["Meta"]);
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

            return meta;
        }
    }
}

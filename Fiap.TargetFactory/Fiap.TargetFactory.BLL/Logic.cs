using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fiap.TargetFactory.DAL;
using Fiap.TargetFactory.Model;
using System.Data;

namespace Fiap.TargetFactory.BLL
{
    public class Logic
    {
        #region operador

        public int CadatrarAtualizarOperador(Operador operador)
        {
            try
            {
                return new DAL.DaoOperador().CadastrarAtualizarOperador(operador);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable ListarTodosOperadores()
        {
            try
            {
                return new DAL.DaoOperador().ListarTodosOperadores();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public Operador BuscarOperador(int id)
        {
            try
            {
                return new DAL.DaoOperador().BuscarOperador(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int ExcluirOperador(int id)
        {
            try
            {
                return new DAL.DaoOperador().ExcluirOperador(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region recurso

        public int CadatrarAtualizarRecurso(Recurso recurso)
        {
            try
            {
                return new DAL.DaoRecurso().CadastrarAtualizarRecurso(recurso);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable ListarTodosRecursos()
        {
            try
            {
                return new DAL.DaoRecurso().ListarTodosRecursos();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public Recurso BuscarRecurso(int id)
        {
            try
            {
                return new DAL.DaoRecurso().BuscarRecurso(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int ExcluirRecurso(int id)
        {
            try
            {
                return new DAL.DaoRecurso().ExcluirRecurso(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region item

        public int CadatrarAtualizarItem(Item item)
        {
            try
            {
                return new DAL.DaoItem().CadastrarAtualizarItem(item);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable ListarTodosItens()
        {
            try
            {
                return new DAL.DaoItem().ListarTodosItens();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public Item BuscarItem(int id)
        {
            try
            {
                return new DAL.DaoItem().BuscarItem(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int ExcluirItem(int id)
        {
            try
            {
                return new DAL.DaoItem().ExcluirItem(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region Meta

        public int CadatrarMeta(Meta meta)
        {
            try
            {
                return new DAL.DaoMeta().CadastrarMeta(meta);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable ListarTodasMetas()
        {
            try
            {
                return new DAL.DaoMeta().ListarTodasMetas();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int ExcluirMeta(int id)
        {
            try
            {
                return new DAL.DaoMeta().ExcluirMeta(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Meta BuscarMeta(int recurso, int item)
        {
            try
            {
                return new DAL.DaoMeta().BuscarMeta(recurso,item);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        #endregion

    }
}

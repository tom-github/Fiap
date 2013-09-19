using Fiap.TargetFactory.PL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TargetFactory
{
    public partial class FormTargetFactory : Form
    {
        #region variaveis

        FrmOrperadores frmOperadores;
        FrmRecursos frmRecursos;
        FrmItens frmItens;
        FrmMeta frmMeta;
        FrmSimuladorProducao frmSimuladorProducao;

        #endregion

        #region contrutor

        public FormTargetFactory()
        {
            InitializeComponent();
        }

        #endregion

        #region eventos

        private void operadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmOperadores == null || frmOperadores.IsDisposed)
            {
                frmOperadores = new FrmOrperadores();
                frmOperadores.MdiParent = this;
                frmOperadores.Show();
            }
        }
        private void recursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmSimuladorProducao == null || frmSimuladorProducao.IsDisposed)
            {
                frmRecursos = new FrmRecursos();
                frmRecursos.MdiParent = this;
                frmRecursos.Show();
            }
        }
        private void itemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmItens == null || frmItens.IsDisposed)
            {
                frmItens = new FrmItens();
                frmItens.MdiParent = this;
                frmItens.Show();
            }
        }
        private void metaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmMeta == null || frmMeta.IsDisposed)
            {
                frmMeta = new FrmMeta();
                frmMeta.MdiParent = this;
                frmMeta.Show();
            }
        }
        private void simularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmSimuladorProducao == null || frmSimuladorProducao.IsDisposed)
            {
                frmSimuladorProducao = new FrmSimuladorProducao();
                frmSimuladorProducao.MdiParent = this;
                frmSimuladorProducao.Show();
            }
        }
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
    }
}

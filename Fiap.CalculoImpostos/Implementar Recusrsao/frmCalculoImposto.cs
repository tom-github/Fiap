using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab01a
{
    public partial class frmCalculoImposto : Form
    {
        private double[] aliquota = { 0, 0.075, 0.15, 0.225, 0.275 };
        private double[] basecalculo = { 0, 1710.78, 2563.92, 3418.60, 4271.61 };
        private double descontodependente = 171.97;

        public frmCalculoImposto()
        {
            InitializeComponent();
        }


        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double salariobruto, irpf, inss, salarioliquido, deducaodependentes, pensaoalimenticia, previdenciaoficial, outrasdeducoes, basecalculo;
            int dependentes;

            salariobruto = double.Parse(txtSalarioBruto.Text);
            inss = salariobruto * 0.11;
            pensaoalimenticia = double.Parse(txtPensao.Text);
            previdenciaoficial = double.Parse(txtPrevidenciaOficial.Text);
            outrasdeducoes = double.Parse(txtOutrasDeducoes.Text);
            dependentes = int.Parse(txtDependentes.Text);
            deducaodependentes = descontodependente * dependentes;
            basecalculo = salariobruto - deducaodependentes - pensaoalimenticia - previdenciaoficial - outrasdeducoes;

            irpf = ValorIRPF(basecalculo, achaFaixa(basecalculo));

            salarioliquido = salariobruto - inss - irpf;

            txtINSS.Text = string.Format("{0:0.00}", inss);
            txtIRPF.Text = string.Format("{0:0.00}", irpf);
            txtSalarioLiquido.Text = string.Format("{0:0.00}", salarioliquido);

        }

        /// <summary>
        /// Localiza a faixa do IRPF que o usuário se enquadra
        /// </summary>
        /// <param name="salario"></param>
        /// <returns>Faixa da base de cálculo</returns>
        private Int32 achaFaixa(double salario)
        {
            int faixa = 1;
            for (faixa = 1; faixa < basecalculo.Length; faixa++)
            {
                if (salario < basecalculo[faixa])
                    break;
            }
            return faixa - 1;
        }


        /// <summary>
        /// Calcula o valor do IRPF
        /// </summary>
        /// <param name="salario"></param>
        /// <param name="pos"></param>
        /// <returns>Valor do IRPF para a faixa determinada</returns>
        private double ValorIRPF(double salario, int pos)
        {
            #region Modo 1
            // MODO 1: bloco de código com localização dos 'ponteiros' dos arrays
            //int posit;
            //double retorno = 0;
            //double acum = 0;
            //for (posit = pos; posit >= 1; posit--)
            //{
            //    acum = acum + basecalculo[posit - 1];
            //    if (posit == pos)
            //        retorno = retorno + (salario - basecalculo[posit]) * aliquota[posit];
            //    else
            //        retorno = retorno + ((basecalculo[posit + 1] - basecalculo[posit]) * aliquota[posit]);
            //}
            //return retorno;
            #endregion

            #region Modo 2
            // MODO 2: chamada recursiva, retorno em 1 única linha
            return Math.Round((pos == 0 ? 0 : Math.Round((salario - basecalculo[pos]) * aliquota[pos], 2) + Math.Round(ValorIRPF(basecalculo[pos], pos - 1), 2)), 2);
            #endregion
        }

    }
}

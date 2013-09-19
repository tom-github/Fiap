namespace Fiap.TargetFactory.PL
{
    partial class FrmSimuladorProducao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSimuladorProducao));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.gbProducao = new System.Windows.Forms.GroupBox();
            this.lstOperador = new System.Windows.Forms.ListBox();
            this.lblOperadorLabel = new System.Windows.Forms.Label();
            this.lstItem = new System.Windows.Forms.ListBox();
            this.lblRecursoLabel = new System.Windows.Forms.Label();
            this.lblItemLabel = new System.Windows.Forms.Label();
            this.lstRecurso = new System.Windows.Forms.ListBox();
            this.gbComandosMeta = new System.Windows.Forms.GroupBox();
            this.lblInstrucoes = new System.Windows.Forms.Label();
            this.lblMeta = new System.Windows.Forms.Label();
            this.btnParar = new System.Windows.Forms.Button();
            this.lblMetaLabel = new System.Windows.Forms.Label();
            this.lblQtdProduzidaLabel = new System.Windows.Forms.Label();
            this.lblInicioLabel = new System.Windows.Forms.Label();
            this.lblPecaHoraLabel = new System.Windows.Forms.Label();
            this.lblPecaPorHora = new System.Windows.Forms.Label();
            this.lblQtdProduzida = new System.Windows.Forms.Label();
            this.btnAcionar = new System.Windows.Forms.Button();
            this.lblInicio = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.gbProducao.SuspendLayout();
            this.gbComandosMeta.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // gbProducao
            // 
            this.gbProducao.Controls.Add(this.lstOperador);
            this.gbProducao.Controls.Add(this.lblOperadorLabel);
            this.gbProducao.Controls.Add(this.lstItem);
            this.gbProducao.Controls.Add(this.lblRecursoLabel);
            this.gbProducao.Controls.Add(this.lblItemLabel);
            this.gbProducao.Controls.Add(this.lstRecurso);
            this.gbProducao.Location = new System.Drawing.Point(9, 10);
            this.gbProducao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbProducao.Name = "gbProducao";
            this.gbProducao.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbProducao.Size = new System.Drawing.Size(602, 182);
            this.gbProducao.TabIndex = 10;
            this.gbProducao.TabStop = false;
            this.gbProducao.Text = "Simulador de Produção";
            // 
            // lstOperador
            // 
            this.lstOperador.DisplayMember = "Nome";
            this.lstOperador.FormattingEnabled = true;
            this.lstOperador.Location = new System.Drawing.Point(406, 35);
            this.lstOperador.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstOperador.Name = "lstOperador";
            this.lstOperador.Size = new System.Drawing.Size(182, 134);
            this.lstOperador.TabIndex = 9;
            this.lstOperador.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstOperador_MouseClick);
            // 
            // lblOperadorLabel
            // 
            this.lblOperadorLabel.AutoSize = true;
            this.lblOperadorLabel.Location = new System.Drawing.Point(404, 19);
            this.lblOperadorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOperadorLabel.Name = "lblOperadorLabel";
            this.lblOperadorLabel.Size = new System.Drawing.Size(51, 13);
            this.lblOperadorLabel.TabIndex = 8;
            this.lblOperadorLabel.Text = "Operador";
            // 
            // lstItem
            // 
            this.lstItem.DisplayMember = "Descricao";
            this.lstItem.FormattingEnabled = true;
            this.lstItem.Location = new System.Drawing.Point(210, 35);
            this.lstItem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstItem.Name = "lstItem";
            this.lstItem.Size = new System.Drawing.Size(182, 134);
            this.lstItem.TabIndex = 6;
            this.lstItem.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstItem_MouseClick);
            // 
            // lblRecursoLabel
            // 
            this.lblRecursoLabel.AutoSize = true;
            this.lblRecursoLabel.Location = new System.Drawing.Point(12, 19);
            this.lblRecursoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecursoLabel.Name = "lblRecursoLabel";
            this.lblRecursoLabel.Size = new System.Drawing.Size(47, 13);
            this.lblRecursoLabel.TabIndex = 4;
            this.lblRecursoLabel.Text = "Recurso";
            // 
            // lblItemLabel
            // 
            this.lblItemLabel.AutoSize = true;
            this.lblItemLabel.Location = new System.Drawing.Point(208, 19);
            this.lblItemLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblItemLabel.Name = "lblItemLabel";
            this.lblItemLabel.Size = new System.Drawing.Size(27, 13);
            this.lblItemLabel.TabIndex = 3;
            this.lblItemLabel.Text = "Item";
            // 
            // lstRecurso
            // 
            this.lstRecurso.DisplayMember = "Descricao";
            this.lstRecurso.FormattingEnabled = true;
            this.lstRecurso.Location = new System.Drawing.Point(14, 35);
            this.lstRecurso.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstRecurso.Name = "lstRecurso";
            this.lstRecurso.Size = new System.Drawing.Size(182, 134);
            this.lstRecurso.TabIndex = 0;
            this.lstRecurso.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstRecurso_MouseClick);
            // 
            // gbComandosMeta
            // 
            this.gbComandosMeta.Controls.Add(this.lblInstrucoes);
            this.gbComandosMeta.Controls.Add(this.lblMeta);
            this.gbComandosMeta.Controls.Add(this.btnParar);
            this.gbComandosMeta.Controls.Add(this.lblMetaLabel);
            this.gbComandosMeta.Controls.Add(this.lblQtdProduzidaLabel);
            this.gbComandosMeta.Controls.Add(this.lblInicioLabel);
            this.gbComandosMeta.Controls.Add(this.lblPecaHoraLabel);
            this.gbComandosMeta.Controls.Add(this.lblPecaPorHora);
            this.gbComandosMeta.Controls.Add(this.lblQtdProduzida);
            this.gbComandosMeta.Controls.Add(this.btnAcionar);
            this.gbComandosMeta.Controls.Add(this.lblInicio);
            this.gbComandosMeta.Controls.Add(this.btnSair);
            this.gbComandosMeta.Location = new System.Drawing.Point(9, 197);
            this.gbComandosMeta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbComandosMeta.Name = "gbComandosMeta";
            this.gbComandosMeta.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbComandosMeta.Size = new System.Drawing.Size(602, 232);
            this.gbComandosMeta.TabIndex = 11;
            this.gbComandosMeta.TabStop = false;
            // 
            // lblInstrucoes
            // 
            this.lblInstrucoes.Location = new System.Drawing.Point(12, 155);
            this.lblInstrucoes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInstrucoes.Name = "lblInstrucoes";
            this.lblInstrucoes.Size = new System.Drawing.Size(274, 72);
            this.lblInstrucoes.TabIndex = 24;
            this.lblInstrucoes.Text = "Instruções de operação: Ao acionar a máquina o tempo de produção e contagem das p" +
    "eças são iniciados, continue acionando até o fim da produção e clique em parar p" +
    "ara exibir o relatório.";
            // 
            // lblMeta
            // 
            this.lblMeta.AutoSize = true;
            this.lblMeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeta.ForeColor = System.Drawing.Color.Blue;
            this.lblMeta.Location = new System.Drawing.Point(309, 110);
            this.lblMeta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMeta.Name = "lblMeta";
            this.lblMeta.Size = new System.Drawing.Size(29, 31);
            this.lblMeta.TabIndex = 23;
            this.lblMeta.Text = "0";
            // 
            // btnParar
            // 
            this.btnParar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnParar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParar.ForeColor = System.Drawing.Color.Red;
            this.btnParar.Location = new System.Drawing.Point(398, 155);
            this.btnParar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnParar.Name = "btnParar";
            this.btnParar.Size = new System.Drawing.Size(98, 72);
            this.btnParar.TabIndex = 22;
            this.btnParar.Text = "Parar Máquina";
            this.btnParar.UseVisualStyleBackColor = true;
            this.btnParar.Click += new System.EventHandler(this.btnPara_Click);
            // 
            // lblMetaLabel
            // 
            this.lblMetaLabel.AutoSize = true;
            this.lblMetaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetaLabel.Location = new System.Drawing.Point(9, 110);
            this.lblMetaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMetaLabel.Name = "lblMetaLabel";
            this.lblMetaLabel.Size = new System.Drawing.Size(268, 31);
            this.lblMetaLabel.TabIndex = 21;
            this.lblMetaLabel.Text = "Meta (Peças/Hora):";
            // 
            // lblQtdProduzidaLabel
            // 
            this.lblQtdProduzidaLabel.AutoSize = true;
            this.lblQtdProduzidaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdProduzidaLabel.Location = new System.Drawing.Point(9, 77);
            this.lblQtdProduzidaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQtdProduzidaLabel.Name = "lblQtdProduzidaLabel";
            this.lblQtdProduzidaLabel.Size = new System.Drawing.Size(303, 31);
            this.lblQtdProduzidaLabel.TabIndex = 20;
            this.lblQtdProduzidaLabel.Text = "Quantidade Prodizida:";
            // 
            // lblInicioLabel
            // 
            this.lblInicioLabel.AutoSize = true;
            this.lblInicioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicioLabel.Location = new System.Drawing.Point(9, 15);
            this.lblInicioLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInicioLabel.Name = "lblInicioLabel";
            this.lblInicioLabel.Size = new System.Drawing.Size(265, 31);
            this.lblInicioLabel.TabIndex = 19;
            this.lblInicioLabel.Text = "Início de Produção:";
            // 
            // lblPecaHoraLabel
            // 
            this.lblPecaHoraLabel.AutoSize = true;
            this.lblPecaHoraLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPecaHoraLabel.Location = new System.Drawing.Point(9, 46);
            this.lblPecaHoraLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPecaHoraLabel.Name = "lblPecaHoraLabel";
            this.lblPecaHoraLabel.Size = new System.Drawing.Size(176, 31);
            this.lblPecaHoraLabel.TabIndex = 18;
            this.lblPecaHoraLabel.Text = "Peças/Hora:";
            // 
            // lblPecaPorHora
            // 
            this.lblPecaPorHora.AutoSize = true;
            this.lblPecaPorHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPecaPorHora.ForeColor = System.Drawing.Color.Blue;
            this.lblPecaPorHora.Location = new System.Drawing.Point(310, 46);
            this.lblPecaPorHora.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPecaPorHora.Name = "lblPecaPorHora";
            this.lblPecaPorHora.Size = new System.Drawing.Size(29, 31);
            this.lblPecaPorHora.TabIndex = 17;
            this.lblPecaPorHora.Text = "0";
            // 
            // lblQtdProduzida
            // 
            this.lblQtdProduzida.AutoSize = true;
            this.lblQtdProduzida.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdProduzida.ForeColor = System.Drawing.Color.Blue;
            this.lblQtdProduzida.Location = new System.Drawing.Point(309, 78);
            this.lblQtdProduzida.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQtdProduzida.Name = "lblQtdProduzida";
            this.lblQtdProduzida.Size = new System.Drawing.Size(29, 31);
            this.lblQtdProduzida.TabIndex = 16;
            this.lblQtdProduzida.Text = "0";
            // 
            // btnAcionar
            // 
            this.btnAcionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcionar.ForeColor = System.Drawing.Color.Red;
            this.btnAcionar.Location = new System.Drawing.Point(291, 155);
            this.btnAcionar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAcionar.Name = "btnAcionar";
            this.btnAcionar.Size = new System.Drawing.Size(102, 72);
            this.btnAcionar.TabIndex = 15;
            this.btnAcionar.Text = "Acionar Máquina";
            this.btnAcionar.UseVisualStyleBackColor = true;
            this.btnAcionar.Click += new System.EventHandler(this.btnAcionar_Click);
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicio.ForeColor = System.Drawing.Color.Blue;
            this.lblInicio.Location = new System.Drawing.Point(310, 15);
            this.lblInicio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(82, 31);
            this.lblInicio.TabIndex = 14;
            this.lblInicio.Text = "00:00";
            // 
            // btnSair
            // 
            this.btnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.Blue;
            this.btnSair.Location = new System.Drawing.Point(500, 155);
            this.btnSair.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(98, 72);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // FrmSimuladorProducao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 438);
            this.Controls.Add(this.gbComandosMeta);
            this.Controls.Add(this.gbProducao);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmSimuladorProducao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Target Factory - Simulador de Produção";
            this.Load += new System.EventHandler(this.FrmSimuladorProducao_Load);
            this.gbProducao.ResumeLayout(false);
            this.gbProducao.PerformLayout();
            this.gbComandosMeta.ResumeLayout(false);
            this.gbComandosMeta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.GroupBox gbProducao;
        private System.Windows.Forms.ListBox lstOperador;
        private System.Windows.Forms.Label lblOperadorLabel;
        private System.Windows.Forms.ListBox lstItem;
        private System.Windows.Forms.Label lblRecursoLabel;
        private System.Windows.Forms.Label lblItemLabel;
        private System.Windows.Forms.ListBox lstRecurso;
        private System.Windows.Forms.GroupBox gbComandosMeta;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnParar;
        private System.Windows.Forms.Label lblMetaLabel;
        private System.Windows.Forms.Label lblQtdProduzidaLabel;
        private System.Windows.Forms.Label lblInicioLabel;
        private System.Windows.Forms.Label lblPecaHoraLabel;
        private System.Windows.Forms.Label lblPecaPorHora;
        private System.Windows.Forms.Label lblQtdProduzida;
        private System.Windows.Forms.Button btnAcionar;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.Label lblMeta;
        private System.Windows.Forms.Label lblInstrucoes;
    }
}
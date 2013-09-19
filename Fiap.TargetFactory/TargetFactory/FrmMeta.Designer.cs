namespace Fiap.TargetFactory.PL
{
    partial class FrmMeta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMeta));
            this.gbMeta = new System.Windows.Forms.GroupBox();
            this.txtItemHora = new System.Windows.Forms.TextBox();
            this.lstItem = new System.Windows.Forms.ListBox();
            this.lblRecursoLabel = new System.Windows.Forms.Label();
            this.lblItemLabel = new System.Windows.Forms.Label();
            this.lbltdItemHoraLabel = new System.Windows.Forms.Label();
            this.lstRecurso = new System.Windows.Forms.ListBox();
            this.gbComandosMeta = new System.Windows.Forms.GroupBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.dgMetas = new System.Windows.Forms.DataGridView();
            this.gbMeta.SuspendLayout();
            this.gbComandosMeta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMetas)).BeginInit();
            this.SuspendLayout();
            // 
            // gbMeta
            // 
            this.gbMeta.Controls.Add(this.txtItemHora);
            this.gbMeta.Controls.Add(this.lstItem);
            this.gbMeta.Controls.Add(this.lblRecursoLabel);
            this.gbMeta.Controls.Add(this.lblItemLabel);
            this.gbMeta.Controls.Add(this.lbltdItemHoraLabel);
            this.gbMeta.Controls.Add(this.lstRecurso);
            this.gbMeta.Location = new System.Drawing.Point(9, 10);
            this.gbMeta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbMeta.Name = "gbMeta";
            this.gbMeta.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbMeta.Size = new System.Drawing.Size(405, 214);
            this.gbMeta.TabIndex = 0;
            this.gbMeta.TabStop = false;
            this.gbMeta.Text = "Meta";
            // 
            // txtItemHora
            // 
            this.txtItemHora.Location = new System.Drawing.Point(316, 179);
            this.txtItemHora.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtItemHora.Name = "txtItemHora";
            this.txtItemHora.Size = new System.Drawing.Size(76, 20);
            this.txtItemHora.TabIndex = 7;
            this.txtItemHora.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtItemHora_KeyPress);
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
            // lbltdItemHoraLabel
            // 
            this.lbltdItemHoraLabel.AutoSize = true;
            this.lbltdItemHoraLabel.Location = new System.Drawing.Point(12, 183);
            this.lbltdItemHoraLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltdItemHoraLabel.Name = "lbltdItemHoraLabel";
            this.lbltdItemHoraLabel.Size = new System.Drawing.Size(285, 13);
            this.lbltdItemHoraLabel.TabIndex = 2;
            this.lbltdItemHoraLabel.Text = "Quantidade de peças que deverão ser produzidas por hora";
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
            // 
            // gbComandosMeta
            // 
            this.gbComandosMeta.Controls.Add(this.btnSair);
            this.gbComandosMeta.Controls.Add(this.btnExcluir);
            this.gbComandosMeta.Controls.Add(this.btnSalvar);
            this.gbComandosMeta.Location = new System.Drawing.Point(10, 229);
            this.gbComandosMeta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbComandosMeta.Name = "gbComandosMeta";
            this.gbComandosMeta.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbComandosMeta.Size = new System.Drawing.Size(404, 50);
            this.gbComandosMeta.TabIndex = 8;
            this.gbComandosMeta.TabStop = false;
            // 
            // btnSair
            // 
            this.btnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSair.Location = new System.Drawing.Point(334, 17);
            this.btnSair.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(56, 19);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExcluir.Location = new System.Drawing.Point(74, 17);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(56, 19);
            this.btnExcluir.TabIndex = 4;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalvar.Location = new System.Drawing.Point(14, 17);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(56, 19);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // dgMetas
            // 
            this.dgMetas.AllowUserToAddRows = false;
            this.dgMetas.AllowUserToDeleteRows = false;
            this.dgMetas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgMetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMetas.Location = new System.Drawing.Point(9, 292);
            this.dgMetas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgMetas.Name = "dgMetas";
            this.dgMetas.RowTemplate.Height = 24;
            this.dgMetas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgMetas.Size = new System.Drawing.Size(404, 122);
            this.dgMetas.TabIndex = 7;
            // 
            // FrmMeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 423);
            this.Controls.Add(this.dgMetas);
            this.Controls.Add(this.gbComandosMeta);
            this.Controls.Add(this.gbMeta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmMeta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Target Factory - Cadastro de Metas";
            this.Load += new System.EventHandler(this.FrmMeta_Load);
            this.gbMeta.ResumeLayout(false);
            this.gbMeta.PerformLayout();
            this.gbComandosMeta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgMetas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbMeta;
        private System.Windows.Forms.TextBox txtItemHora;
        private System.Windows.Forms.ListBox lstItem;
        private System.Windows.Forms.Label lblRecursoLabel;
        private System.Windows.Forms.Label lblItemLabel;
        private System.Windows.Forms.Label lbltdItemHoraLabel;
        private System.Windows.Forms.ListBox lstRecurso;
        private System.Windows.Forms.GroupBox gbComandosMeta;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DataGridView dgMetas;
    }
}
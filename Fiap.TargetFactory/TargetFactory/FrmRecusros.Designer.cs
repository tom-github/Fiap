namespace Fiap.TargetFactory.PL
{
    partial class FrmRecursos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRecursos));
            this.dgRecursos = new System.Windows.Forms.DataGridView();
            this.gbComandosRecursos = new System.Windows.Forms.GroupBox();
            this.btnNovoCancelar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.gbItem = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblIdLabel = new System.Windows.Forms.Label();
            this.lblDescLabel = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgRecursos)).BeginInit();
            this.gbComandosRecursos.SuspendLayout();
            this.gbItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgRecursos
            // 
            this.dgRecursos.AllowUserToAddRows = false;
            this.dgRecursos.AllowUserToDeleteRows = false;
            this.dgRecursos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgRecursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRecursos.Location = new System.Drawing.Point(12, 189);
            this.dgRecursos.MultiSelect = false;
            this.dgRecursos.Name = "dgRecursos";
            this.dgRecursos.ReadOnly = true;
            this.dgRecursos.RowTemplate.Height = 24;
            this.dgRecursos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgRecursos.Size = new System.Drawing.Size(422, 207);
            this.dgRecursos.TabIndex = 9;
            this.dgRecursos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgRecursos_MouseClick);
            // 
            // gbComandosRecursos
            // 
            this.gbComandosRecursos.Controls.Add(this.btnNovoCancelar);
            this.gbComandosRecursos.Controls.Add(this.btnSair);
            this.gbComandosRecursos.Controls.Add(this.btnExcluir);
            this.gbComandosRecursos.Controls.Add(this.btnSalvar);
            this.gbComandosRecursos.Location = new System.Drawing.Point(12, 122);
            this.gbComandosRecursos.Name = "gbComandosRecursos";
            this.gbComandosRecursos.Size = new System.Drawing.Size(423, 61);
            this.gbComandosRecursos.TabIndex = 8;
            this.gbComandosRecursos.TabStop = false;
            // 
            // btnNovoCancelar
            // 
            this.btnNovoCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnNovoCancelar.Location = new System.Drawing.Point(18, 21);
            this.btnNovoCancelar.Name = "btnNovoCancelar";
            this.btnNovoCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnNovoCancelar.TabIndex = 6;
            this.btnNovoCancelar.Text = "Novo";
            this.btnNovoCancelar.UseVisualStyleBackColor = true;
            this.btnNovoCancelar.Click += new System.EventHandler(this.btnNovoCancelar_Click);
            // 
            // btnSair
            // 
            this.btnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSair.Location = new System.Drawing.Point(342, 21);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Location = new System.Drawing.Point(180, 21);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 4;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Location = new System.Drawing.Point(99, 21);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // gbItem
            // 
            this.gbItem.Controls.Add(this.btnBuscar);
            this.gbItem.Controls.Add(this.txtId);
            this.gbItem.Controls.Add(this.lblIdLabel);
            this.gbItem.Controls.Add(this.lblDescLabel);
            this.gbItem.Controls.Add(this.txtDesc);
            this.gbItem.Location = new System.Drawing.Point(12, 13);
            this.gbItem.Name = "gbItem";
            this.gbItem.Size = new System.Drawing.Size(423, 85);
            this.gbItem.TabIndex = 7;
            this.gbItem.TabStop = false;
            this.gbItem.Text = "Item";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(189, 27);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(83, 27);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 22);
            this.txtId.TabIndex = 0;
            this.txtId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtId_KeyPress);
            // 
            // lblIdLabel
            // 
            this.lblIdLabel.AutoSize = true;
            this.lblIdLabel.Location = new System.Drawing.Point(6, 30);
            this.lblIdLabel.Name = "lblIdLabel";
            this.lblIdLabel.Size = new System.Drawing.Size(21, 17);
            this.lblIdLabel.TabIndex = 4;
            this.lblIdLabel.Text = "ID";
            // 
            // lblDescLabel
            // 
            this.lblDescLabel.AutoSize = true;
            this.lblDescLabel.Location = new System.Drawing.Point(6, 57);
            this.lblDescLabel.Name = "lblDescLabel";
            this.lblDescLabel.Size = new System.Drawing.Size(71, 17);
            this.lblDescLabel.TabIndex = 3;
            this.lblDescLabel.Text = "Descrição";
            // 
            // txtDesc
            // 
            this.txtDesc.Enabled = false;
            this.txtDesc.Location = new System.Drawing.Point(83, 54);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(334, 22);
            this.txtDesc.TabIndex = 2;
            // 
            // FrmRecursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 409);
            this.Controls.Add(this.dgRecursos);
            this.Controls.Add(this.gbComandosRecursos);
            this.Controls.Add(this.gbItem);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRecursos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Target Factory - Cadastro de Recursos";
            this.Load += new System.EventHandler(this.frmCadastroRecursos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgRecursos)).EndInit();
            this.gbComandosRecursos.ResumeLayout(false);
            this.gbItem.ResumeLayout(false);
            this.gbItem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgRecursos;
        private System.Windows.Forms.GroupBox gbComandosRecursos;
        private System.Windows.Forms.Button btnNovoCancelar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.GroupBox gbItem;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblIdLabel;
        private System.Windows.Forms.Label lblDescLabel;
        private System.Windows.Forms.TextBox txtDesc;
    }
}
namespace Fiap.TargetFactory.PL
{
    partial class FrmOrperadores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOrperadores));
            this.gbOperador = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblIdLabel = new System.Windows.Forms.Label();
            this.lblNomeLabel = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.gbComandosOperador = new System.Windows.Forms.GroupBox();
            this.btnNovoCancelar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.dgOperadores = new System.Windows.Forms.DataGridView();
            this.gbOperador.SuspendLayout();
            this.gbComandosOperador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOperadores)).BeginInit();
            this.SuspendLayout();
            // 
            // gbOperador
            // 
            this.gbOperador.Controls.Add(this.btnBuscar);
            this.gbOperador.Controls.Add(this.txtId);
            this.gbOperador.Controls.Add(this.lblIdLabel);
            this.gbOperador.Controls.Add(this.lblNomeLabel);
            this.gbOperador.Controls.Add(this.txtNome);
            this.gbOperador.Location = new System.Drawing.Point(12, 12);
            this.gbOperador.Name = "gbOperador";
            this.gbOperador.Size = new System.Drawing.Size(423, 85);
            this.gbOperador.TabIndex = 2;
            this.gbOperador.TabStop = false;
            this.gbOperador.Text = "Operador";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(163, 26);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(57, 27);
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
            // lblNomeLabel
            // 
            this.lblNomeLabel.AutoSize = true;
            this.lblNomeLabel.Location = new System.Drawing.Point(6, 57);
            this.lblNomeLabel.Name = "lblNomeLabel";
            this.lblNomeLabel.Size = new System.Drawing.Size(45, 17);
            this.lblNomeLabel.TabIndex = 3;
            this.lblNomeLabel.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(57, 54);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(360, 22);
            this.txtNome.TabIndex = 2;
            // 
            // gbComandosOperador
            // 
            this.gbComandosOperador.Controls.Add(this.btnNovoCancelar);
            this.gbComandosOperador.Controls.Add(this.btnSair);
            this.gbComandosOperador.Controls.Add(this.btnExcluir);
            this.gbComandosOperador.Controls.Add(this.btnSalvar);
            this.gbComandosOperador.Location = new System.Drawing.Point(12, 121);
            this.gbComandosOperador.Name = "gbComandosOperador";
            this.gbComandosOperador.Size = new System.Drawing.Size(423, 61);
            this.gbComandosOperador.TabIndex = 5;
            this.gbComandosOperador.TabStop = false;
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
            // dgOperadores
            // 
            this.dgOperadores.AllowUserToAddRows = false;
            this.dgOperadores.AllowUserToDeleteRows = false;
            this.dgOperadores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgOperadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOperadores.Location = new System.Drawing.Point(12, 188);
            this.dgOperadores.MultiSelect = false;
            this.dgOperadores.Name = "dgOperadores";
            this.dgOperadores.ReadOnly = true;
            this.dgOperadores.RowTemplate.Height = 24;
            this.dgOperadores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgOperadores.Size = new System.Drawing.Size(422, 207);
            this.dgOperadores.TabIndex = 6;
            this.dgOperadores.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgOperadores_MouseClick);
            // 
            // FrmOrperadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 409);
            this.ControlBox = false;
            this.Controls.Add(this.dgOperadores);
            this.Controls.Add(this.gbComandosOperador);
            this.Controls.Add(this.gbOperador);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmOrperadores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Target Factory - Cadastro de Operadores";
            this.Load += new System.EventHandler(this.frmCadastroOperadores_Load);
            this.gbOperador.ResumeLayout(false);
            this.gbOperador.PerformLayout();
            this.gbComandosOperador.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgOperadores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbOperador;
        private System.Windows.Forms.Label lblNomeLabel;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblIdLabel;
        private System.Windows.Forms.GroupBox gbComandosOperador;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DataGridView dgOperadores;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnNovoCancelar;


    }
}
namespace CaixaEletronico
{
    partial class FormATM
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
            this.btnCalculate = new Fiap.CustomControls.MyButton();
            this.myGroupBox1 = new Fiap.CustomControls.MyGroupBox();
            this.txtAmountCashValue2 = new Fiap.CustomControls.MyTextBox();
            this.myLabel6 = new Fiap.CustomControls.MyLabel();
            this.txtAmountCashValue5 = new Fiap.CustomControls.MyTextBox();
            this.myLabel5 = new Fiap.CustomControls.MyLabel();
            this.txtAmountCashValue10 = new Fiap.CustomControls.MyTextBox();
            this.myLabel4 = new Fiap.CustomControls.MyLabel();
            this.txtAmountCashValue20 = new Fiap.CustomControls.MyTextBox();
            this.myLabel3 = new Fiap.CustomControls.MyLabel();
            this.txtAmountCashValue50 = new Fiap.CustomControls.MyTextBox();
            this.myLabel2 = new Fiap.CustomControls.MyLabel();
            this.txtValueDrawee = new Fiap.CustomControls.MyTextBox();
            this.myLabel1 = new Fiap.CustomControls.MyLabel();
            this.myGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Enabled = false;
            this.btnCalculate.Location = new System.Drawing.Point(187, 58);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(100, 28);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "calcular";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // myGroupBox1
            // 
            this.myGroupBox1.Controls.Add(this.txtAmountCashValue2);
            this.myGroupBox1.Controls.Add(this.myLabel6);
            this.myGroupBox1.Controls.Add(this.txtAmountCashValue5);
            this.myGroupBox1.Controls.Add(this.myLabel5);
            this.myGroupBox1.Controls.Add(this.txtAmountCashValue10);
            this.myGroupBox1.Controls.Add(this.myLabel4);
            this.myGroupBox1.Controls.Add(this.txtAmountCashValue20);
            this.myGroupBox1.Controls.Add(this.myLabel3);
            this.myGroupBox1.Controls.Add(this.txtAmountCashValue50);
            this.myGroupBox1.Controls.Add(this.myLabel2);
            this.myGroupBox1.Location = new System.Drawing.Point(13, 103);
            this.myGroupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.myGroupBox1.Name = "myGroupBox1";
            this.myGroupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.myGroupBox1.Size = new System.Drawing.Size(296, 202);
            this.myGroupBox1.TabIndex = 2;
            this.myGroupBox1.TabStop = false;
            this.myGroupBox1.Text = "Cédulas";
            // 
            // txtAmountCashValue2
            // 
            this.txtAmountCashValue2.Enabled = false;
            this.txtAmountCashValue2.Location = new System.Drawing.Point(140, 160);
            this.txtAmountCashValue2.Margin = new System.Windows.Forms.Padding(4);
            this.txtAmountCashValue2.Name = "txtAmountCashValue2";
            this.txtAmountCashValue2.Size = new System.Drawing.Size(132, 22);
            this.txtAmountCashValue2.TabIndex = 6;
            // 
            // myLabel6
            // 
            this.myLabel6.AutoSize = true;
            this.myLabel6.Location = new System.Drawing.Point(25, 169);
            this.myLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.myLabel6.Name = "myLabel6";
            this.myLabel6.Size = new System.Drawing.Size(58, 17);
            this.myLabel6.TabIndex = 20;
            this.myLabel6.Text = "R$ 2,00";
            // 
            // txtAmountCashValue5
            // 
            this.txtAmountCashValue5.Enabled = false;
            this.txtAmountCashValue5.Location = new System.Drawing.Point(140, 128);
            this.txtAmountCashValue5.Margin = new System.Windows.Forms.Padding(4);
            this.txtAmountCashValue5.Name = "txtAmountCashValue5";
            this.txtAmountCashValue5.Size = new System.Drawing.Size(132, 22);
            this.txtAmountCashValue5.TabIndex = 5;
            this.txtAmountCashValue5.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtAmountCashValue5_KeyUp);
            // 
            // myLabel5
            // 
            this.myLabel5.AutoSize = true;
            this.myLabel5.Location = new System.Drawing.Point(25, 137);
            this.myLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.myLabel5.Name = "myLabel5";
            this.myLabel5.Size = new System.Drawing.Size(58, 17);
            this.myLabel5.TabIndex = 18;
            this.myLabel5.Text = "R$ 5,00";
            // 
            // txtAmountCashValue10
            // 
            this.txtAmountCashValue10.Enabled = false;
            this.txtAmountCashValue10.Location = new System.Drawing.Point(140, 96);
            this.txtAmountCashValue10.Margin = new System.Windows.Forms.Padding(4);
            this.txtAmountCashValue10.Name = "txtAmountCashValue10";
            this.txtAmountCashValue10.Size = new System.Drawing.Size(132, 22);
            this.txtAmountCashValue10.TabIndex = 4;
            this.txtAmountCashValue10.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtAmountCashValue10_KeyUp);
            // 
            // myLabel4
            // 
            this.myLabel4.AutoSize = true;
            this.myLabel4.Location = new System.Drawing.Point(25, 105);
            this.myLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.myLabel4.Name = "myLabel4";
            this.myLabel4.Size = new System.Drawing.Size(66, 17);
            this.myLabel4.TabIndex = 16;
            this.myLabel4.Text = "R$ 10,00";
            // 
            // txtAmountCashValue20
            // 
            this.txtAmountCashValue20.Enabled = false;
            this.txtAmountCashValue20.Location = new System.Drawing.Point(140, 64);
            this.txtAmountCashValue20.Margin = new System.Windows.Forms.Padding(4);
            this.txtAmountCashValue20.Name = "txtAmountCashValue20";
            this.txtAmountCashValue20.Size = new System.Drawing.Size(132, 22);
            this.txtAmountCashValue20.TabIndex = 3;
            this.txtAmountCashValue20.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtAmountCashValue20_KeyUp);
            // 
            // myLabel3
            // 
            this.myLabel3.AutoSize = true;
            this.myLabel3.Location = new System.Drawing.Point(25, 73);
            this.myLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.myLabel3.Name = "myLabel3";
            this.myLabel3.Size = new System.Drawing.Size(66, 17);
            this.myLabel3.TabIndex = 14;
            this.myLabel3.Text = "R$ 20,00";
            // 
            // txtAmountCashValue50
            // 
            this.txtAmountCashValue50.Enabled = false;
            this.txtAmountCashValue50.Location = new System.Drawing.Point(140, 32);
            this.txtAmountCashValue50.Margin = new System.Windows.Forms.Padding(4);
            this.txtAmountCashValue50.Name = "txtAmountCashValue50";
            this.txtAmountCashValue50.Size = new System.Drawing.Size(132, 22);
            this.txtAmountCashValue50.TabIndex = 2;
            this.txtAmountCashValue50.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtAmountCashValue50_KeyUp);
            // 
            // myLabel2
            // 
            this.myLabel2.AutoSize = true;
            this.myLabel2.Location = new System.Drawing.Point(25, 41);
            this.myLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.myLabel2.Name = "myLabel2";
            this.myLabel2.Size = new System.Drawing.Size(66, 17);
            this.myLabel2.TabIndex = 12;
            this.myLabel2.Text = "R$ 50,00";
            // 
            // txtValueDrawee
            // 
            this.txtValueDrawee.Location = new System.Drawing.Point(153, 11);
            this.txtValueDrawee.Margin = new System.Windows.Forms.Padding(4);
            this.txtValueDrawee.Name = "txtValueDrawee";
            this.txtValueDrawee.Size = new System.Drawing.Size(132, 22);
            this.txtValueDrawee.TabIndex = 0;
            this.txtValueDrawee.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtValueDrawee_KeyUp);
            // 
            // myLabel1
            // 
            this.myLabel1.AutoSize = true;
            this.myLabel1.Location = new System.Drawing.Point(39, 15);
            this.myLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.myLabel1.Name = "myLabel1";
            this.myLabel1.Size = new System.Drawing.Size(106, 17);
            this.myLabel1.TabIndex = 0;
            this.myLabel1.Text = "Valor do Saque";
            // 
            // FormATM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 319);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.myGroupBox1);
            this.Controls.Add(this.txtValueDrawee);
            this.Controls.Add(this.myLabel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormATM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caixa Eletrônico";
            this.myGroupBox1.ResumeLayout(false);
            this.myGroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Fiap.CustomControls.MyLabel myLabel1;
        private Fiap.CustomControls.MyTextBox txtValueDrawee;
        private Fiap.CustomControls.MyGroupBox myGroupBox1;
        private Fiap.CustomControls.MyTextBox txtAmountCashValue2;
        private Fiap.CustomControls.MyLabel myLabel6;
        private Fiap.CustomControls.MyTextBox txtAmountCashValue5;
        private Fiap.CustomControls.MyLabel myLabel5;
        private Fiap.CustomControls.MyTextBox txtAmountCashValue10;
        private Fiap.CustomControls.MyLabel myLabel4;
        private Fiap.CustomControls.MyTextBox txtAmountCashValue20;
        private Fiap.CustomControls.MyLabel myLabel3;
        private Fiap.CustomControls.MyTextBox txtAmountCashValue50;
        private Fiap.CustomControls.MyLabel myLabel2;
        private Fiap.CustomControls.MyButton btnCalculate;

    }
}


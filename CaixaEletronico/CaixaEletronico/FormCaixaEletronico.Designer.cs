namespace CaixaEletronico
{
    partial class Form1
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
            this.txtValueDrawee = new Fiap.CustomControls.MyTextBox();
            this.myLabel1 = new Fiap.CustomControls.MyLabel();
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
            this.btnCalculate = new Fiap.CustomControls.MyButton();
            this.myGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtValueDrawee
            // 
            this.txtValueDrawee.Location = new System.Drawing.Point(115, 9);
            this.txtValueDrawee.Name = "txtValueDrawee";
            this.txtValueDrawee.Size = new System.Drawing.Size(100, 20);
            this.txtValueDrawee.TabIndex = 0;
            this.txtValueDrawee.TextChanged += new System.EventHandler(this.txtValueDrawee_TextChanged);
            // 
            // myLabel1
            // 
            this.myLabel1.AutoSize = true;
            this.myLabel1.Location = new System.Drawing.Point(29, 12);
            this.myLabel1.Name = "myLabel1";
            this.myLabel1.Size = new System.Drawing.Size(80, 13);
            this.myLabel1.TabIndex = 0;
            this.myLabel1.Text = "Valor do Saque";
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
            this.myGroupBox1.Location = new System.Drawing.Point(10, 84);
            this.myGroupBox1.Name = "myGroupBox1";
            this.myGroupBox1.Size = new System.Drawing.Size(222, 164);
            this.myGroupBox1.TabIndex = 2;
            this.myGroupBox1.TabStop = false;
            this.myGroupBox1.Text = "Cédulas";
            // 
            // txtAmountCashValue2
            // 
            this.txtAmountCashValue2.Enabled = false;
            this.txtAmountCashValue2.Location = new System.Drawing.Point(105, 130);
            this.txtAmountCashValue2.Name = "txtAmountCashValue2";
            this.txtAmountCashValue2.Size = new System.Drawing.Size(100, 20);
            this.txtAmountCashValue2.TabIndex = 6;
            // 
            // myLabel6
            // 
            this.myLabel6.AutoSize = true;
            this.myLabel6.Location = new System.Drawing.Point(19, 137);
            this.myLabel6.Name = "myLabel6";
            this.myLabel6.Size = new System.Drawing.Size(45, 13);
            this.myLabel6.TabIndex = 20;
            this.myLabel6.Text = "R$ 2,00";
            // 
            // txtAmountCashValue5
            // 
            this.txtAmountCashValue5.Enabled = false;
            this.txtAmountCashValue5.Location = new System.Drawing.Point(105, 104);
            this.txtAmountCashValue5.Name = "txtAmountCashValue5";
            this.txtAmountCashValue5.Size = new System.Drawing.Size(100, 20);
            this.txtAmountCashValue5.TabIndex = 5;
            // 
            // myLabel5
            // 
            this.myLabel5.AutoSize = true;
            this.myLabel5.Location = new System.Drawing.Point(19, 111);
            this.myLabel5.Name = "myLabel5";
            this.myLabel5.Size = new System.Drawing.Size(45, 13);
            this.myLabel5.TabIndex = 18;
            this.myLabel5.Text = "R$ 5,00";
            // 
            // txtAmountCashValue10
            // 
            this.txtAmountCashValue10.Enabled = false;
            this.txtAmountCashValue10.Location = new System.Drawing.Point(105, 78);
            this.txtAmountCashValue10.Name = "txtAmountCashValue10";
            this.txtAmountCashValue10.Size = new System.Drawing.Size(100, 20);
            this.txtAmountCashValue10.TabIndex = 4;
            // 
            // myLabel4
            // 
            this.myLabel4.AutoSize = true;
            this.myLabel4.Location = new System.Drawing.Point(19, 85);
            this.myLabel4.Name = "myLabel4";
            this.myLabel4.Size = new System.Drawing.Size(51, 13);
            this.myLabel4.TabIndex = 16;
            this.myLabel4.Text = "R$ 10,00";
            // 
            // txtAmountCashValue20
            // 
            this.txtAmountCashValue20.Enabled = false;
            this.txtAmountCashValue20.Location = new System.Drawing.Point(105, 52);
            this.txtAmountCashValue20.Name = "txtAmountCashValue20";
            this.txtAmountCashValue20.Size = new System.Drawing.Size(100, 20);
            this.txtAmountCashValue20.TabIndex = 3;
            // 
            // myLabel3
            // 
            this.myLabel3.AutoSize = true;
            this.myLabel3.Location = new System.Drawing.Point(19, 59);
            this.myLabel3.Name = "myLabel3";
            this.myLabel3.Size = new System.Drawing.Size(51, 13);
            this.myLabel3.TabIndex = 14;
            this.myLabel3.Text = "R$ 20,00";
            // 
            // txtAmountCashValue50
            // 
            this.txtAmountCashValue50.Enabled = false;
            this.txtAmountCashValue50.Location = new System.Drawing.Point(105, 26);
            this.txtAmountCashValue50.Name = "txtAmountCashValue50";
            this.txtAmountCashValue50.Size = new System.Drawing.Size(100, 20);
            this.txtAmountCashValue50.TabIndex = 2;
            // 
            // myLabel2
            // 
            this.myLabel2.AutoSize = true;
            this.myLabel2.Location = new System.Drawing.Point(19, 33);
            this.myLabel2.Name = "myLabel2";
            this.myLabel2.Size = new System.Drawing.Size(51, 13);
            this.myLabel2.TabIndex = 12;
            this.myLabel2.Text = "R$ 50,00";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(140, 47);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "calcular";
            this.btnCalculate.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 259);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.myGroupBox1);
            this.Controls.Add(this.txtValueDrawee);
            this.Controls.Add(this.myLabel1);
            this.Name = "Form1";
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


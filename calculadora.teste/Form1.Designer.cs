namespace calculadora.teste
{
    partial class Calculadora
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt1 = new System.Windows.Forms.TextBox();
            this.btnsoma = new System.Windows.Forms.Button();
            this.btnsub = new System.Windows.Forms.Button();
            this.btnmulti = new System.Windows.Forms.Button();
            this.btndivi = new System.Windows.Forms.Button();
            this.txtr = new System.Windows.Forms.TextBox();
            this.btnzero = new System.Windows.Forms.Button();
            this.btnr = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(85, 12);
            this.txt1.MaxLength = 5;
            this.txt1.Name = "txt1";
            this.txt1.ReadOnly = true;
            this.txt1.Size = new System.Drawing.Size(138, 20);
            this.txt1.TabIndex = 2;
            // 
            // btnsoma
            // 
            this.btnsoma.Location = new System.Drawing.Point(69, 54);
            this.btnsoma.Name = "btnsoma";
            this.btnsoma.Size = new System.Drawing.Size(75, 23);
            this.btnsoma.TabIndex = 4;
            this.btnsoma.Text = "+";
            this.btnsoma.UseVisualStyleBackColor = true;
            this.btnsoma.Click += new System.EventHandler(this.btnsoma_Click);
            // 
            // btnsub
            // 
            this.btnsub.Location = new System.Drawing.Point(69, 83);
            this.btnsub.Name = "btnsub";
            this.btnsub.Size = new System.Drawing.Size(75, 23);
            this.btnsub.TabIndex = 5;
            this.btnsub.Text = "-";
            this.btnsub.UseVisualStyleBackColor = true;
            this.btnsub.Click += new System.EventHandler(this.btnsub_Click);
            // 
            // btnmulti
            // 
            this.btnmulti.Location = new System.Drawing.Point(166, 54);
            this.btnmulti.Name = "btnmulti";
            this.btnmulti.Size = new System.Drawing.Size(75, 23);
            this.btnmulti.TabIndex = 6;
            this.btnmulti.Text = "*";
            this.btnmulti.UseVisualStyleBackColor = true;
            this.btnmulti.Click += new System.EventHandler(this.btnmulti_Click);
            // 
            // btndivi
            // 
            this.btndivi.Location = new System.Drawing.Point(166, 83);
            this.btndivi.Name = "btndivi";
            this.btndivi.Size = new System.Drawing.Size(75, 23);
            this.btndivi.TabIndex = 7;
            this.btndivi.Text = "/";
            this.btndivi.UseVisualStyleBackColor = true;
            this.btndivi.Click += new System.EventHandler(this.btndivi_Click);
            // 
            // txtr
            // 
            this.txtr.Location = new System.Drawing.Point(120, 317);
            this.txtr.Name = "txtr";
            this.txtr.ReadOnly = true;
            this.txtr.Size = new System.Drawing.Size(170, 20);
            this.txtr.TabIndex = 9;
            // 
            // btnzero
            // 
            this.btnzero.Location = new System.Drawing.Point(120, 112);
            this.btnzero.Name = "btnzero";
            this.btnzero.Size = new System.Drawing.Size(75, 23);
            this.btnzero.TabIndex = 11;
            this.btnzero.Text = "Zerar";
            this.btnzero.UseVisualStyleBackColor = true;
            this.btnzero.Click += new System.EventHandler(this.btnzero_Click);
            // 
            // btnr
            // 
            this.btnr.Location = new System.Drawing.Point(12, 317);
            this.btnr.Name = "btnr";
            this.btnr.Size = new System.Drawing.Size(67, 20);
            this.btnr.TabIndex = 12;
            this.btnr.Text = "Resultado";
            this.btnr.UseVisualStyleBackColor = true;
            this.btnr.Click += new System.EventHandler(this.btnr_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(30, 160);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 23);
            this.btn1.TabIndex = 13;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(120, 160);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 23);
            this.btn2.TabIndex = 14;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(210, 160);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 23);
            this.btn3.TabIndex = 15;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(30, 189);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(75, 23);
            this.btn4.TabIndex = 16;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(120, 189);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(75, 23);
            this.btn5.TabIndex = 17;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(210, 189);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(75, 23);
            this.btn6.TabIndex = 18;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(30, 220);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(75, 23);
            this.btn7.TabIndex = 19;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(120, 220);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(75, 23);
            this.btn8.TabIndex = 20;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(210, 220);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(75, 23);
            this.btn9.TabIndex = 21;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(120, 249);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(75, 23);
            this.btn0.TabIndex = 22;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 349);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnr);
            this.Controls.Add(this.btnzero);
            this.Controls.Add(this.txtr);
            this.Controls.Add(this.btndivi);
            this.Controls.Add(this.btnmulti);
            this.Controls.Add(this.btnsub);
            this.Controls.Add(this.btnsoma);
            this.Controls.Add(this.txt1);
            this.Name = "Calculadora";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.O);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Button btnsoma;
        private System.Windows.Forms.Button btnsub;
        private System.Windows.Forms.Button btnmulti;
        private System.Windows.Forms.Button btndivi;
        private System.Windows.Forms.TextBox txtr;
        private System.Windows.Forms.Button btnzero;
        private System.Windows.Forms.Button btnr;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn0;
    }
}


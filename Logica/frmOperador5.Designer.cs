namespace Logica
{
    partial class frmOperador5
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtClassificacao = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAtual = new System.Windows.Forms.TextBox();
            this.txtAnterior = new System.Windows.Forms.TextBox();
            this.lblAumentoAnterior = new System.Windows.Forms.Label();
            this.lblAumentoAtual = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(14, 380);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Nivel de Classificacao:";
            // 
            // txtClassificacao
            // 
            this.txtClassificacao.Enabled = false;
            this.txtClassificacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClassificacao.Location = new System.Drawing.Point(19, 408);
            this.txtClassificacao.Name = "txtClassificacao";
            this.txtClassificacao.Size = new System.Drawing.Size(253, 30);
            this.txtClassificacao.TabIndex = 14;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(28, 217);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(115, 45);
            this.btnCalcular.TabIndex = 13;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(23, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Salario do mes atual";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(23, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Salario do mes anterior";
            // 
            // txtAtual
            // 
            this.txtAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAtual.Location = new System.Drawing.Point(28, 110);
            this.txtAtual.Name = "txtAtual";
            this.txtAtual.Size = new System.Drawing.Size(184, 30);
            this.txtAtual.TabIndex = 10;
            // 
            // txtAnterior
            // 
            this.txtAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnterior.Location = new System.Drawing.Point(28, 38);
            this.txtAnterior.Name = "txtAnterior";
            this.txtAnterior.Size = new System.Drawing.Size(195, 30);
            this.txtAnterior.TabIndex = 9;
            // 
            // lblAumentoAnterior
            // 
            this.lblAumentoAnterior.AutoSize = true;
            this.lblAumentoAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAumentoAnterior.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAumentoAnterior.Location = new System.Drawing.Point(229, 38);
            this.lblAumentoAnterior.Name = "lblAumentoAnterior";
            this.lblAumentoAnterior.Size = new System.Drawing.Size(164, 25);
            this.lblAumentoAnterior.TabIndex = 16;
            this.lblAumentoAnterior.Text = "Total de aumento";
            // 
            // lblAumentoAtual
            // 
            this.lblAumentoAtual.AutoSize = true;
            this.lblAumentoAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAumentoAtual.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAumentoAtual.Location = new System.Drawing.Point(229, 110);
            this.lblAumentoAtual.Name = "lblAumentoAtual";
            this.lblAumentoAtual.Size = new System.Drawing.Size(164, 25);
            this.lblAumentoAtual.TabIndex = 17;
            this.lblAumentoAtual.Text = "Total de aumento";
            // 
            // frmOperador5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAumentoAtual);
            this.Controls.Add(this.lblAumentoAnterior);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtClassificacao);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAtual);
            this.Controls.Add(this.txtAnterior);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOperador5";
            this.Text = "frmOperador5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtClassificacao;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAtual;
        private System.Windows.Forms.TextBox txtAnterior;
        private System.Windows.Forms.Label lblAumentoAnterior;
        private System.Windows.Forms.Label lblAumentoAtual;
    }
}
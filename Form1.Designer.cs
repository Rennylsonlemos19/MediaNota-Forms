namespace aula03_escopo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblresultado = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCalcularMedia = new System.Windows.Forms.Button();
            this.textnota3 = new System.Windows.Forms.TextBox();
            this.textnota2 = new System.Windows.Forms.TextBox();
            this.texnota1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnValidarSituacao = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bntNovoCalculo = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblsituacao = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblresultado);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnCalcularMedia);
            this.groupBox1.Controls.Add(this.textnota3);
            this.groupBox1.Controls.Add(this.textnota2);
            this.groupBox1.Controls.Add(this.texnota1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(97, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(575, 424);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Notas";
            // 
            // lblresultado
            // 
            this.lblresultado.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresultado.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblresultado.Location = new System.Drawing.Point(241, 358);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(162, 34);
            this.lblresultado.TabIndex = 8;
            this.lblresultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(68, 369);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Media";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCalcularMedia
            // 
            this.btnCalcularMedia.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnCalcularMedia.Location = new System.Drawing.Point(157, 265);
            this.btnCalcularMedia.Name = "btnCalcularMedia";
            this.btnCalcularMedia.Size = new System.Drawing.Size(139, 66);
            this.btnCalcularMedia.TabIndex = 6;
            this.btnCalcularMedia.Text = "Calcular";
            this.btnCalcularMedia.UseVisualStyleBackColor = false;
            this.btnCalcularMedia.Click += new System.EventHandler(this.button1_Click);
            // 
            // textnota3
            // 
            this.textnota3.BackColor = System.Drawing.Color.Azure;
            this.textnota3.Location = new System.Drawing.Point(138, 192);
            this.textnota3.Multiline = true;
            this.textnota3.Name = "textnota3";
            this.textnota3.Size = new System.Drawing.Size(317, 36);
            this.textnota3.TabIndex = 5;
            // 
            // textnota2
            // 
            this.textnota2.BackColor = System.Drawing.Color.Azure;
            this.textnota2.Location = new System.Drawing.Point(138, 137);
            this.textnota2.Multiline = true;
            this.textnota2.Name = "textnota2";
            this.textnota2.Size = new System.Drawing.Size(317, 32);
            this.textnota2.TabIndex = 4;
            // 
            // texnota1
            // 
            this.texnota1.BackColor = System.Drawing.Color.Azure;
            this.texnota1.Location = new System.Drawing.Point(138, 79);
            this.texnota1.Multiline = true;
            this.texnota1.Name = "texnota1";
            this.texnota1.Size = new System.Drawing.Size(317, 35);
            this.texnota1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nota 3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nota 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nota 1";
            // 
            // btnValidarSituacao
            // 
            this.btnValidarSituacao.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnValidarSituacao.Location = new System.Drawing.Point(254, 486);
            this.btnValidarSituacao.Name = "btnValidarSituacao";
            this.btnValidarSituacao.Size = new System.Drawing.Size(139, 66);
            this.btnValidarSituacao.TabIndex = 9;
            this.btnValidarSituacao.Text = "Validar Situação";
            this.btnValidarSituacao.UseVisualStyleBackColor = false;
            this.btnValidarSituacao.Click += new System.EventHandler(this.btnValidarSituacao_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(93, 598);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 37);
            this.label6.TabIndex = 9;
            this.label6.Text = "Situação";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(338, 656);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 34);
            this.label7.TabIndex = 9;
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bntNovoCalculo
            // 
            this.bntNovoCalculo.BackColor = System.Drawing.Color.Ivory;
            this.bntNovoCalculo.Location = new System.Drawing.Point(69, 656);
            this.bntNovoCalculo.Name = "bntNovoCalculo";
            this.bntNovoCalculo.Size = new System.Drawing.Size(139, 66);
            this.bntNovoCalculo.TabIndex = 10;
            this.bntNovoCalculo.Text = "Novo Cálculo";
            this.bntNovoCalculo.UseVisualStyleBackColor = false;
            this.bntNovoCalculo.Click += new System.EventHandler(this.bntNovoCalculo_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Snow;
            this.button2.Location = new System.Drawing.Point(341, 656);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 66);
            this.button2.TabIndex = 11;
            this.button2.Text = "Fechar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblsituacao
            // 
            this.lblsituacao.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsituacao.ForeColor = System.Drawing.Color.Blue;
            this.lblsituacao.Location = new System.Drawing.Point(301, 587);
            this.lblsituacao.Name = "lblsituacao";
            this.lblsituacao.Size = new System.Drawing.Size(371, 34);
            this.lblsituacao.TabIndex = 9;
            this.lblsituacao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 778);
            this.Controls.Add(this.lblsituacao);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bntNovoCalculo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnValidarSituacao);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCalcularMedia;
        private System.Windows.Forms.TextBox textnota3;
        private System.Windows.Forms.TextBox textnota2;
        private System.Windows.Forms.TextBox texnota1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnValidarSituacao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bntNovoCalculo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblsituacao;
    }
}


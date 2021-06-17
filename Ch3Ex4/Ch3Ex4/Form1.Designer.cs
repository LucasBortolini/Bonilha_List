
namespace Ch3Ex4
{
    partial class Pascal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtbResultados = new System.Windows.Forms.RichTextBox();
            this.nudNumero = new System.Windows.Forms.NumericUpDown();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumero)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbResultados
            // 
            this.rtbResultados.Location = new System.Drawing.Point(19, 116);
            this.rtbResultados.Name = "rtbResultados";
            this.rtbResultados.Size = new System.Drawing.Size(565, 243);
            this.rtbResultados.TabIndex = 0;
            this.rtbResultados.Text = "";
            // 
            // nudNumero
            // 
            this.nudNumero.Location = new System.Drawing.Point(190, 38);
            this.nudNumero.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            0});
            this.nudNumero.Name = "nudNumero";
            this.nudNumero.Size = new System.Drawing.Size(238, 23);
            this.nudNumero.TabIndex = 1;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCalcular.Location = new System.Drawing.Point(190, 67);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(238, 35);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Gerar";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl1.Location = new System.Drawing.Point(190, 9);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(238, 18);
            this.lbl1.TabIndex = 3;
            this.lbl1.Text = "Coloque a quantidade de linhas";
            this.lbl1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Pascal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(603, 371);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.nudNumero);
            this.Controls.Add(this.rtbResultados);
            this.Name = "Pascal";
            this.Text = "Triangulo de Pascal";
            ((System.ComponentModel.ISupportInitialize)(this.nudNumero)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbResultados;
        private System.Windows.Forms.NumericUpDown nudNumero;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lbl1;
    }
}


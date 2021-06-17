namespace Ch3Ex2
{
    partial class Date
    {
        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Lbl1 = new System.Windows.Forms.Label();
            this.Lbl2 = new System.Windows.Forms.Label();
            this.nudh1 = new System.Windows.Forms.NumericUpDown();
            this.nudh2 = new System.Windows.Forms.NumericUpDown();
            this.Lbl3 = new System.Windows.Forms.Label();
            this.nudhmx = new System.Windows.Forms.NumericUpDown();
            this.rtbResults = new System.Windows.Forms.RichTextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudh1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudh2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudhmx)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl1
            // 
            this.Lbl1.AutoSize = true;
            this.Lbl1.BackColor = System.Drawing.Color.Transparent;
            this.Lbl1.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl1.ForeColor = System.Drawing.Color.Black;
            this.Lbl1.Location = new System.Drawing.Point(12, 9);
            this.Lbl1.Name = "Lbl1";
            this.Lbl1.Size = new System.Drawing.Size(161, 27);
            this.Lbl1.TabIndex = 1;
            this.Lbl1.Text = "Primeira Hora:";
            // 
            // Lbl2
            // 
            this.Lbl2.AutoSize = true;
            this.Lbl2.BackColor = System.Drawing.Color.Transparent;
            this.Lbl2.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl2.ForeColor = System.Drawing.Color.Black;
            this.Lbl2.Location = new System.Drawing.Point(10, 56);
            this.Lbl2.Name = "Lbl2";
            this.Lbl2.Size = new System.Drawing.Size(163, 27);
            this.Lbl2.TabIndex = 3;
            this.Lbl2.Text = "Segunda hora:";
            // 
            // nudh1
            // 
            this.nudh1.Location = new System.Drawing.Point(190, 12);
            this.nudh1.Name = "nudh1";
            this.nudh1.Size = new System.Drawing.Size(120, 23);
            this.nudh1.TabIndex = 4;
            // 
            // nudh2
            // 
            this.nudh2.Location = new System.Drawing.Point(190, 60);
            this.nudh2.Name = "nudh2";
            this.nudh2.Size = new System.Drawing.Size(120, 23);
            this.nudh2.TabIndex = 5;
            // 
            // Lbl3
            // 
            this.Lbl3.AutoSize = true;
            this.Lbl3.BackColor = System.Drawing.Color.Transparent;
            this.Lbl3.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl3.ForeColor = System.Drawing.Color.Black;
            this.Lbl3.Location = new System.Drawing.Point(24, 114);
            this.Lbl3.Name = "Lbl3";
            this.Lbl3.Size = new System.Drawing.Size(282, 27);
            this.Lbl3.TabIndex = 6;
            this.Lbl3.Text = "Tempo máximo de espera";
            // 
            // nudhmx
            // 
            this.nudhmx.Location = new System.Drawing.Point(95, 154);
            this.nudhmx.Name = "nudhmx";
            this.nudhmx.Size = new System.Drawing.Size(120, 23);
            this.nudhmx.TabIndex = 7;
            // 
            // rtbResults
            // 
            this.rtbResults.Location = new System.Drawing.Point(24, 221);
            this.rtbResults.Name = "rtbResults";
            this.rtbResults.Size = new System.Drawing.Size(270, 246);
            this.rtbResults.TabIndex = 8;
            this.rtbResults.Text = "";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(69, 192);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(175, 23);
            this.btnCalcular.TabIndex = 9;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnProb_Click);
            // 
            // Date
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 479);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.rtbResults);
            this.Controls.Add(this.nudhmx);
            this.Controls.Add(this.Lbl3);
            this.Controls.Add(this.nudh2);
            this.Controls.Add(this.nudh1);
            this.Controls.Add(this.Lbl2);
            this.Controls.Add(this.Lbl1);
            this.Name = "Date";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Date";
            ((System.ComponentModel.ISupportInitialize)(this.nudh1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudh2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudhmx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Lbl1;
        private System.Windows.Forms.Label Lbl2;
        private System.Windows.Forms.NumericUpDown nudh1;
        private System.Windows.Forms.NumericUpDown nudh2;
        private System.Windows.Forms.Label Lbl3;
        private System.Windows.Forms.NumericUpDown nudhmx;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox rtbResults;
        private System.Windows.Forms.Button btnCalcular;
    }
}


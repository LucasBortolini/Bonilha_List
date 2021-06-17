
namespace Ch3Ex5
{
    partial class Form1
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
            this.nud1 = new System.Windows.Forms.NumericUpDown();
            this.rtbResultados = new System.Windows.Forms.RichTextBox();
            this.btn1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud1)).BeginInit();
            this.SuspendLayout();
            // 
            // nud1
            // 
            this.nud1.Location = new System.Drawing.Point(17, 14);
            this.nud1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nud1.Maximum = new decimal(new int[] {
            1661992959,
            1808227885,
            5,
            0});
            this.nud1.Name = "nud1";
            this.nud1.Size = new System.Drawing.Size(309, 25);
            this.nud1.TabIndex = 0;
            this.nud1.ValueChanged += new System.EventHandler(this.nud1_ValueChanged);
            // 
            // rtbResultados
            // 
            this.rtbResultados.Location = new System.Drawing.Point(17, 130);
            this.rtbResultados.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtbResultados.Name = "rtbResultados";
            this.rtbResultados.Size = new System.Drawing.Size(307, 132);
            this.rtbResultados.TabIndex = 1;
            this.rtbResultados.Text = "";
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(17, 79);
            this.btn1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(309, 28);
            this.btn1.TabIndex = 2;
            this.btn1.Text = "Calcular";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(341, 277);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.rtbResultados);
            this.Controls.Add(this.nud1);
            this.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Decomposicao";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nud1;
        private System.Windows.Forms.RichTextBox rtbResultados;
        private System.Windows.Forms.Button btn1;
    }
}


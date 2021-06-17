
namespace Ch3Ex3
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
            this.rtbResultado = new System.Windows.Forms.RichTextBox();
            this.btnFermat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud1)).BeginInit();
            this.SuspendLayout();
            // 
            // nud1
            // 
            this.nud1.Location = new System.Drawing.Point(15, 14);
            this.nud1.Margin = new System.Windows.Forms.Padding(4);
            this.nud1.Maximum = new decimal(new int[] {
            1661992959,
            1808227885,
            5,
            0});
            this.nud1.Name = "nud1";
            this.nud1.Size = new System.Drawing.Size(154, 25);
            this.nud1.TabIndex = 0;
            // 
            // rtbResultado
            // 
            this.rtbResultado.Location = new System.Drawing.Point(15, 50);
            this.rtbResultado.Margin = new System.Windows.Forms.Padding(4);
            this.rtbResultado.Name = "rtbResultado";
            this.rtbResultado.Size = new System.Drawing.Size(328, 142);
            this.rtbResultado.TabIndex = 2;
            this.rtbResultado.Text = "";
            // 
            // btnFermat
            // 
            this.btnFermat.Location = new System.Drawing.Point(190, 14);
            this.btnFermat.Margin = new System.Windows.Forms.Padding(4);
            this.btnFermat.Name = "btnFermat";
            this.btnFermat.Size = new System.Drawing.Size(154, 28);
            this.btnFermat.TabIndex = 3;
            this.btnFermat.Text = "Calcular";
            this.btnFermat.UseVisualStyleBackColor = true;
            this.btnFermat.Click += new System.EventHandler(this.btnFermat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(358, 200);
            this.Controls.Add(this.btnFermat);
            this.Controls.Add(this.rtbResultado);
            this.Controls.Add(this.nud1);
            this.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(374, 239);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fermat";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nud1;
        private System.Windows.Forms.RichTextBox rtbResultado;
        private System.Windows.Forms.Button btnFermat;
    }
}



namespace Ch3Ex1
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
            this.nudM = new System.Windows.Forms.NumericUpDown();
            this.nudN = new System.Windows.Forms.NumericUpDown();
            this.rtbResultados = new System.Windows.Forms.RichTextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudN)).BeginInit();
            this.SuspendLayout();
            // 
            // nudM
            // 
            this.nudM.Location = new System.Drawing.Point(17, 14);
            this.nudM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudM.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.nudM.Name = "nudM";
            this.nudM.Size = new System.Drawing.Size(267, 25);
            this.nudM.TabIndex = 0;
            // 
            // nudN
            // 
            this.nudN.Location = new System.Drawing.Point(15, 49);
            this.nudN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudN.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            0});
            this.nudN.Name = "nudN";
            this.nudN.Size = new System.Drawing.Size(267, 25);
            this.nudN.TabIndex = 1;
            // 
            // rtbResultados
            // 
            this.rtbResultados.Location = new System.Drawing.Point(15, 164);
            this.rtbResultados.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtbResultados.Name = "rtbResultados";
            this.rtbResultados.Size = new System.Drawing.Size(268, 142);
            this.rtbResultados.TabIndex = 2;
            this.rtbResultados.Text = "";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(15, 113);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(269, 28);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(300, 324);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.rtbResultados);
            this.Controls.Add(this.nudN);
            this.Controls.Add(this.nudM);
            this.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Fatorial";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudM;
        private System.Windows.Forms.NumericUpDown nudN;
        private System.Windows.Forms.RichTextBox rtbResultados;
        private System.Windows.Forms.Button btnCalcular;
    }
}


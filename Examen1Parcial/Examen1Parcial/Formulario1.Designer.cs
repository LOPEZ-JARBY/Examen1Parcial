
namespace Examen1Parcial
{
    partial class Formulario1
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
            this.ValoreslistBox = new System.Windows.Forms.ListBox();
            this.Calculobutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ValoreslistBox
            // 
            this.ValoreslistBox.FormattingEnabled = true;
            this.ValoreslistBox.Location = new System.Drawing.Point(30, 78);
            this.ValoreslistBox.Name = "ValoreslistBox";
            this.ValoreslistBox.Size = new System.Drawing.Size(278, 186);
            this.ValoreslistBox.TabIndex = 0;
            // 
            // Calculobutton
            // 
            this.Calculobutton.Location = new System.Drawing.Point(314, 78);
            this.Calculobutton.Name = "Calculobutton";
            this.Calculobutton.Size = new System.Drawing.Size(75, 23);
            this.Calculobutton.TabIndex = 1;
            this.Calculobutton.Text = "CALCULO";
            this.Calculobutton.UseVisualStyleBackColor = true;
            this.Calculobutton.Click += new System.EventHandler(this.Calculobutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Valores del usuario :";
            // 
            // Formulario1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 370);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Calculobutton);
            this.Controls.Add(this.ValoreslistBox);
            this.Name = "Formulario1";
            this.Text = "Formulario1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ValoreslistBox;
        private System.Windows.Forms.Button Calculobutton;
        private System.Windows.Forms.Label label1;
    }
}
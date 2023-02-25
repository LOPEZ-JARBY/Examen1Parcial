
namespace Examen1Parcial
{
    partial class Formulario3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NumeroGtextBox = new System.Windows.Forms.TextBox();
            this.ResultadotextBox = new System.Windows.Forms.TextBox();
            this.Generarbutton = new System.Windows.Forms.Button();
            this.Numerolabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(94, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Resultado :";
            // 
            // NumeroGtextBox
            // 
            this.NumeroGtextBox.Location = new System.Drawing.Point(196, 57);
            this.NumeroGtextBox.Name = "NumeroGtextBox";
            this.NumeroGtextBox.Size = new System.Drawing.Size(148, 20);
            this.NumeroGtextBox.TabIndex = 2;
            // 
            // ResultadotextBox
            // 
            this.ResultadotextBox.Location = new System.Drawing.Point(196, 103);
            this.ResultadotextBox.Name = "ResultadotextBox";
            this.ResultadotextBox.Size = new System.Drawing.Size(148, 20);
            this.ResultadotextBox.TabIndex = 3;
            // 
            // Generarbutton
            // 
            this.Generarbutton.Location = new System.Drawing.Point(97, 50);
            this.Generarbutton.Name = "Generarbutton";
            this.Generarbutton.Size = new System.Drawing.Size(88, 32);
            this.Generarbutton.TabIndex = 4;
            this.Generarbutton.Text = "Generar";
            this.Generarbutton.UseVisualStyleBackColor = true;
            this.Generarbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Numerolabel
            // 
            this.Numerolabel.AutoSize = true;
            this.Numerolabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Numerolabel.Location = new System.Drawing.Point(108, 87);
            this.Numerolabel.Name = "Numerolabel";
            this.Numerolabel.Size = new System.Drawing.Size(0, 16);
            this.Numerolabel.TabIndex = 5;
            // 
            // Formulario3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 238);
            this.Controls.Add(this.Numerolabel);
            this.Controls.Add(this.Generarbutton);
            this.Controls.Add(this.ResultadotextBox);
            this.Controls.Add(this.NumeroGtextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Formulario3";
            this.Text = "Formulario3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NumeroGtextBox;
        private System.Windows.Forms.TextBox ResultadotextBox;
        private System.Windows.Forms.Button Generarbutton;
        private System.Windows.Forms.Label Numerolabel;
    }
}
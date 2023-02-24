
namespace Examen1Parcial
{
    partial class Formulario2
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
            this.Producto1label = new System.Windows.Forms.Label();
            this.Producto2label = new System.Windows.Forms.Label();
            this.Producto1textBox = new System.Windows.Forms.TextBox();
            this.Producto2textBox = new System.Windows.Forms.TextBox();
            this.PrecioP1label = new System.Windows.Forms.Label();
            this.PrecioP2label = new System.Windows.Forms.Label();
            this.PrecioP1textBox = new System.Windows.Forms.TextBox();
            this.PrecioP2textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CantidadtextBox = new System.Windows.Forms.TextBox();
            this.FacturalistBox = new System.Windows.Forms.ListBox();
            this.Calcularbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Producto1label
            // 
            this.Producto1label.AutoSize = true;
            this.Producto1label.Location = new System.Drawing.Point(12, 25);
            this.Producto1label.Name = "Producto1label";
            this.Producto1label.Size = new System.Drawing.Size(62, 13);
            this.Producto1label.TabIndex = 0;
            this.Producto1label.Text = "Producto1 :";
            // 
            // Producto2label
            // 
            this.Producto2label.AutoSize = true;
            this.Producto2label.Location = new System.Drawing.Point(12, 62);
            this.Producto2label.Name = "Producto2label";
            this.Producto2label.Size = new System.Drawing.Size(62, 13);
            this.Producto2label.TabIndex = 1;
            this.Producto2label.Text = "Producto2 :";
            // 
            // Producto1textBox
            // 
            this.Producto1textBox.Location = new System.Drawing.Point(83, 25);
            this.Producto1textBox.Name = "Producto1textBox";
            this.Producto1textBox.Size = new System.Drawing.Size(118, 20);
            this.Producto1textBox.TabIndex = 2;
            // 
            // Producto2textBox
            // 
            this.Producto2textBox.Location = new System.Drawing.Point(83, 59);
            this.Producto2textBox.Name = "Producto2textBox";
            this.Producto2textBox.Size = new System.Drawing.Size(118, 20);
            this.Producto2textBox.TabIndex = 3;
            // 
            // PrecioP1label
            // 
            this.PrecioP1label.AutoSize = true;
            this.PrecioP1label.Location = new System.Drawing.Point(207, 28);
            this.PrecioP1label.Name = "PrecioP1label";
            this.PrecioP1label.Size = new System.Drawing.Size(56, 13);
            this.PrecioP1label.TabIndex = 4;
            this.PrecioP1label.Text = "PrecioP1 :";
            // 
            // PrecioP2label
            // 
            this.PrecioP2label.AutoSize = true;
            this.PrecioP2label.Location = new System.Drawing.Point(207, 66);
            this.PrecioP2label.Name = "PrecioP2label";
            this.PrecioP2label.Size = new System.Drawing.Size(56, 13);
            this.PrecioP2label.TabIndex = 5;
            this.PrecioP2label.Text = "PrecioP2 :";
            this.PrecioP2label.Click += new System.EventHandler(this.PrecioP2label_Click);
            // 
            // PrecioP1textBox
            // 
            this.PrecioP1textBox.Location = new System.Drawing.Point(272, 25);
            this.PrecioP1textBox.Name = "PrecioP1textBox";
            this.PrecioP1textBox.Size = new System.Drawing.Size(100, 20);
            this.PrecioP1textBox.TabIndex = 6;
            // 
            // PrecioP2textBox
            // 
            this.PrecioP2textBox.Location = new System.Drawing.Point(272, 66);
            this.PrecioP2textBox.Name = "PrecioP2textBox";
            this.PrecioP2textBox.Size = new System.Drawing.Size(100, 20);
            this.PrecioP2textBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "CantidadProductos : ";
            // 
            // CantidadtextBox
            // 
            this.CantidadtextBox.Location = new System.Drawing.Point(124, 100);
            this.CantidadtextBox.Name = "CantidadtextBox";
            this.CantidadtextBox.Size = new System.Drawing.Size(56, 20);
            this.CantidadtextBox.TabIndex = 9;
            // 
            // FacturalistBox
            // 
            this.FacturalistBox.FormattingEnabled = true;
            this.FacturalistBox.Location = new System.Drawing.Point(69, 161);
            this.FacturalistBox.Name = "FacturalistBox";
            this.FacturalistBox.Size = new System.Drawing.Size(226, 108);
            this.FacturalistBox.TabIndex = 10;
            // 
            // Calcularbutton
            // 
            this.Calcularbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calcularbutton.Location = new System.Drawing.Point(210, 100);
            this.Calcularbutton.Name = "Calcularbutton";
            this.Calcularbutton.Size = new System.Drawing.Size(85, 23);
            this.Calcularbutton.TabIndex = 11;
            this.Calcularbutton.Text = "CALCULAR";
            this.Calcularbutton.UseVisualStyleBackColor = true;
            this.Calcularbutton.Click += new System.EventHandler(this.Calcularbutton_Click);
            // 
            // Formulario2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 296);
            this.Controls.Add(this.Calcularbutton);
            this.Controls.Add(this.FacturalistBox);
            this.Controls.Add(this.CantidadtextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PrecioP2textBox);
            this.Controls.Add(this.PrecioP1textBox);
            this.Controls.Add(this.PrecioP2label);
            this.Controls.Add(this.PrecioP1label);
            this.Controls.Add(this.Producto2textBox);
            this.Controls.Add(this.Producto1textBox);
            this.Controls.Add(this.Producto2label);
            this.Controls.Add(this.Producto1label);
            this.Name = "Formulario2";
            this.Text = "Formulario2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Producto1label;
        private System.Windows.Forms.Label Producto2label;
        private System.Windows.Forms.TextBox Producto1textBox;
        private System.Windows.Forms.TextBox Producto2textBox;
        private System.Windows.Forms.Label PrecioP1label;
        private System.Windows.Forms.Label PrecioP2label;
        private System.Windows.Forms.TextBox PrecioP1textBox;
        private System.Windows.Forms.TextBox PrecioP2textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CantidadtextBox;
        private System.Windows.Forms.ListBox FacturalistBox;
        private System.Windows.Forms.Button Calcularbutton;
    }
}
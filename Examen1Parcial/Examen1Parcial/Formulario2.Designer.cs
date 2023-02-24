
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
            this.CantidadP1label1 = new System.Windows.Forms.Label();
            this.Cantidad1textBox = new System.Windows.Forms.TextBox();
            this.FacturalistBox = new System.Windows.Forms.ListBox();
            this.Calcularbutton = new System.Windows.Forms.Button();
            this.CantidadP2label = new System.Windows.Forms.Label();
            this.Cantidad2textBox = new System.Windows.Forms.TextBox();
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
            // CantidadP1label1
            // 
            this.CantidadP1label1.AutoSize = true;
            this.CantidadP1label1.Location = new System.Drawing.Point(378, 25);
            this.CantidadP1label1.Name = "CantidadP1label1";
            this.CantidadP1label1.Size = new System.Drawing.Size(71, 13);
            this.CantidadP1label1.TabIndex = 8;
            this.CantidadP1label1.Text = "CantidadP1 : ";
            // 
            // Cantidad1textBox
            // 
            this.Cantidad1textBox.Location = new System.Drawing.Point(455, 22);
            this.Cantidad1textBox.Name = "Cantidad1textBox";
            this.Cantidad1textBox.Size = new System.Drawing.Size(60, 20);
            this.Cantidad1textBox.TabIndex = 9;
            // 
            // FacturalistBox
            // 
            this.FacturalistBox.FormattingEnabled = true;
            this.FacturalistBox.Location = new System.Drawing.Point(83, 177);
            this.FacturalistBox.Name = "FacturalistBox";
            this.FacturalistBox.Size = new System.Drawing.Size(383, 173);
            this.FacturalistBox.TabIndex = 10;
            // 
            // Calcularbutton
            // 
            this.Calcularbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calcularbutton.Location = new System.Drawing.Point(201, 122);
            this.Calcularbutton.Name = "Calcularbutton";
            this.Calcularbutton.Size = new System.Drawing.Size(125, 33);
            this.Calcularbutton.TabIndex = 11;
            this.Calcularbutton.Text = "Calcular";
            this.Calcularbutton.UseVisualStyleBackColor = true;
            this.Calcularbutton.Click += new System.EventHandler(this.Calcularbutton_Click);
            // 
            // CantidadP2label
            // 
            this.CantidadP2label.AutoSize = true;
            this.CantidadP2label.Location = new System.Drawing.Point(378, 69);
            this.CantidadP2label.Name = "CantidadP2label";
            this.CantidadP2label.Size = new System.Drawing.Size(71, 13);
            this.CantidadP2label.TabIndex = 12;
            this.CantidadP2label.Text = "CantidadP2 : ";
            // 
            // Cantidad2textBox
            // 
            this.Cantidad2textBox.Location = new System.Drawing.Point(455, 63);
            this.Cantidad2textBox.Name = "Cantidad2textBox";
            this.Cantidad2textBox.Size = new System.Drawing.Size(60, 20);
            this.Cantidad2textBox.TabIndex = 13;
            // 
            // Formulario2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 380);
            this.Controls.Add(this.Cantidad2textBox);
            this.Controls.Add(this.CantidadP2label);
            this.Controls.Add(this.Calcularbutton);
            this.Controls.Add(this.FacturalistBox);
            this.Controls.Add(this.Cantidad1textBox);
            this.Controls.Add(this.CantidadP1label1);
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
        private System.Windows.Forms.Label CantidadP1label1;
        private System.Windows.Forms.TextBox Cantidad1textBox;
        private System.Windows.Forms.ListBox FacturalistBox;
        private System.Windows.Forms.Button Calcularbutton;
        private System.Windows.Forms.Label CantidadP2label;
        private System.Windows.Forms.TextBox Cantidad2textBox;
    }
}
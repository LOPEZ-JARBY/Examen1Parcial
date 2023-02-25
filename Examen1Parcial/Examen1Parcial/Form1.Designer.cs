
namespace Examen1Parcial
{
    partial class MenuForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Formulario1button = new System.Windows.Forms.Button();
            this.Formulario2button = new System.Windows.Forms.Button();
            this.Formulario3button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Formulario1button
            // 
            this.Formulario1button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Formulario1button.Location = new System.Drawing.Point(27, 56);
            this.Formulario1button.Name = "Formulario1button";
            this.Formulario1button.Size = new System.Drawing.Size(88, 23);
            this.Formulario1button.TabIndex = 0;
            this.Formulario1button.Text = "Formulario1";
            this.Formulario1button.UseVisualStyleBackColor = true;
            this.Formulario1button.Click += new System.EventHandler(this.Formulario1button_Click);
            // 
            // Formulario2button
            // 
            this.Formulario2button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Formulario2button.Location = new System.Drawing.Point(138, 56);
            this.Formulario2button.Name = "Formulario2button";
            this.Formulario2button.Size = new System.Drawing.Size(91, 23);
            this.Formulario2button.TabIndex = 1;
            this.Formulario2button.Text = "Formulario2";
            this.Formulario2button.UseVisualStyleBackColor = true;
            this.Formulario2button.Click += new System.EventHandler(this.Formulario2button_Click);
            // 
            // Formulario3button
            // 
            this.Formulario3button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Formulario3button.Location = new System.Drawing.Point(254, 56);
            this.Formulario3button.Name = "Formulario3button";
            this.Formulario3button.Size = new System.Drawing.Size(88, 23);
            this.Formulario3button.TabIndex = 2;
            this.Formulario3button.Text = "Formulario3";
            this.Formulario3button.UseVisualStyleBackColor = true;
            this.Formulario3button.Click += new System.EventHandler(this.Formulario3button_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 128);
            this.Controls.Add(this.Formulario3button);
            this.Controls.Add(this.Formulario2button);
            this.Controls.Add(this.Formulario1button);
            this.Name = "MenuForm";
            this.Text = "MENU";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Formulario1button;
        private System.Windows.Forms.Button Formulario2button;
        private System.Windows.Forms.Button Formulario3button;
    }
}


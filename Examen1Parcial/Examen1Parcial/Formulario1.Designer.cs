
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
            this.MeseslistBox = new System.Windows.Forms.ListBox();
            this.Calculobutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.IntereslistBox = new System.Windows.Forms.ListBox();
            this.MontolistBox = new System.Windows.Forms.ListBox();
            this.Cerrarbutton = new System.Windows.Forms.Button();
            this.Meslabel = new System.Windows.Forms.Label();
            this.Intereslabel = new System.Windows.Forms.Label();
            this.Montolabel = new System.Windows.Forms.Label();
            this.TinterestextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // MeseslistBox
            // 
            this.MeseslistBox.FormattingEnabled = true;
            this.MeseslistBox.Location = new System.Drawing.Point(30, 78);
            this.MeseslistBox.Name = "MeseslistBox";
            this.MeseslistBox.Size = new System.Drawing.Size(99, 186);
            this.MeseslistBox.TabIndex = 0;
            // 
            // Calculobutton
            // 
            this.Calculobutton.Location = new System.Drawing.Point(190, 20);
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
            // IntereslistBox
            // 
            this.IntereslistBox.FormattingEnabled = true;
            this.IntereslistBox.Location = new System.Drawing.Point(135, 78);
            this.IntereslistBox.Name = "IntereslistBox";
            this.IntereslistBox.Size = new System.Drawing.Size(99, 186);
            this.IntereslistBox.TabIndex = 3;
            // 
            // MontolistBox
            // 
            this.MontolistBox.FormattingEnabled = true;
            this.MontolistBox.Location = new System.Drawing.Point(240, 78);
            this.MontolistBox.Name = "MontolistBox";
            this.MontolistBox.Size = new System.Drawing.Size(99, 186);
            this.MontolistBox.TabIndex = 4;
            // 
            // Cerrarbutton
            // 
            this.Cerrarbutton.Location = new System.Drawing.Point(135, 327);
            this.Cerrarbutton.Name = "Cerrarbutton";
            this.Cerrarbutton.Size = new System.Drawing.Size(75, 23);
            this.Cerrarbutton.TabIndex = 5;
            this.Cerrarbutton.Text = "CERRAR";
            this.Cerrarbutton.UseVisualStyleBackColor = true;
            this.Cerrarbutton.Click += new System.EventHandler(this.Cerrarbutton_Click);
            // 
            // Meslabel
            // 
            this.Meslabel.AutoSize = true;
            this.Meslabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Meslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Meslabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Meslabel.Location = new System.Drawing.Point(59, 59);
            this.Meslabel.Name = "Meslabel";
            this.Meslabel.Size = new System.Drawing.Size(37, 16);
            this.Meslabel.TabIndex = 6;
            this.Meslabel.Text = "MES";
            // 
            // Intereslabel
            // 
            this.Intereslabel.AutoSize = true;
            this.Intereslabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Intereslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Intereslabel.Location = new System.Drawing.Point(153, 59);
            this.Intereslabel.Name = "Intereslabel";
            this.Intereslabel.Size = new System.Drawing.Size(67, 16);
            this.Intereslabel.TabIndex = 7;
            this.Intereslabel.Text = "INTERES";
            // 
            // Montolabel
            // 
            this.Montolabel.AutoSize = true;
            this.Montolabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Montolabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Montolabel.Location = new System.Drawing.Point(255, 59);
            this.Montolabel.Name = "Montolabel";
            this.Montolabel.Size = new System.Drawing.Size(58, 16);
            this.Montolabel.TabIndex = 8;
            this.Montolabel.Text = "MONTO";
            // 
            // TinterestextBox
            // 
            this.TinterestextBox.Location = new System.Drawing.Point(135, 270);
            this.TinterestextBox.Name = "TinterestextBox";
            this.TinterestextBox.Size = new System.Drawing.Size(99, 20);
            this.TinterestextBox.TabIndex = 9;
            this.TinterestextBox.TextChanged += new System.EventHandler(this.TinterestextBox_TextChanged);
            // 
            // Formulario1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 380);
            this.Controls.Add(this.TinterestextBox);
            this.Controls.Add(this.Montolabel);
            this.Controls.Add(this.Intereslabel);
            this.Controls.Add(this.Meslabel);
            this.Controls.Add(this.Cerrarbutton);
            this.Controls.Add(this.MontolistBox);
            this.Controls.Add(this.IntereslistBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Calculobutton);
            this.Controls.Add(this.MeseslistBox);
            this.Name = "Formulario1";
            this.Text = "Formulario1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox MeseslistBox;
        private System.Windows.Forms.Button Calculobutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox IntereslistBox;
        private System.Windows.Forms.ListBox MontolistBox;
        private System.Windows.Forms.Button Cerrarbutton;
        private System.Windows.Forms.Label Meslabel;
        private System.Windows.Forms.Label Intereslabel;
        private System.Windows.Forms.Label Montolabel;
        private System.Windows.Forms.TextBox TinterestextBox;
    }
}
namespace pryCatalaGestion
{
    partial class frmMostrar
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
            this.lblActividad = new System.Windows.Forms.Label();
            this.txtActividad = new System.Windows.Forms.TextBox();
            this.lsbActividad = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblActividad
            // 
            this.lblActividad.AutoSize = true;
            this.lblActividad.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActividad.ForeColor = System.Drawing.Color.Teal;
            this.lblActividad.Location = new System.Drawing.Point(13, 33);
            this.lblActividad.Name = "lblActividad";
            this.lblActividad.Size = new System.Drawing.Size(59, 17);
            this.lblActividad.TabIndex = 0;
            this.lblActividad.Text = "Actividad";
            // 
            // txtActividad
            // 
            this.txtActividad.Location = new System.Drawing.Point(89, 33);
            this.txtActividad.Name = "txtActividad";
            this.txtActividad.Size = new System.Drawing.Size(205, 20);
            this.txtActividad.TabIndex = 1;
            // 
            // lsbActividad
            // 
            this.lsbActividad.FormattingEnabled = true;
            this.lsbActividad.Location = new System.Drawing.Point(16, 87);
            this.lsbActividad.Name = "lsbActividad";
            this.lsbActividad.Size = new System.Drawing.Size(278, 238);
            this.lsbActividad.TabIndex = 2;
            // 
            // frmMostrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 352);
            this.Controls.Add(this.lsbActividad);
            this.Controls.Add(this.txtActividad);
            this.Controls.Add(this.lblActividad);
            this.Name = "frmMostrar";
            this.Text = "Mostrar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblActividad;
        private System.Windows.Forms.TextBox txtActividad;
        private System.Windows.Forms.ListBox lsbActividad;
    }
}
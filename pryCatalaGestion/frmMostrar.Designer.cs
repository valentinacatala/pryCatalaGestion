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
            this.lblActividad.Location = new System.Drawing.Point(17, 41);
            this.lblActividad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActividad.Name = "lblActividad";
            this.lblActividad.Size = new System.Drawing.Size(76, 21);
            this.lblActividad.TabIndex = 0;
            this.lblActividad.Text = "Actividad";
            // 
            // txtActividad
            // 
            this.txtActividad.Location = new System.Drawing.Point(101, 41);
            this.txtActividad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtActividad.Name = "txtActividad";
            this.txtActividad.Size = new System.Drawing.Size(281, 22);
            this.txtActividad.TabIndex = 1;
            // 
            // lsbActividad
            // 
            this.lsbActividad.FormattingEnabled = true;
            this.lsbActividad.ItemHeight = 16;
            this.lsbActividad.Location = new System.Drawing.Point(13, 106);
            this.lsbActividad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lsbActividad.Name = "lsbActividad";
            this.lsbActividad.Size = new System.Drawing.Size(369, 292);
            this.lsbActividad.TabIndex = 2;
            // 
            // frmMostrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 433);
            this.Controls.Add(this.lsbActividad);
            this.Controls.Add(this.txtActividad);
            this.Controls.Add(this.lblActividad);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
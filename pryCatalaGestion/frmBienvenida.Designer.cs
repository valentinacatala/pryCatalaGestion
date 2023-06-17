namespace pryCatalaGestion
{
    partial class frmBienvenida
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
            this.cmdRegistrar = new System.Windows.Forms.Button();
            this.cmdConsultar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdRegistrar
            // 
            this.cmdRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdRegistrar.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRegistrar.ForeColor = System.Drawing.Color.Teal;
            this.cmdRegistrar.Location = new System.Drawing.Point(36, 80);
            this.cmdRegistrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdRegistrar.Name = "cmdRegistrar";
            this.cmdRegistrar.Size = new System.Drawing.Size(184, 90);
            this.cmdRegistrar.TabIndex = 0;
            this.cmdRegistrar.Text = "Registrar Actividad";
            this.cmdRegistrar.UseVisualStyleBackColor = true;
            this.cmdRegistrar.Click += new System.EventHandler(this.cmdRegistrar_Click);
            // 
            // cmdConsultar
            // 
            this.cmdConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdConsultar.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdConsultar.ForeColor = System.Drawing.Color.Teal;
            this.cmdConsultar.Location = new System.Drawing.Point(260, 80);
            this.cmdConsultar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdConsultar.Name = "cmdConsultar";
            this.cmdConsultar.Size = new System.Drawing.Size(184, 90);
            this.cmdConsultar.TabIndex = 1;
            this.cmdConsultar.Text = "Consultar Actividades";
            this.cmdConsultar.UseVisualStyleBackColor = true;
            this.cmdConsultar.Click += new System.EventHandler(this.cmdConsultar_Click);
            // 
            // frmBienvenida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 245);
            this.Controls.Add(this.cmdConsultar);
            this.Controls.Add(this.cmdRegistrar);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBienvenida";
            this.Text = "Bienvenida";
            this.Load += new System.EventHandler(this.frmBienvenida_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdRegistrar;
        private System.Windows.Forms.Button cmdConsultar;
    }
}
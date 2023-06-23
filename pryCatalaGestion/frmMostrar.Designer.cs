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
            this.dgvMostrar = new System.Windows.Forms.DataGridView();
            this.dgvFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvReunion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTareas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMostrar
            // 
            this.dgvMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvFecha,
            this.dgvTipo,
            this.dgvDetalle,
            this.dgvReunion,
            this.dgvTareas});
            this.dgvMostrar.Location = new System.Drawing.Point(12, 54);
            this.dgvMostrar.Name = "dgvMostrar";
            this.dgvMostrar.Size = new System.Drawing.Size(541, 328);
            this.dgvMostrar.TabIndex = 12;
            // 
            // dgvFecha
            // 
            this.dgvFecha.HeaderText = "Fecha";
            this.dgvFecha.Name = "dgvFecha";
            // 
            // dgvTipo
            // 
            this.dgvTipo.HeaderText = "Tipo";
            this.dgvTipo.Name = "dgvTipo";
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.HeaderText = "Detalle";
            this.dgvDetalle.Name = "dgvDetalle";
            // 
            // dgvReunion
            // 
            this.dgvReunion.HeaderText = "Reunion";
            this.dgvReunion.Name = "dgvReunion";
            // 
            // dgvTareas
            // 
            this.dgvTareas.HeaderText = "Tareas";
            this.dgvTareas.Name = "dgvTareas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(178, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "Registro de Actividades";
            // 
            // frmMostrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 394);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvMostrar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMostrar";
            this.Text = "Mostrar";
            this.Load += new System.EventHandler(this.frmMostrar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMostrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvReunion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTareas;
        private System.Windows.Forms.Label label1;
    }
}
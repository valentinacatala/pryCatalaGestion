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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMostrar));
            this.dgvMostrar = new System.Windows.Forms.DataGridView();
            this.dgvFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvReunion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTareas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblRegistroActividades = new System.Windows.Forms.Label();
            this.cmdIrARegistro = new System.Windows.Forms.Button();
            this.cmdCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMostrar
            // 
            this.dgvMostrar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMostrar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvFecha,
            this.dgvTipo,
            this.dgvDetalle,
            this.dgvReunion,
            this.dgvTareas});
            this.dgvMostrar.Location = new System.Drawing.Point(16, 66);
            this.dgvMostrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvMostrar.Name = "dgvMostrar";
            this.dgvMostrar.RowHeadersWidth = 51;
            this.dgvMostrar.Size = new System.Drawing.Size(721, 362);
            this.dgvMostrar.TabIndex = 12;
            // 
            // dgvFecha
            // 
            this.dgvFecha.HeaderText = "Fecha";
            this.dgvFecha.MinimumWidth = 6;
            this.dgvFecha.Name = "dgvFecha";
            // 
            // dgvTipo
            // 
            this.dgvTipo.HeaderText = "Tipo";
            this.dgvTipo.MinimumWidth = 6;
            this.dgvTipo.Name = "dgvTipo";
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.HeaderText = "Detalle";
            this.dgvDetalle.MinimumWidth = 6;
            this.dgvDetalle.Name = "dgvDetalle";
            // 
            // dgvReunion
            // 
            this.dgvReunion.HeaderText = "Reunion";
            this.dgvReunion.MinimumWidth = 6;
            this.dgvReunion.Name = "dgvReunion";
            // 
            // dgvTareas
            // 
            this.dgvTareas.HeaderText = "Tareas";
            this.dgvTareas.MinimumWidth = 6;
            this.dgvTareas.Name = "dgvTareas";
            // 
            // lblRegistroActividades
            // 
            this.lblRegistroActividades.AutoSize = true;
            this.lblRegistroActividades.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistroActividades.ForeColor = System.Drawing.Color.Teal;
            this.lblRegistroActividades.Location = new System.Drawing.Point(237, 18);
            this.lblRegistroActividades.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegistroActividades.Name = "lblRegistroActividades";
            this.lblRegistroActividades.Size = new System.Drawing.Size(240, 29);
            this.lblRegistroActividades.TabIndex = 13;
            this.lblRegistroActividades.Text = "Registro de Actividades";
            // 
            // cmdIrARegistro
            // 
            this.cmdIrARegistro.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdIrARegistro.Location = new System.Drawing.Point(243, 442);
            this.cmdIrARegistro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdIrARegistro.Name = "cmdIrARegistro";
            this.cmdIrARegistro.Size = new System.Drawing.Size(119, 28);
            this.cmdIrARegistro.TabIndex = 14;
            this.cmdIrARegistro.Text = "Ir a registro";
            this.cmdIrARegistro.UseVisualStyleBackColor = true;
            this.cmdIrARegistro.Click += new System.EventHandler(this.cmdIrARegistro_Click);
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancelar.Location = new System.Drawing.Point(376, 442);
            this.cmdCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(119, 28);
            this.cmdCancelar.TabIndex = 15;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.UseVisualStyleBackColor = true;
            this.cmdCancelar.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmMostrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 485);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.cmdIrARegistro);
            this.Controls.Add(this.lblRegistroActividades);
            this.Controls.Add(this.dgvMostrar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Label lblRegistroActividades;
        private System.Windows.Forms.Button cmdIrARegistro;
        private System.Windows.Forms.Button cmdCancelar;
    }
}
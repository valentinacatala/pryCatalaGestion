namespace pryCatalaGestion
{
    partial class frmRegistrar
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
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDetalle = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lstTipoActividad = new System.Windows.Forms.ComboBox();
            this.mrcReunion = new System.Windows.Forms.GroupBox();
            this.optNo = new System.Windows.Forms.RadioButton();
            this.optSi = new System.Windows.Forms.RadioButton();
            this.mrcTareas = new System.Windows.Forms.GroupBox();
            this.chkDebate = new System.Windows.Forms.CheckBox();
            this.chkNotasReunion = new System.Windows.Forms.CheckBox();
            this.chkInvestigacion = new System.Windows.Forms.CheckBox();
            this.chkRepositorio = new System.Windows.Forms.CheckBox();
            this.cmdGrabar = new System.Windows.Forms.Button();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.mrcReunion.SuspendLayout();
            this.mrcTareas.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.Teal;
            this.lblFecha.Location = new System.Drawing.Point(15, 27);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(46, 19);
            this.lblFecha.TabIndex = 0;
            this.lblFecha.Text = "Fecha";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.ForeColor = System.Drawing.Color.Teal;
            this.lblTipo.Location = new System.Drawing.Point(15, 67);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(39, 19);
            this.lblTipo.TabIndex = 1;
            this.lblTipo.Text = "Tipo ";
            this.lblTipo.Click += new System.EventHandler(this.lblTipoActividad_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(15, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Detalle";
            // 
            // txtDetalle
            // 
            this.txtDetalle.Location = new System.Drawing.Point(75, 101);
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Size = new System.Drawing.Size(190, 20);
            this.txtDetalle.TabIndex = 3;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(75, 27);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(190, 20);
            this.dtpFecha.TabIndex = 4;
            // 
            // lstTipoActividad
            // 
            this.lstTipoActividad.FormattingEnabled = true;
            this.lstTipoActividad.Items.AddRange(new object[] {
            "Actividad 1",
            "Actividad 2",
            "Actividad 3"});
            this.lstTipoActividad.Location = new System.Drawing.Point(75, 65);
            this.lstTipoActividad.Name = "lstTipoActividad";
            this.lstTipoActividad.Size = new System.Drawing.Size(190, 21);
            this.lstTipoActividad.TabIndex = 5;
            // 
            // mrcReunion
            // 
            this.mrcReunion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mrcReunion.Controls.Add(this.optNo);
            this.mrcReunion.Controls.Add(this.optSi);
            this.mrcReunion.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcReunion.ForeColor = System.Drawing.Color.Teal;
            this.mrcReunion.Location = new System.Drawing.Point(19, 139);
            this.mrcReunion.Name = "mrcReunion";
            this.mrcReunion.Size = new System.Drawing.Size(246, 80);
            this.mrcReunion.TabIndex = 6;
            this.mrcReunion.TabStop = false;
            this.mrcReunion.Text = "Reunion";
            // 
            // optNo
            // 
            this.optNo.AutoSize = true;
            this.optNo.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.optNo.Location = new System.Drawing.Point(151, 32);
            this.optNo.Name = "optNo";
            this.optNo.Size = new System.Drawing.Size(43, 23);
            this.optNo.TabIndex = 1;
            this.optNo.TabStop = true;
            this.optNo.Text = "No";
            this.optNo.UseVisualStyleBackColor = true;
            // 
            // optSi
            // 
            this.optSi.AutoSize = true;
            this.optSi.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.optSi.Location = new System.Drawing.Point(43, 32);
            this.optSi.Name = "optSi";
            this.optSi.Size = new System.Drawing.Size(39, 23);
            this.optSi.TabIndex = 0;
            this.optSi.TabStop = true;
            this.optSi.Text = "Si";
            this.optSi.UseVisualStyleBackColor = true;
            // 
            // mrcTareas
            // 
            this.mrcTareas.Controls.Add(this.chkDebate);
            this.mrcTareas.Controls.Add(this.chkNotasReunion);
            this.mrcTareas.Controls.Add(this.chkInvestigacion);
            this.mrcTareas.Controls.Add(this.chkRepositorio);
            this.mrcTareas.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcTareas.ForeColor = System.Drawing.Color.Teal;
            this.mrcTareas.Location = new System.Drawing.Point(19, 237);
            this.mrcTareas.Name = "mrcTareas";
            this.mrcTareas.Size = new System.Drawing.Size(246, 96);
            this.mrcTareas.TabIndex = 7;
            this.mrcTareas.TabStop = false;
            this.mrcTareas.Text = "Tareas";
            // 
            // chkDebate
            // 
            this.chkDebate.AutoSize = true;
            this.chkDebate.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDebate.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.chkDebate.Location = new System.Drawing.Point(128, 59);
            this.chkDebate.Name = "chkDebate";
            this.chkDebate.Size = new System.Drawing.Size(66, 21);
            this.chkDebate.TabIndex = 3;
            this.chkDebate.Text = "Debate";
            this.chkDebate.UseVisualStyleBackColor = true;
            // 
            // chkNotasReunion
            // 
            this.chkNotasReunion.AutoSize = true;
            this.chkNotasReunion.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNotasReunion.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.chkNotasReunion.Location = new System.Drawing.Point(8, 59);
            this.chkNotasReunion.Name = "chkNotasReunion";
            this.chkNotasReunion.Size = new System.Drawing.Size(106, 21);
            this.chkNotasReunion.TabIndex = 2;
            this.chkNotasReunion.Text = "Notas Reunión";
            this.chkNotasReunion.UseVisualStyleBackColor = true;
            // 
            // chkInvestigacion
            // 
            this.chkInvestigacion.AutoSize = true;
            this.chkInvestigacion.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkInvestigacion.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.chkInvestigacion.Location = new System.Drawing.Point(128, 26);
            this.chkInvestigacion.Name = "chkInvestigacion";
            this.chkInvestigacion.Size = new System.Drawing.Size(102, 21);
            this.chkInvestigacion.TabIndex = 1;
            this.chkInvestigacion.Text = "Investigación";
            this.chkInvestigacion.UseVisualStyleBackColor = true;
            // 
            // chkRepositorio
            // 
            this.chkRepositorio.AutoSize = true;
            this.chkRepositorio.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRepositorio.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.chkRepositorio.Location = new System.Drawing.Point(7, 26);
            this.chkRepositorio.Name = "chkRepositorio";
            this.chkRepositorio.Size = new System.Drawing.Size(92, 21);
            this.chkRepositorio.TabIndex = 0;
            this.chkRepositorio.Text = "Repositorio";
            this.chkRepositorio.UseVisualStyleBackColor = true;
            // 
            // cmdGrabar
            // 
            this.cmdGrabar.BackColor = System.Drawing.Color.Gainsboro;
            this.cmdGrabar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdGrabar.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGrabar.Location = new System.Drawing.Point(104, 348);
            this.cmdGrabar.Name = "cmdGrabar";
            this.cmdGrabar.Size = new System.Drawing.Size(75, 23);
            this.cmdGrabar.TabIndex = 8;
            this.cmdGrabar.Text = "Grabar";
            this.cmdGrabar.UseVisualStyleBackColor = false;
            this.cmdGrabar.Click += new System.EventHandler(this.cmdGrabar_Click);
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.BackColor = System.Drawing.Color.Gainsboro;
            this.cmdCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdCancelar.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancelar.Location = new System.Drawing.Point(185, 348);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(80, 23);
            this.cmdCancelar.TabIndex = 9;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.UseVisualStyleBackColor = false;
            // 
            // frmRegistrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(295, 385);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.cmdGrabar);
            this.Controls.Add(this.mrcTareas);
            this.Controls.Add(this.mrcReunion);
            this.Controls.Add(this.lstTipoActividad);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.txtDetalle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblFecha);
            this.Name = "frmRegistrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar";
            this.mrcReunion.ResumeLayout(false);
            this.mrcReunion.PerformLayout();
            this.mrcTareas.ResumeLayout(false);
            this.mrcTareas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDetalle;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ComboBox lstTipoActividad;
        private System.Windows.Forms.GroupBox mrcReunion;
        private System.Windows.Forms.RadioButton optNo;
        private System.Windows.Forms.RadioButton optSi;
        private System.Windows.Forms.GroupBox mrcTareas;
        private System.Windows.Forms.CheckBox chkDebate;
        private System.Windows.Forms.CheckBox chkNotasReunion;
        private System.Windows.Forms.CheckBox chkInvestigacion;
        private System.Windows.Forms.CheckBox chkRepositorio;
        private System.Windows.Forms.Button cmdGrabar;
        private System.Windows.Forms.Button cmdCancelar;
    }
}
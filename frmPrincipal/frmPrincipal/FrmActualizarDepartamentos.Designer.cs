namespace frmPrincipal
{
    partial class FrmActualizarDepartamentos
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
            this.gbCrearDepartamentos = new System.Windows.Forms.GroupBox();
            this.txtCodigoDepto = new System.Windows.Forms.TextBox();
            this.lblCodigoDepto = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dtpFechaMod = new System.Windows.Forms.DateTimePicker();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtNombreDepto = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblActualizarDepartamentos = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblFechaModificacion = new System.Windows.Forms.Label();
            this.gbCrearDepartamentos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCrearDepartamentos
            // 
            this.gbCrearDepartamentos.Controls.Add(this.txtCodigoDepto);
            this.gbCrearDepartamentos.Controls.Add(this.lblCodigoDepto);
            this.gbCrearDepartamentos.Controls.Add(this.btnSalir);
            this.gbCrearDepartamentos.Controls.Add(this.btnGuardar);
            this.gbCrearDepartamentos.Controls.Add(this.dtpFechaMod);
            this.gbCrearDepartamentos.Controls.Add(this.txtDescripcion);
            this.gbCrearDepartamentos.Controls.Add(this.txtNombreDepto);
            this.gbCrearDepartamentos.Controls.Add(this.lblNombre);
            this.gbCrearDepartamentos.Controls.Add(this.lblActualizarDepartamentos);
            this.gbCrearDepartamentos.Controls.Add(this.lblDescripcion);
            this.gbCrearDepartamentos.Controls.Add(this.lblFechaModificacion);
            this.gbCrearDepartamentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCrearDepartamentos.Location = new System.Drawing.Point(12, 12);
            this.gbCrearDepartamentos.Name = "gbCrearDepartamentos";
            this.gbCrearDepartamentos.Size = new System.Drawing.Size(424, 355);
            this.gbCrearDepartamentos.TabIndex = 5;
            this.gbCrearDepartamentos.TabStop = false;
            // 
            // txtCodigoDepto
            // 
            this.txtCodigoDepto.Location = new System.Drawing.Point(122, 85);
            this.txtCodigoDepto.Name = "txtCodigoDepto";
            this.txtCodigoDepto.Size = new System.Drawing.Size(277, 26);
            this.txtCodigoDepto.TabIndex = 1;
            // 
            // lblCodigoDepto
            // 
            this.lblCodigoDepto.AutoSize = true;
            this.lblCodigoDepto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoDepto.Location = new System.Drawing.Point(19, 88);
            this.lblCodigoDepto.Name = "lblCodigoDepto";
            this.lblCodigoDepto.Size = new System.Drawing.Size(59, 20);
            this.lblCodigoDepto.TabIndex = 10;
            this.lblCodigoDepto.Text = "Codigo";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(272, 301);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 37);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(80, 301);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(93, 37);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Actualizar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dtpFechaMod
            // 
            this.dtpFechaMod.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaMod.Location = new System.Drawing.Point(122, 237);
            this.dtpFechaMod.Name = "dtpFechaMod";
            this.dtpFechaMod.Size = new System.Drawing.Size(159, 26);
            this.dtpFechaMod.TabIndex = 4;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(122, 185);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(277, 26);
            this.txtDescripcion.TabIndex = 3;
            // 
            // txtNombreDepto
            // 
            this.txtNombreDepto.Location = new System.Drawing.Point(122, 135);
            this.txtNombreDepto.Name = "txtNombreDepto";
            this.txtNombreDepto.Size = new System.Drawing.Size(277, 26);
            this.txtNombreDepto.TabIndex = 2;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(19, 138);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(65, 20);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblActualizarDepartamentos
            // 
            this.lblActualizarDepartamentos.AutoSize = true;
            this.lblActualizarDepartamentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActualizarDepartamentos.Location = new System.Drawing.Point(52, 13);
            this.lblActualizarDepartamentos.Name = "lblActualizarDepartamentos";
            this.lblActualizarDepartamentos.Size = new System.Drawing.Size(310, 29);
            this.lblActualizarDepartamentos.TabIndex = 4;
            this.lblActualizarDepartamentos.Text = "Actualizar Departamentos";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(19, 188);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(92, 20);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Descripción";
            // 
            // lblFechaModificacion
            // 
            this.lblFechaModificacion.AutoSize = true;
            this.lblFechaModificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaModificacion.Location = new System.Drawing.Point(19, 237);
            this.lblFechaModificacion.Name = "lblFechaModificacion";
            this.lblFechaModificacion.Size = new System.Drawing.Size(54, 20);
            this.lblFechaModificacion.TabIndex = 3;
            this.lblFechaModificacion.Text = "Fecha";
            // 
            // FrmActualizarDepartamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 379);
            this.Controls.Add(this.gbCrearDepartamentos);
            this.Name = "FrmActualizarDepartamentos";
            this.Text = "FrmActualizarDepartamentos";
            this.gbCrearDepartamentos.ResumeLayout(false);
            this.gbCrearDepartamentos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCrearDepartamentos;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DateTimePicker dtpFechaMod;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtNombreDepto;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblActualizarDepartamentos;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblFechaModificacion;
        private System.Windows.Forms.TextBox txtCodigoDepto;
        private System.Windows.Forms.Label lblCodigoDepto;
    }
}
namespace frmPrincipal
{
    partial class FrmListarDepartamentos
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
            this.dgvListarDepartamentos = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarDepartamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListarDepartamentos
            // 
            this.dgvListarDepartamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListarDepartamentos.Location = new System.Drawing.Point(12, 12);
            this.dgvListarDepartamentos.Name = "dgvListarDepartamentos";
            this.dgvListarDepartamentos.Size = new System.Drawing.Size(506, 356);
            this.dgvListarDepartamentos.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(218, 374);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 32);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmListarDepartamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 435);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvListarDepartamentos);
            this.Name = "FrmListarDepartamentos";
            this.Text = "FrmListarDepartamentos";
            this.Load += new System.EventHandler(this.FrmListarDepartamentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarDepartamentos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListarDepartamentos;
        private System.Windows.Forms.Button btnSalir;
    }
}
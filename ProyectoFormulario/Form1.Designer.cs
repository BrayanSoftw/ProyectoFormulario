namespace ProyectoFormulario
{
    partial class Form1
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
            this.grbDatos = new System.Windows.Forms.GroupBox();
            this.lblCtrl = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblSemestre = new System.Windows.Forms.Label();
            this.picLogoFup = new System.Windows.Forms.PictureBox();
            this.txtCtrl = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cboSemestre = new System.Windows.Forms.ComboBox();
            this.lblFup = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCargarFoto = new System.Windows.Forms.Button();
            this.grbDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoFup)).BeginInit();
            this.SuspendLayout();
            // 
            // grbDatos
            // 
            this.grbDatos.Controls.Add(this.cboSemestre);
            this.grbDatos.Controls.Add(this.txtNombre);
            this.grbDatos.Controls.Add(this.txtCtrl);
            this.grbDatos.Controls.Add(this.lblSemestre);
            this.grbDatos.Controls.Add(this.lblNombre);
            this.grbDatos.Controls.Add(this.lblCtrl);
            this.grbDatos.Location = new System.Drawing.Point(12, 209);
            this.grbDatos.Name = "grbDatos";
            this.grbDatos.Size = new System.Drawing.Size(234, 132);
            this.grbDatos.TabIndex = 0;
            this.grbDatos.TabStop = false;
            this.grbDatos.Text = "Datos";
            // 
            // lblCtrl
            // 
            this.lblCtrl.AutoSize = true;
            this.lblCtrl.Location = new System.Drawing.Point(6, 42);
            this.lblCtrl.Name = "lblCtrl";
            this.lblCtrl.Size = new System.Drawing.Size(42, 13);
            this.lblCtrl.TabIndex = 0;
            this.lblCtrl.Text = "No. Ctrl";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 79);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblSemestre
            // 
            this.lblSemestre.AutoSize = true;
            this.lblSemestre.Location = new System.Drawing.Point(6, 109);
            this.lblSemestre.Name = "lblSemestre";
            this.lblSemestre.Size = new System.Drawing.Size(51, 13);
            this.lblSemestre.TabIndex = 2;
            this.lblSemestre.Text = "Semestre";
            // 
            // picLogoFup
            // 
            this.picLogoFup.Image = global::ProyectoFormulario.Properties.Resources.FUP;
            this.picLogoFup.Location = new System.Drawing.Point(12, 12);
            this.picLogoFup.Name = "picLogoFup";
            this.picLogoFup.Size = new System.Drawing.Size(255, 161);
            this.picLogoFup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogoFup.TabIndex = 1;
            this.picLogoFup.TabStop = false;
            // 
            // txtCtrl
            // 
            this.txtCtrl.Location = new System.Drawing.Point(128, 35);
            this.txtCtrl.Name = "txtCtrl";
            this.txtCtrl.Size = new System.Drawing.Size(100, 20);
            this.txtCtrl.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(128, 72);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // cboSemestre
            // 
            this.cboSemestre.FormattingEnabled = true;
            this.cboSemestre.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cboSemestre.Location = new System.Drawing.Point(107, 105);
            this.cboSemestre.Name = "cboSemestre";
            this.cboSemestre.Size = new System.Drawing.Size(121, 21);
            this.cboSemestre.TabIndex = 2;
            // 
            // lblFup
            // 
            this.lblFup.AutoSize = true;
            this.lblFup.Location = new System.Drawing.Point(315, 12);
            this.lblFup.Name = "lblFup";
            this.lblFup.Size = new System.Drawing.Size(180, 13);
            this.lblFup.TabIndex = 2;
            this.lblFup.Text = "Fundación Universitaria De Popayán";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(649, 318);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnCargarFoto
            // 
            this.btnCargarFoto.Location = new System.Drawing.Point(192, 180);
            this.btnCargarFoto.Name = "btnCargarFoto";
            this.btnCargarFoto.Size = new System.Drawing.Size(75, 23);
            this.btnCargarFoto.TabIndex = 4;
            this.btnCargarFoto.Text = "Cargar Foto";
            this.btnCargarFoto.UseVisualStyleBackColor = true;
            this.btnCargarFoto.Click += new System.EventHandler(this.btnCargarFoto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCargarFoto);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblFup);
            this.Controls.Add(this.picLogoFup);
            this.Controls.Add(this.grbDatos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grbDatos.ResumeLayout(false);
            this.grbDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoFup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDatos;
        private System.Windows.Forms.Label lblSemestre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCtrl;
        private System.Windows.Forms.ComboBox cboSemestre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCtrl;
        private System.Windows.Forms.PictureBox picLogoFup;
        private System.Windows.Forms.Label lblFup;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCargarFoto;
    }
}


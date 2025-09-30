namespace Militantes_politicos
{
    partial class frmMilitantes
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
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.limpiarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labEstado = new System.Windows.Forms.Label();
            this.labNombreEstado = new System.Windows.Forms.Label();
            this.labMunicipio = new System.Windows.Forms.Label();
            this.cmbMunicipio = new System.Windows.Forms.ComboBox();
            this.dgvInformacion = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chbFecha = new System.Windows.Forms.CheckBox();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.labFecha1 = new System.Windows.Forms.Label();
            this.labFecha2 = new System.Windows.Forms.Label();
            this.dtpTermino = new System.Windows.Forms.DateTimePicker();
            this.ofdCargar = new System.Windows.Forms.OpenFileDialog();
            this.sstAfiliados = new System.Windows.Forms.StatusStrip();
            this.tsslAfiliados = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnFecha = new System.Windows.Forms.Button();
            this.labSource = new System.Windows.Forms.Label();
            this.labDir = new System.Windows.Forms.Label();
            this.msMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformacion)).BeginInit();
            this.sstAfiliados.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMenu
            // 
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.opcionesToolStripMenuItem});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(801, 24);
            this.msMenu.TabIndex = 0;
            this.msMenu.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarToolStripMenuItem,
            this.salirToolStripMenuItem1});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // cargarToolStripMenuItem
            // 
            this.cargarToolStripMenuItem.Name = "cargarToolStripMenuItem";
            this.cargarToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.cargarToolStripMenuItem.Text = "Cargar Excel";
            this.cargarToolStripMenuItem.Click += new System.EventHandler(this.cargarToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem1
            // 
            this.salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            this.salirToolStripMenuItem1.Size = new System.Drawing.Size(139, 22);
            this.salirToolStripMenuItem1.Text = "Salir";
            this.salirToolStripMenuItem1.Click += new System.EventHandler(this.salirToolStripMenuItem1_Click);
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.limpiarDatosToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // limpiarDatosToolStripMenuItem
            // 
            this.limpiarDatosToolStripMenuItem.Name = "limpiarDatosToolStripMenuItem";
            this.limpiarDatosToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.limpiarDatosToolStripMenuItem.Text = "Limpiar datos";
            this.limpiarDatosToolStripMenuItem.Click += new System.EventHandler(this.limpiarDatosToolStripMenuItem_Click);
            // 
            // labEstado
            // 
            this.labEstado.AutoSize = true;
            this.labEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labEstado.Location = new System.Drawing.Point(14, 24);
            this.labEstado.Name = "labEstado";
            this.labEstado.Size = new System.Drawing.Size(79, 25);
            this.labEstado.TabIndex = 1;
            this.labEstado.Text = "Estado";
            // 
            // labNombreEstado
            // 
            this.labNombreEstado.AutoSize = true;
            this.labNombreEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNombreEstado.Location = new System.Drawing.Point(131, 28);
            this.labNombreEstado.Name = "labNombreEstado";
            this.labNombreEstado.Size = new System.Drawing.Size(240, 20);
            this.labNombreEstado.TabIndex = 2;
            this.labNombreEstado.Text = "No se ha cargado ningún archivo";
            // 
            // labMunicipio
            // 
            this.labMunicipio.AutoSize = true;
            this.labMunicipio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labMunicipio.Location = new System.Drawing.Point(14, 61);
            this.labMunicipio.Name = "labMunicipio";
            this.labMunicipio.Size = new System.Drawing.Size(104, 25);
            this.labMunicipio.TabIndex = 3;
            this.labMunicipio.Text = "Municipio";
            // 
            // cmbMunicipio
            // 
            this.cmbMunicipio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMunicipio.FormattingEnabled = true;
            this.cmbMunicipio.Items.AddRange(new object[] {
            "Seleccionar"});
            this.cmbMunicipio.Location = new System.Drawing.Point(135, 65);
            this.cmbMunicipio.Name = "cmbMunicipio";
            this.cmbMunicipio.Size = new System.Drawing.Size(130, 24);
            this.cmbMunicipio.TabIndex = 4;
            this.cmbMunicipio.Text = "Seleccionar";
            this.cmbMunicipio.SelectedIndexChanged += new System.EventHandler(this.cmbMunicipio_SelectedIndexChanged);
            // 
            // dgvInformacion
            // 
            this.dgvInformacion.AllowUserToAddRows = false;
            this.dgvInformacion.AllowUserToDeleteRows = false;
            this.dgvInformacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInformacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvInformacion.Location = new System.Drawing.Point(0, 95);
            this.dgvInformacion.Name = "dgvInformacion";
            this.dgvInformacion.ReadOnly = true;
            this.dgvInformacion.Size = new System.Drawing.Size(794, 236);
            this.dgvInformacion.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Entidad";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Municipio";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Nombre";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 250;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Fecha de Afiliación";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Estatus";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // chbFecha
            // 
            this.chbFecha.AutoSize = true;
            this.chbFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbFecha.Location = new System.Drawing.Point(19, 344);
            this.chbFecha.Name = "chbFecha";
            this.chbFecha.Size = new System.Drawing.Size(64, 20);
            this.chbFecha.TabIndex = 6;
            this.chbFecha.Text = "Fecha";
            this.chbFecha.UseVisualStyleBackColor = true;
            this.chbFecha.CheckedChanged += new System.EventHandler(this.chbFecha_CheckedChanged);
            // 
            // dtpInicio
            // 
            this.dtpInicio.Enabled = false;
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(120, 371);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(145, 20);
            this.dtpInicio.TabIndex = 7;
            // 
            // labFecha1
            // 
            this.labFecha1.AutoSize = true;
            this.labFecha1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labFecha1.Location = new System.Drawing.Point(16, 371);
            this.labFecha1.Name = "labFecha1";
            this.labFecha1.Size = new System.Drawing.Size(79, 16);
            this.labFecha1.TabIndex = 8;
            this.labFecha1.Text = "Fecha Inicio";
            // 
            // labFecha2
            // 
            this.labFecha2.AutoSize = true;
            this.labFecha2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labFecha2.Location = new System.Drawing.Point(16, 401);
            this.labFecha2.Name = "labFecha2";
            this.labFecha2.Size = new System.Drawing.Size(98, 16);
            this.labFecha2.TabIndex = 9;
            this.labFecha2.Text = "Fecha Término";
            // 
            // dtpTermino
            // 
            this.dtpTermino.Enabled = false;
            this.dtpTermino.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTermino.Location = new System.Drawing.Point(120, 401);
            this.dtpTermino.Name = "dtpTermino";
            this.dtpTermino.Size = new System.Drawing.Size(145, 20);
            this.dtpTermino.TabIndex = 10;
            // 
            // ofdCargar
            // 
            this.ofdCargar.FileName = "Archivo | .xlsx";
            this.ofdCargar.InitialDirectory = "Descargas";
            // 
            // sstAfiliados
            // 
            this.sstAfiliados.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslAfiliados});
            this.sstAfiliados.Location = new System.Drawing.Point(0, 444);
            this.sstAfiliados.Name = "sstAfiliados";
            this.sstAfiliados.Size = new System.Drawing.Size(801, 22);
            this.sstAfiliados.TabIndex = 11;
            // 
            // tsslAfiliados
            // 
            this.tsslAfiliados.Name = "tsslAfiliados";
            this.tsslAfiliados.Size = new System.Drawing.Size(59, 17);
            this.tsslAfiliados.Text = "Afiliados :";
            // 
            // btnFecha
            // 
            this.btnFecha.Location = new System.Drawing.Point(289, 397);
            this.btnFecha.Name = "btnFecha";
            this.btnFecha.Size = new System.Drawing.Size(122, 23);
            this.btnFecha.TabIndex = 12;
            this.btnFecha.Text = "Buscar por fecha";
            this.btnFecha.UseVisualStyleBackColor = true;
            this.btnFecha.Click += new System.EventHandler(this.btnFecha_Click);
            // 
            // labSource
            // 
            this.labSource.AutoSize = true;
            this.labSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSource.Location = new System.Drawing.Point(389, 29);
            this.labSource.Name = "labSource";
            this.labSource.Size = new System.Drawing.Size(206, 24);
            this.labSource.TabIndex = 13;
            this.labSource.Text = "Archivo cargado desde";
            // 
            // labDir
            // 
            this.labDir.AutoSize = true;
            this.labDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDir.Location = new System.Drawing.Point(389, 61);
            this.labDir.Name = "labDir";
            this.labDir.Size = new System.Drawing.Size(231, 20);
            this.labDir.TabIndex = 14;
            this.labDir.Text = "No se ha cargado nigún archivo";
            // 
            // frmMilitantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 466);
            this.Controls.Add(this.labDir);
            this.Controls.Add(this.labSource);
            this.Controls.Add(this.btnFecha);
            this.Controls.Add(this.sstAfiliados);
            this.Controls.Add(this.dtpTermino);
            this.Controls.Add(this.labFecha2);
            this.Controls.Add(this.labFecha1);
            this.Controls.Add(this.dtpInicio);
            this.Controls.Add(this.chbFecha);
            this.Controls.Add(this.dgvInformacion);
            this.Controls.Add(this.cmbMunicipio);
            this.Controls.Add(this.labMunicipio);
            this.Controls.Add(this.labNombreEstado);
            this.Controls.Add(this.labEstado);
            this.Controls.Add(this.msMenu);
            this.MainMenuStrip = this.msMenu;
            this.Name = "frmMilitantes";
            this.Text = "Militantes Politicos";
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformacion)).EndInit();
            this.sstAfiliados.ResumeLayout(false);
            this.sstAfiliados.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cargarToolStripMenuItem;
        private System.Windows.Forms.Label labEstado;
        private System.Windows.Forms.Label labNombreEstado;
        private System.Windows.Forms.Label labMunicipio;
        private System.Windows.Forms.ComboBox cmbMunicipio;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem limpiarDatosToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvInformacion;
        private System.Windows.Forms.CheckBox chbFecha;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.Label labFecha1;
        private System.Windows.Forms.Label labFecha2;
        private System.Windows.Forms.DateTimePicker dtpTermino;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.OpenFileDialog ofdCargar;
        private System.Windows.Forms.StatusStrip sstAfiliados;
        private System.Windows.Forms.ToolStripStatusLabel tsslAfiliados;
        private System.Windows.Forms.Button btnFecha;
        private System.Windows.Forms.Label labSource;
        private System.Windows.Forms.Label labDir;
    }
}


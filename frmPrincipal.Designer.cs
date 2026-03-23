namespace MinisorterFileAnalizer
{
    partial class frmPrincipal
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            label1 = new Label();
            txtDirectorio = new TextBox();
            btnExaminar = new Button();
            btnAnalizar = new Button();
            label2 = new Label();
            lblCantidadDeArchivosParaProcesar = new Label();
            label3 = new Label();
            label4 = new Label();
            lblCantidadDeArchivos = new Label();
            lblCantidadDeRegistros = new Label();
            dgvBultos = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colTipoMensaje = new DataGridViewTextBoxColumn();
            colCodigoPais = new DataGridViewTextBoxColumn();
            colPlazaAndreani = new DataGridViewTextBoxColumn();
            colNroSorter = new DataGridViewTextBoxColumn();
            colNroLineaEntrada = new DataGridViewTextBoxColumn();
            colSalidaPrevista = new DataGridViewTextBoxColumn();
            colSalidaReal = new DataGridViewTextBoxColumn();
            colMotivoDestino = new DataGridViewTextBoxColumn();
            colDate = new DataGridViewTextBoxColumn();
            colHora = new DataGridViewTextBoxColumn();
            colLongitud = new DataGridViewTextBoxColumn();
            colAncho = new DataGridViewTextBoxColumn();
            colAlto = new DataGridViewTextBoxColumn();
            colVolumen = new DataGridViewTextBoxColumn();
            colPeso = new DataGridViewTextBoxColumn();
            colReporteLectura = new DataGridViewTextBoxColumn();
            colReportePeso = new DataGridViewTextBoxColumn();
            colReporteVolumen = new DataGridViewTextBoxColumn();
            colReporteClasificacion = new DataGridViewTextBoxColumn();
            colCodigoBarras = new DataGridViewTextBoxColumn();
            colNombreArchivo = new DataGridViewTextBoxColumn();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            toolStripStatusLabel3 = new ToolStripStatusLabel();
            toolStripStatusLabel4 = new ToolStripStatusLabel();
            tslFormSizeAndLocation = new ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)dgvBultos).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 28);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 0;
            label1.Text = "Directorio:";
            // 
            // txtDirectorio
            // 
            txtDirectorio.Location = new Point(94, 25);
            txtDirectorio.Name = "txtDirectorio";
            txtDirectorio.Size = new Size(310, 23);
            txtDirectorio.TabIndex = 1;
            txtDirectorio.Leave += txtDirectorio_Leave;
            // 
            // btnExaminar
            // 
            btnExaminar.Location = new Point(410, 25);
            btnExaminar.Name = "btnExaminar";
            btnExaminar.Size = new Size(45, 23);
            btnExaminar.TabIndex = 2;
            btnExaminar.Text = "...";
            btnExaminar.UseVisualStyleBackColor = true;
            btnExaminar.Click += btnExaminar_Click;
            // 
            // btnAnalizar
            // 
            btnAnalizar.Location = new Point(500, 28);
            btnAnalizar.Name = "btnAnalizar";
            btnAnalizar.Size = new Size(75, 23);
            btnAnalizar.TabIndex = 3;
            btnAnalizar.Text = "Analizar";
            btnAnalizar.UseVisualStyleBackColor = true;
            btnAnalizar.Click += btnAnalizar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 64);
            label2.Name = "label2";
            label2.Size = new Size(130, 15);
            label2.TabIndex = 4;
            label2.Text = "Archivos para Procesar:";
            // 
            // lblCantidadDeArchivosParaProcesar
            // 
            lblCantidadDeArchivosParaProcesar.AutoSize = true;
            lblCantidadDeArchivosParaProcesar.Location = new Point(167, 64);
            lblCantidadDeArchivosParaProcesar.Name = "lblCantidadDeArchivosParaProcesar";
            lblCantidadDeArchivosParaProcesar.Size = new Size(38, 15);
            lblCantidadDeArchivosParaProcesar.TabIndex = 5;
            lblCantidadDeArchivosParaProcesar.Text = "label3";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 139);
            label3.Name = "label3";
            label3.Size = new Size(186, 15);
            label3.TabIndex = 6;
            label3.Text = "Cantidad de Archivos Procesados:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 168);
            label4.Name = "label4";
            label4.Size = new Size(125, 15);
            label4.TabIndex = 7;
            label4.Text = "Cantidad de Registros:";
            // 
            // lblCantidadDeArchivos
            // 
            lblCantidadDeArchivos.AutoSize = true;
            lblCantidadDeArchivos.Location = new Point(217, 138);
            lblCantidadDeArchivos.Name = "lblCantidadDeArchivos";
            lblCantidadDeArchivos.Size = new Size(38, 15);
            lblCantidadDeArchivos.TabIndex = 8;
            lblCantidadDeArchivos.Text = "label6";
            // 
            // lblCantidadDeRegistros
            // 
            lblCantidadDeRegistros.AutoSize = true;
            lblCantidadDeRegistros.Location = new Point(150, 169);
            lblCantidadDeRegistros.Name = "lblCantidadDeRegistros";
            lblCantidadDeRegistros.Size = new Size(38, 15);
            lblCantidadDeRegistros.TabIndex = 9;
            lblCantidadDeRegistros.Text = "label6";
            // 
            // dgvBultos
            // 
            dgvBultos.AllowUserToAddRows = false;
            dgvBultos.AllowUserToDeleteRows = false;
            dgvBultos.AllowUserToResizeRows = false;
            dgvBultos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvBultos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBultos.Columns.AddRange(new DataGridViewColumn[] { colId, colTipoMensaje, colCodigoPais, colPlazaAndreani, colNroSorter, colNroLineaEntrada, colSalidaPrevista, colSalidaReal, colMotivoDestino, colDate, colHora, colLongitud, colAncho, colAlto, colVolumen, colPeso, colReporteLectura, colReportePeso, colReporteVolumen, colReporteClasificacion, colCodigoBarras, colNombreArchivo });
            dgvBultos.Location = new Point(17, 211);
            dgvBultos.Name = "dgvBultos";
            dgvBultos.RowHeadersVisible = false;
            dgvBultos.Size = new Size(786, 301);
            dgvBultos.TabIndex = 10;
            // 
            // colId
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N0";
            colId.DefaultCellStyle = dataGridViewCellStyle1;
            colId.HeaderText = "Id";
            colId.Name = "colId";
            // 
            // colTipoMensaje
            // 
            colTipoMensaje.HeaderText = "Tipo de Mensaje";
            colTipoMensaje.Name = "colTipoMensaje";
            // 
            // colCodigoPais
            // 
            colCodigoPais.HeaderText = "País";
            colCodigoPais.Name = "colCodigoPais";
            // 
            // colPlazaAndreani
            // 
            colPlazaAndreani.HeaderText = "Plaza";
            colPlazaAndreani.Name = "colPlazaAndreani";
            // 
            // colNroSorter
            // 
            colNroSorter.HeaderText = "# Sorter";
            colNroSorter.Name = "colNroSorter";
            // 
            // colNroLineaEntrada
            // 
            colNroLineaEntrada.HeaderText = "Línea Entrada";
            colNroLineaEntrada.Name = "colNroLineaEntrada";
            // 
            // colSalidaPrevista
            // 
            colSalidaPrevista.HeaderText = "Salida Prevista";
            colSalidaPrevista.Name = "colSalidaPrevista";
            // 
            // colSalidaReal
            // 
            colSalidaReal.HeaderText = "Salida Real";
            colSalidaReal.Name = "colSalidaReal";
            // 
            // colMotivoDestino
            // 
            colMotivoDestino.HeaderText = "Motivo Destino";
            colMotivoDestino.Name = "colMotivoDestino";
            // 
            // colDate
            // 
            colDate.HeaderText = "Fecha";
            colDate.Name = "colDate";
            // 
            // colHora
            // 
            colHora.HeaderText = "Hora";
            colHora.Name = "colHora";
            // 
            // colLongitud
            // 
            colLongitud.HeaderText = "Longitud";
            colLongitud.Name = "colLongitud";
            // 
            // colAncho
            // 
            colAncho.HeaderText = "Ancho";
            colAncho.Name = "colAncho";
            // 
            // colAlto
            // 
            colAlto.HeaderText = "Alto";
            colAlto.Name = "colAlto";
            // 
            // colVolumen
            // 
            colVolumen.HeaderText = "Volumen";
            colVolumen.Name = "colVolumen";
            // 
            // colPeso
            // 
            colPeso.HeaderText = "Peso";
            colPeso.Name = "colPeso";
            // 
            // colReporteLectura
            // 
            colReporteLectura.HeaderText = "Reporte Lectura";
            colReporteLectura.Name = "colReporteLectura";
            // 
            // colReportePeso
            // 
            colReportePeso.HeaderText = "Reporte Peso";
            colReportePeso.Name = "colReportePeso";
            // 
            // colReporteVolumen
            // 
            colReporteVolumen.HeaderText = "Reporte Volumen";
            colReporteVolumen.Name = "colReporteVolumen";
            // 
            // colReporteClasificacion
            // 
            colReporteClasificacion.HeaderText = "Reporte Clasificación";
            colReporteClasificacion.Name = "colReporteClasificacion";
            // 
            // colCodigoBarras
            // 
            colCodigoBarras.HeaderText = "C.Barras";
            colCodigoBarras.Name = "colCodigoBarras";
            // 
            // colNombreArchivo
            // 
            colNombreArchivo.HeaderText = "Archivo";
            colNombreArchivo.Name = "colNombreArchivo";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripStatusLabel2, toolStripStatusLabel3, toolStripStatusLabel4, tslFormSizeAndLocation });
            statusStrip1.Location = new Point(0, 523);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(821, 24);
            statusStrip1.TabIndex = 11;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.AutoSize = false;
            toolStripStatusLabel1.BorderSides = ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom;
            toolStripStatusLabel1.BorderStyle = Border3DStyle.Sunken;
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(122, 19);
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.AutoSize = false;
            toolStripStatusLabel2.BorderSides = ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom;
            toolStripStatusLabel2.BorderStyle = Border3DStyle.Sunken;
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(122, 19);
            // 
            // toolStripStatusLabel3
            // 
            toolStripStatusLabel3.AutoSize = false;
            toolStripStatusLabel3.BorderSides = ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom;
            toolStripStatusLabel3.BorderStyle = Border3DStyle.Sunken;
            toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            toolStripStatusLabel3.Size = new Size(122, 19);
            // 
            // toolStripStatusLabel4
            // 
            toolStripStatusLabel4.AutoSize = false;
            toolStripStatusLabel4.BorderSides = ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom;
            toolStripStatusLabel4.BorderStyle = Border3DStyle.Sunken;
            toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            toolStripStatusLabel4.Size = new Size(122, 19);
            // 
            // tslFormSizeAndLocation
            // 
            tslFormSizeAndLocation.AutoSize = false;
            tslFormSizeAndLocation.BorderSides = ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom;
            tslFormSizeAndLocation.BorderStyle = Border3DStyle.Sunken;
            tslFormSizeAndLocation.Name = "tslFormSizeAndLocation";
            tslFormSizeAndLocation.Size = new Size(250, 19);
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(821, 547);
            Controls.Add(statusStrip1);
            Controls.Add(dgvBultos);
            Controls.Add(lblCantidadDeRegistros);
            Controls.Add(lblCantidadDeArchivos);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblCantidadDeArchivosParaProcesar);
            Controls.Add(label2);
            Controls.Add(btnAnalizar);
            Controls.Add(btnExaminar);
            Controls.Add(txtDirectorio);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmPrincipal";
            Text = "Mini Sorter File Analyzer";
            FormClosing += frmPrincipal_FormClosing;
            Load += frmPrincipal_Load;
            Move += frmPrincipal_Move;
            Resize += frmPrincipal_Resize;
            ((System.ComponentModel.ISupportInitialize)dgvBultos).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtDirectorio;
        private Button btnExaminar;
        private Button btnAnalizar;
        private Label label2;
        private Label lblCantidadDeArchivosParaProcesar;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lblCantidadDeArchivos;
        private Label lblCantidadDeRegistros;
        private DataGridView dgvBultos;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private ToolStripStatusLabel toolStripStatusLabel4;
        private ToolStripStatusLabel tslFormSizeAndLocation;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colTipoMensaje;
        private DataGridViewTextBoxColumn colCodigoPais;
        private DataGridViewTextBoxColumn colPlazaAndreani;
        private DataGridViewTextBoxColumn colNroSorter;
        private DataGridViewTextBoxColumn colNroLineaEntrada;
        private DataGridViewTextBoxColumn colSalidaPrevista;
        private DataGridViewTextBoxColumn colSalidaReal;
        private DataGridViewTextBoxColumn colMotivoDestino;
        private DataGridViewTextBoxColumn colDate;
        private DataGridViewTextBoxColumn colHora;
        private DataGridViewTextBoxColumn colLongitud;
        private DataGridViewTextBoxColumn colAncho;
        private DataGridViewTextBoxColumn colAlto;
        private DataGridViewTextBoxColumn colVolumen;
        private DataGridViewTextBoxColumn colPeso;
        private DataGridViewTextBoxColumn colReporteLectura;
        private DataGridViewTextBoxColumn colReportePeso;
        private DataGridViewTextBoxColumn colReporteVolumen;
        private DataGridViewTextBoxColumn colReporteClasificacion;
        private DataGridViewTextBoxColumn colCodigoBarras;
        private DataGridViewTextBoxColumn colNombreArchivo;
    }
}
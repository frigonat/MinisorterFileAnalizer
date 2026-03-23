using MinisorterFileAnalizer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MinisorterFileAnalizer
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }


        private string ruta;
        private int cantidadDeArchivosProcesados;
        private int numeradorDeRegistros;
        private string[] archivosParaProcesar;
        private List<Bulto> bultos;
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            ruta = "C:\\Temp\\ftpcoe\\originales\\2025-04 - Abril";
            txtDirectorio.Text = ruta;

            bultos = new List<Bulto>();
            cantidadDeArchivosProcesados = 0;

            lblCantidadDeArchivos.Text = "0";
            lblCantidadDeRegistros.Text = "0";

            getFormSizeAndLocation();
        }

        private void txtDirectorio_Leave(object sender, EventArgs e)
        {
            archivosParaProcesar = Directory.GetFiles(txtDirectorio.Text);
            lblCantidadDeArchivosParaProcesar.Text = archivosParaProcesar.Count().ToString();
        }

        private void btnAnalizar_Click(object sender, EventArgs e)
        {
            bultos = new List<Bulto>();
            cantidadDeArchivosProcesados = 0;

            //GUI
            lblCantidadDeArchivos.Text = "0";
            lblCantidadDeRegistros.Text = "0";
            dgvBultos.Rows.Clear();

            numeradorDeRegistros = 0;

            foreach (string archivo in archivosParaProcesar)
            {
                procesarArchivo(archivo);
            }

        }



        private void procesarArchivo(string archivo)
        {
            cantidadDeArchivosProcesados++;

            object[] valores = new object[22];


            StreamReader sr = new StreamReader(archivo);
            while (sr.Peek() != -1)
            {
                numeradorDeRegistros++;

                string registro = sr.ReadLine();
                Bulto nuevoBulto = new Bulto
                {
                    tipoMensaje = registro.Substring(0, 3),
                    codigoPais = registro.Substring(3, 3),
                    plazaAndreani = registro.Substring(6, 3),
                    nSorter = registro.Substring(9, 1),
                    nLineaEntrada = registro.Substring(10, 2),
                    nSalidaPrevista = registro.Substring(12, 3),
                    nSalidaReal = registro.Substring(15, 3),
                    motivoDestino = registro.Substring(18, 2),
                    date = registro.Substring(20, 8),
                    time = registro.Substring(28, 8),
                    peso = registro.Substring(36, 7),
                    longitud = registro.Substring(43, 5),
                    ancho = registro.Substring(48, 5),
                    alto = registro.Substring(53, 5),
                    rVol = registro.Substring(58, 5),
                    reporteLectura = registro.Substring(63, 1),
                    reportePeso = registro.Substring(64, 1),
                    reporteVolumen = registro.Substring(65, 1),
                    reporteClasificacion = registro.Substring(66, 1),
                    codigoDeBarras = registro.Substring(67, 26),
                    nombreArchivo = Path.GetFileName(archivo)
                };
                bultos.Add(nuevoBulto);


                valores[0] = numeradorDeRegistros;
                valores[1] = nuevoBulto.tipoMensaje;
                valores[2] = nuevoBulto.codigoPais;
                valores[3] = nuevoBulto.plazaAndreani;
                valores[4] = nuevoBulto.nSorter;
                valores[5] = nuevoBulto.nLineaEntrada;
                valores[6] = nuevoBulto.nSalidaPrevista;
                valores[7] = nuevoBulto.nSalidaReal;
                valores[8] = nuevoBulto.motivoDestino;
                valores[9] = nuevoBulto.date;
                valores[10] = nuevoBulto.time;
                valores[11] = nuevoBulto.longitud;
                valores[12] = nuevoBulto.ancho;
                valores[13] = nuevoBulto.alto;
                valores[14] = nuevoBulto.rVol;
                valores[15] = nuevoBulto.peso;
                valores[16] = nuevoBulto.reporteLectura;
                valores[17] = nuevoBulto.reportePeso;
                valores[18] = nuevoBulto.reporteVolumen;
                valores[19] = nuevoBulto.reporteClasificacion;
                valores[20] = nuevoBulto.codigoDeBarras;
                valores[21] = nuevoBulto.nombreArchivo;
                dgvBultos.Rows.Add(valores);
            }

            lblCantidadDeRegistros.Text = bultos.Count().ToString();
            lblCantidadDeArchivos.Text = cantidadDeArchivosProcesados.ToString();



            //cargaEnProgreso = true;
            this.Cursor = Cursors.WaitCursor;
            this.Refresh();


            if (dgvBultos.Rows.Count > 0)
            {
                //tslRegistrosEncontrados.Text = dgvLocalidades.Rows.Count.ToString();
            }
            else
            {
                //tslRegistrosEncontrados.Text = "0";
            }

            //cargaEnProgreso = false;
            this.Cursor = Cursors.Default;
            this.Refresh();



            string nombreArchivo = Path.GetFileName(archivo);
            string extensionArchivo = Path.GetExtension(archivo);
            string rutaArchivo = Path.GetDirectoryName(archivo);
            // Aquí puedes agregar la lógica para analizar el archivo según tus necesidades
            // Por ejemplo, podrías verificar el tamaño del archivo, su fecha de creación, etc.
            // Ejemplo de análisis simple:
            FileInfo fileInfo = new FileInfo(archivo);
            long tamañoArchivo = fileInfo.Length;
            DateTime fechaCreacion = fileInfo.CreationTime;
            // Puedes mostrar esta información en la interfaz o guardarla en un log
            Console.WriteLine($"Archivo: {nombreArchivo}, Extensión: {extensionArchivo}, Tamaño: {tamañoArchivo} bytes, Fecha de Creación: {fechaCreacion}");






        }


        #region FormSize & Location

        private void updateFormSizeAndLocation()
        {
            tslFormSizeAndLocation.Text = "Size: " + this.Size.Width.ToString() + ", " + this.Size.Height.ToString();
            tslFormSizeAndLocation.Text += " | Location: " + this.Location.X.ToString() + ", " + this.Location.Y.ToString();
        }

        private void getFormSizeAndLocation()
        {
            FormDataResponse respuesta = FormData.GetFormSizeAndPosition(this.Name);
            if (respuesta.StatusCode == 200 && respuesta.Data != null)
            {
                this.Size = new Size(respuesta.Data.FormSize_Width, respuesta.Data.FormSize_Height);
                this.Location = new Point(respuesta.Data.FormLocation_X, respuesta.Data.FormLocation_Y);
                if (Enum.TryParse<FormWindowState>(respuesta.Data.FormWindowState, out FormWindowState windowState))
                {
                    this.WindowState = windowState;
                }
            }
        }

        #endregion

        private void frmPrincipal_Move(object sender, EventArgs e)
        {
            updateFormSizeAndLocation();

        }

        private void frmPrincipal_Resize(object sender, EventArgs e)
        {
            updateFormSizeAndLocation();
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormData.SaveFormSizeAndPosition(this);
        }
    }
}

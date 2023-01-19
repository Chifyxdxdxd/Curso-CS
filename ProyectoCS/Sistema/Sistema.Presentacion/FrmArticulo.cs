using Sistema.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.Presentacion
{
    public partial class FrmArticulo : Form
    {
        private string rutaOrigen, rutaDestino, directorio = "D:\\sistema\\";

        public FrmArticulo()
        {
            InitializeComponent();
        }

        private void Listar()
        {
            try
            {
                DgvListado.DataSource = NArticulo.Listar();
                this.Formato();
                this.Limpiar();
                LblTotal.Text = "Total Registros: " + Convert.ToString(DgvListado.Rows.Count);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Buscar()
        {
            try
            {
                DgvListado.DataSource = NArticulo.Buscar(BtnBuscar.Text);
                this.Formato();
                LblTotal.Text = "Total Registros: " + Convert.ToString(DgvListado.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Formato()
        {
            DgvListado.Columns[0].Visible = false;
            DgvListado.Columns[2].Visible = false;
            DgvListado.Columns[0].Width = 100;
            DgvListado.Columns[1].Width = 50;
            DgvListado.Columns[3].Width = 100;
            DgvListado.Columns[3].HeaderText = "Categoría";
            DgvListado.Columns[4].Width = 100;
            DgvListado.Columns[4].HeaderText = "Código";
            DgvListado.Columns[5].Width = 150;
            DgvListado.Columns[6].Width = 100;
            DgvListado.Columns[6].HeaderText = "Precio Venta";
            DgvListado.Columns[7].Width = 60;
            DgvListado.Columns[8].Width = 200;
            DgvListado.Columns[8].HeaderText = "Descripción";
            DgvListado.Columns[9].Width = 100;
            DgvListado.Columns[10].Width= 100;
        }

        private void Limpiar()
        {
            TxtDescripcion.Clear();
            TxtId.Clear();
            TxtNombre.Clear();
            TxtBuscar.Clear();
            BtnIngresar.Visible = true;
            BtnActualizar.Visible = false;
            ErrorIcono.Clear();

            DgvListado.Columns[0].Visible = false;
            BtnActivar.Visible = false;
            BtnDesactivar.Visible = false;
            BtnEliminar.Visible = false;
            ChbSelecionar.Checked = false;
        }

        private void MensajeError(string msg)
        {
            MessageBox.Show(msg, "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void MensajeOk(string msg)
        {
            MessageBox.Show(msg, "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void CargarCategoria()
        {
            try
            {
                CbxCategoria.DataSource = NCategoria.Seleccionar();
                CbxCategoria.ValueMember = "idcategoria";
                CbxCategoria.DisplayMember = "nombre";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void BtnCargarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "image files (*.jpg, *.jpeg, *.jfif, *.png) | *.jpg; *.jpeg; *.jfif; *.png";
            if (file.ShowDialog() == DialogResult.OK)
            {
                PicImagen.Image = Image.FromFile(file.FileName);
                TxtImagen.Text = file.FileName.Substring(file.FileName.LastIndexOf("\\")+1);
                this.rutaOrigen = file.FileName;
            }
        }

        private void BtnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                  BarcodeLib.Barcode codigo = new BarcodeLib.Barcode();
                codigo.IncludeLabel= true;
                PanelCodigo.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.CODE128,TxtCodigo.Text,Color.Black,Color.White,200,50);
                BtnGuardarCodigo.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Ingresa un código para el artículo");
            }
            
            
        }

        private void BtnGuardarCodigo_Click(object sender, EventArgs e)
        {
            Image imgFinal = (Image) PanelCodigo.BackgroundImage.Clone();
            SaveFileDialog dialogoGuardar = new SaveFileDialog();
            dialogoGuardar.AddExtension = true;
            dialogoGuardar.Filter = "Image PNG (*.png) | *.png";
            dialogoGuardar.FileName = Convert.ToString(TxtCodigo.Text);
            dialogoGuardar.ShowDialog();
            if (!String.IsNullOrEmpty(dialogoGuardar.FileName))
            {
                imgFinal.Save(dialogoGuardar.FileName, ImageFormat.Png);
            }
            imgFinal.Dispose();
        }

        private void FrmArticulo_Load(object sender, EventArgs e)
        {
            this.Listar();
            this.CargarCategoria();
        }
        
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            this.Buscar();
        }
    }
}

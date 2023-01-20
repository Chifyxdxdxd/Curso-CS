using Sistema.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
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
            TxtCodigo.Clear();
            PanelCodigo.BackgroundImage = null;
            BtnGuardarCodigo.Enabled= false;
            TxtImagen.Clear();
            TxtPrecioVenta.Clear();
            TxtStock.Clear();
            PicImagen.Image= null;
            BtnIngresar.Visible = true;
            BtnActualizar.Visible = false;
            ErrorIcono.Clear();
            rutaDestino = "";
            rutaOrigen = "";

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

        private void LblCategoria_Click(object sender, EventArgs e)
        {

        }

        private void TxtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                string respuesta = "";
                if (CbxCategoria.Text == String.Empty || TxtNombre.Text == String.Empty || TxtPrecioVenta.Text == String.Empty || TxtStock.Text == String.Empty)
                {
                    ErrorIcono.Clear();
                    this.MensajeError("Falta ingresar agunos datos, serán remarcados.");
                    if (CbxCategoria.Text == String.Empty) ErrorIcono.SetError(CbxCategoria, "Ingrese una categoría.");
                    if (TxtNombre.Text == String.Empty) ErrorIcono.SetError(TxtNombre, "Ingrese un nombre.");
                    if (TxtPrecioVenta.Text == String.Empty) ErrorIcono.SetError(TxtPrecioVenta, "Ingrese el precio de venta.");
                    if (TxtStock.Text == String.Empty) ErrorIcono.SetError(TxtStock, "Ingrese la cantidad en stock.");
                }
                else
                {
                    respuesta = NArticulo.Insertar(Convert.ToInt32(CbxCategoria.SelectedValue), TxtCodigo.Text.Trim(), TxtNombre.Text.Trim(), Convert.ToDecimal(TxtPrecioVenta.Text), Convert.ToInt32(TxtStock.Text), TxtDescripcion.Text.Trim(), TxtImagen.Text.Trim());
                    if (respuesta.Equals("OK"))
                    {
                        this.MensajeOk("Se insertó de forma correcta el registro");
                        if (TxtImagen.Text != String.Empty)
                        {
                            this.rutaDestino = this.directorio + TxtImagen.Text;
                            File.Copy(this.rutaOrigen, this.rutaDestino);
                        }
                        this.Limpiar();
                        this.Listar();
                    }
                    else
                    {
                        this.MensajeError(respuesta);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            string respuesta = "";
            if (TxtId.Text == String.Empty || CbxCategoria.Text == String.Empty || TxtNombre.Text == String.Empty || TxtPrecioVenta.Text == String.Empty || TxtStock.Text == String.Empty)
            {
                ErrorIcono.Clear();
                this.MensajeError("Falta ingresar agunos datos, serán remarcados.");
                if (CbxCategoria.Text == String.Empty) ErrorIcono.SetError(CbxCategoria, "Ingrese una categoría.");
                if (TxtNombre.Text == String.Empty) ErrorIcono.SetError(TxtNombre, "Ingrese un nombre.");
                if (TxtPrecioVenta.Text == String.Empty) ErrorIcono.SetError(TxtPrecioVenta, "Ingrese el precio de venta.");
                if (TxtStock.Text == String.Empty) ErrorIcono.SetError(TxtStock, "Ingrese la cantidad en stock.");
            }
            else
            {
                respuesta = NArticulo.Actualizar(Convert.ToInt32(TxtId.Text), Convert.ToInt32(CbxCategoria.SelectedValue), TxtCodigo.Text.Trim(),  TxtNombre.Text.Trim(), Convert.ToDecimal(TxtPrecioVenta.Text), Convert.ToInt32(TxtStock.Text), TxtDescripcion.Text.Trim(), TxtImagen.Text.Trim());
                if (respuesta.Equals("OK"))
                {
                    this.MensajeOk("Se Actualizó de forma correcta el registro");
                    if (TxtImagen.Text != string.Empty && this.rutaOrigen != String.Empty)
                    {
                        this.rutaDestino = this.directorio + TxtImagen.Text;
                        File.Copy(this.rutaOrigen, this.rutaDestino);
                    }
                    this.Limpiar();
                    this.Listar();
                }
                else
                {
                    this.MensajeError(respuesta);
                }
            }
        }

        private void DgvListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string imagen;
            try
            {
                this.Limpiar();
                BtnActualizar.Visible = true;
                BtnIngresar.Visible = false;
                TxtId.Text = Convert.ToString(DgvListado.CurrentRow.Cells["ID"].Value);
                CbxCategoria.SelectedValue = Convert.ToString(DgvListado.CurrentRow.Cells["idcategoria"].Value);
                TxtCodigo.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Codigo"].Value);
                TxtNombre.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Nombre"].Value);
                TxtPrecioVenta.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Precio_Venta"].Value);
                TxtStock.Text  = Convert.ToString(DgvListado.CurrentRow.Cells["Stock"].Value);
                TxtDescripcion.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Descripcion"].Value);
                imagen = Convert.ToString(DgvListado.CurrentRow.Cells["Imagen"].Value);
                if (imagen != string.Empty)
                {
                    PicImagen.Image = Image.FromFile(this.directorio + imagen);
                    TxtImagen.Text = imagen;
                }
                else
                {
                    PicImagen.Image = null;
                    TxtImagen.Text = "";
                }
                TabGeneral.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Selecione desde la celda nombre." + "| Error: " + ex.Message);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
            TabGeneral.SelectedIndex = 0;
        }

        private void ChbSelecionar_CheckedChanged(object sender, EventArgs e)
        {
            if (ChbSelecionar.Checked)
            {
                DgvListado.Columns[0].Visible = true;
                BtnActivar.Visible = true;
                BtnDesactivar.Visible = true;
                BtnEliminar.Visible = true;
            }
            else
            {
                DgvListado.Columns[0].Visible = false;
                BtnActivar.Visible = false;
                BtnDesactivar.Visible = false;
                BtnEliminar.Visible = false;
            }
        }

        private void DgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DgvListado.Columns["Seleccionar"].Index)
            {
                DataGridViewCheckBoxCell ChbEliminar = (DataGridViewCheckBoxCell)DgvListado.Rows[e.RowIndex].Cells["Seleccionar"];
                ChbEliminar.Value = !Convert.ToBoolean(ChbEliminar.Value);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult opcion;
                opcion = MessageBox.Show("Realmente deseas eliminar el(los) registro(s)?", "Sistema de ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (opcion == DialogResult.OK)
                {
                    string codigo, respuesta = "", imagen = "";
                    foreach (DataGridViewRow row in DgvListado.Rows) // revisa todas las lineas de la lista
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value)) //si esta marcada la celda hacer...
                        {
                            codigo = Convert.ToString(row.Cells[5].Value);
                            imagen = Convert.ToString(row.Cells[9].Value);
                            respuesta = NArticulo.Eliminar(codigo);

                            if (respuesta == "OK")
                            {
                                this.MensajeOk("Se eliminó el registro: " + Convert.ToString(row.Cells[9].Value));
                                File.Delete(this.directorio + imagen);
                            }
                            else
                            {
                                this.MensajeError(respuesta);
                            }
                        }
                    }
                }
                this.Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void BtnDesactivar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult opcion;
                opcion = MessageBox.Show("Realmente deseas desactivar el(los) registro(s)?", "Sistema de ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (opcion == DialogResult.OK)
                {
                    string codigo, respuesta = "";
                    foreach (DataGridViewRow row in DgvListado.Rows) // revisa todas las lineas de la lista
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value)) //si esta marcada la celda hacer...
                        {
                            codigo = Convert.ToString(row.Cells[5].Value);
                            respuesta = NArticulo.Desactivar(codigo);

                            if (respuesta == "OK")
                            {
                                this.MensajeOk("Se desactivó el registro: " + codigo);
                            }
                            else
                            {
                                this.MensajeError(respuesta);
                            }
                        }
                    }
                }
                this.Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void BtnActivar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult opcion;
                opcion = MessageBox.Show("Realmente deseas activar el(los) registro(s)?", "Sistema de ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (opcion == DialogResult.OK)
                {
                    string codigo, respuesta = "";
                    foreach (DataGridViewRow row in DgvListado.Rows) // revisa todas las lineas de la lista
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value)) //si esta marcada la celda hacer...
                        {
                            codigo = Convert.ToString(row.Cells[5].Value);
                            respuesta = NArticulo.Activar(codigo);

                            if (respuesta == "OK")
                            {
                                this.MensajeOk("Se desactivó el registro: " + codigo);
                            }
                            else
                            {
                                this.MensajeError(respuesta);
                            }
                        }
                    }
                }
                this.Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
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

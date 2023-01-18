namespace Sistema.Presentacion
{
    partial class FrmArticulo
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
            this.components = new System.ComponentModel.Container();
            this.ErrorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnIngresar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.LblDescripcion = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.CbxCategoria = new System.Windows.Forms.ComboBox();
            this.LblCategoria = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TabGeneral = new System.Windows.Forms.TabControl();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnDesactivar = new System.Windows.Forms.Button();
            this.BtnActivar = new System.Windows.Forms.Button();
            this.ChbSelecionar = new System.Windows.Forms.CheckBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.LblTotal = new System.Windows.Forms.Label();
            this.DgvListado = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcono)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.TabGeneral.SuspendLayout();
            this.TabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).BeginInit();
            this.SuspendLayout();
            // 
            // ErrorIcono
            // 
            this.ErrorIcono.ContainerControl = this;
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Location = new System.Drawing.Point(6, 372);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(96, 23);
            this.BtnActualizar.TabIndex = 8;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(322, 372);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(100, 20);
            this.TxtId.TabIndex = 7;
            this.TxtId.Visible = false;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(135, 210);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(5);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(202, 20);
            this.TxtNombre.TabIndex = 6;
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Location = new System.Drawing.Point(135, 240);
            this.TxtDescripcion.Margin = new System.Windows.Forms.Padding(5);
            this.TxtDescripcion.Multiline = true;
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(202, 93);
            this.TxtDescripcion.TabIndex = 5;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(210, 372);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(96, 23);
            this.BtnCancelar.TabIndex = 4;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.Location = new System.Drawing.Point(108, 373);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(96, 23);
            this.BtnIngresar.TabIndex = 3;
            this.BtnIngresar.Text = "Ingresar";
            this.BtnIngresar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "(*) lndica que el texto es obligatorio ";
            // 
            // LblDescripcion
            // 
            this.LblDescripcion.AutoSize = true;
            this.LblDescripcion.Location = new System.Drawing.Point(52, 243);
            this.LblDescripcion.Name = "LblDescripcion";
            this.LblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.LblDescripcion.TabIndex = 1;
            this.LblDescripcion.Text = "Descripción";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.CbxCategoria);
            this.tabPage2.Controls.Add(this.LblCategoria);
            this.tabPage2.Controls.Add(this.BtnActualizar);
            this.tabPage2.Controls.Add(this.TxtId);
            this.tabPage2.Controls.Add(this.TxtNombre);
            this.tabPage2.Controls.Add(this.TxtDescripcion);
            this.tabPage2.Controls.Add(this.BtnCancelar);
            this.tabPage2.Controls.Add(this.BtnIngresar);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.LblDescripcion);
            this.tabPage2.Controls.Add(this.LblNombre);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1050, 401);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // CbxCategoria
            // 
            this.CbxCategoria.FormattingEnabled = true;
            this.CbxCategoria.Location = new System.Drawing.Point(135, 85);
            this.CbxCategoria.Name = "CbxCategoria";
            this.CbxCategoria.Size = new System.Drawing.Size(202, 21);
            this.CbxCategoria.TabIndex = 10;
            // 
            // LblCategoria
            // 
            this.LblCategoria.AutoSize = true;
            this.LblCategoria.Location = new System.Drawing.Point(52, 88);
            this.LblCategoria.Name = "LblCategoria";
            this.LblCategoria.Size = new System.Drawing.Size(67, 13);
            this.LblCategoria.TabIndex = 9;
            this.LblCategoria.Text = "Categoría (*)";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(52, 213);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(57, 13);
            this.LblNombre.TabIndex = 0;
            this.LblNombre.Text = "Nombre (*)";
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            // 
            // TabGeneral
            // 
            this.TabGeneral.Controls.Add(this.TabPage1);
            this.TabGeneral.Controls.Add(this.tabPage2);
            this.TabGeneral.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.TabGeneral.Location = new System.Drawing.Point(12, 12);
            this.TabGeneral.Name = "TabGeneral";
            this.TabGeneral.SelectedIndex = 0;
            this.TabGeneral.Size = new System.Drawing.Size(1058, 427);
            this.TabGeneral.TabIndex = 1;
            // 
            // TabPage1
            // 
            this.TabPage1.Controls.Add(this.BtnEliminar);
            this.TabPage1.Controls.Add(this.BtnDesactivar);
            this.TabPage1.Controls.Add(this.BtnActivar);
            this.TabPage1.Controls.Add(this.ChbSelecionar);
            this.TabPage1.Controls.Add(this.BtnBuscar);
            this.TabPage1.Controls.Add(this.TxtBuscar);
            this.TabPage1.Controls.Add(this.LblTotal);
            this.TabPage1.Controls.Add(this.DgvListado);
            this.TabPage1.Location = new System.Drawing.Point(4, 22);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage1.Size = new System.Drawing.Size(1050, 401);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "Listado";
            this.TabPage1.UseVisualStyleBackColor = true;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(487, 364);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(5);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(127, 23);
            this.BtnEliminar.TabIndex = 7;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // BtnDesactivar
            // 
            this.BtnDesactivar.Location = new System.Drawing.Point(350, 364);
            this.BtnDesactivar.Margin = new System.Windows.Forms.Padding(5);
            this.BtnDesactivar.Name = "BtnDesactivar";
            this.BtnDesactivar.Size = new System.Drawing.Size(127, 23);
            this.BtnDesactivar.TabIndex = 6;
            this.BtnDesactivar.Text = "Desactivar";
            this.BtnDesactivar.UseVisualStyleBackColor = true;
            // 
            // BtnActivar
            // 
            this.BtnActivar.Location = new System.Drawing.Point(213, 364);
            this.BtnActivar.Margin = new System.Windows.Forms.Padding(5);
            this.BtnActivar.Name = "BtnActivar";
            this.BtnActivar.Size = new System.Drawing.Size(127, 23);
            this.BtnActivar.TabIndex = 5;
            this.BtnActivar.Text = "Activar";
            this.BtnActivar.UseVisualStyleBackColor = true;
            // 
            // ChbSelecionar
            // 
            this.ChbSelecionar.AutoSize = true;
            this.ChbSelecionar.Location = new System.Drawing.Point(36, 364);
            this.ChbSelecionar.Name = "ChbSelecionar";
            this.ChbSelecionar.Size = new System.Drawing.Size(76, 17);
            this.ChbSelecionar.TabIndex = 4;
            this.ChbSelecionar.Text = "Selecionar";
            this.ChbSelecionar.UseVisualStyleBackColor = true;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(382, 29);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(75, 23);
            this.BtnBuscar.TabIndex = 3;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(7, 32);
            this.TxtBuscar.MaxLength = 350;
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(333, 20);
            this.TxtBuscar.TabIndex = 2;
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Location = new System.Drawing.Point(741, 369);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(37, 13);
            this.LblTotal.TabIndex = 1;
            this.LblTotal.Text = "Total: ";
            // 
            // DgvListado
            // 
            this.DgvListado.AllowUserToAddRows = false;
            this.DgvListado.AllowUserToDeleteRows = false;
            this.DgvListado.AllowUserToOrderColumns = true;
            this.DgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            this.DgvListado.Location = new System.Drawing.Point(6, 58);
            this.DgvListado.Name = "DgvListado";
            this.DgvListado.ReadOnly = true;
            this.DgvListado.Size = new System.Drawing.Size(1038, 291);
            this.DgvListado.TabIndex = 0;
            // 
            // FrmArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 442);
            this.Controls.Add(this.TabGeneral);
            this.Name = "FrmArticulo";
            this.Text = "Artículos";
            this.Load += new System.EventHandler(this.FrmArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcono)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.TabGeneral.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.TabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider ErrorIcono;
        private System.Windows.Forms.TabControl TabGeneral;
        private System.Windows.Forms.TabPage TabPage1;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnDesactivar;
        private System.Windows.Forms.Button BtnActivar;
        private System.Windows.Forms.CheckBox ChbSelecionar;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.DataGridView DgvListado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnIngresar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblDescripcion;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblCategoria;
        private System.Windows.Forms.ComboBox CbxCategoria;
    }
}
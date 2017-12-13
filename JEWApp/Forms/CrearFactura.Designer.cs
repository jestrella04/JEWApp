namespace JEWApp.Forms
{
    partial class CrearFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearFactura));
            this.gbCrearProducto = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvFacturaDetalle = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbFacturaDetalleProducto = new System.Windows.Forms.ComboBox();
            this.cmbFacturaDetalleVehiculo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFacturaDetalleCantidad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFacturaDetallePrecio = new System.Windows.Forms.TextBox();
            this.txtFacturaDescripcion = new System.Windows.Forms.TextBox();
            this.btnFacturaDetalleAdd = new System.Windows.Forms.Button();
            this.colProdId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProdNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVehiculoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblfacturaDetalleMsg = new System.Windows.Forms.Label();
            this.lblResultadoMsg = new System.Windows.Forms.Label();
            this.gbCrearProducto.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturaDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCrearProducto
            // 
            this.gbCrearProducto.Controls.Add(this.txtFacturaDescripcion);
            this.gbCrearProducto.Controls.Add(this.label2);
            this.gbCrearProducto.Controls.Add(this.label3);
            this.gbCrearProducto.Controls.Add(this.cmbCliente);
            this.gbCrearProducto.Location = new System.Drawing.Point(10, 86);
            this.gbCrearProducto.Name = "gbCrearProducto";
            this.gbCrearProducto.Size = new System.Drawing.Size(1016, 165);
            this.gbCrearProducto.TabIndex = 15;
            this.gbCrearProducto.TabStop = false;
            this.gbCrearProducto.Text = "Cabecera";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(104, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(66, 67);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descripción:";
            // 
            // cmbCliente
            // 
            this.cmbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(188, 22);
            this.cmbCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(280, 28);
            this.cmbCliente.TabIndex = 9;
            // 
            // btnCrear
            // 
            this.btnCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.Location = new System.Drawing.Point(198, 562);
            this.btnCrear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(90, 49);
            this.btnCrear.TabIndex = 4;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(293, 562);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(90, 49);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(387, 562);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 49);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 31);
            this.label1.TabIndex = 14;
            this.label1.Text = "Crear Factura";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblfacturaDetalleMsg);
            this.groupBox1.Controls.Add(this.btnFacturaDetalleAdd);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtFacturaDetallePrecio);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtFacturaDetalleCantidad);
            this.groupBox1.Controls.Add(this.cmbFacturaDetalleVehiculo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmbFacturaDetalleProducto);
            this.groupBox1.Controls.Add(this.dgvFacturaDetalle);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 270);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1014, 275);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle";
            // 
            // dgvFacturaDetalle
            // 
            this.dgvFacturaDetalle.AllowUserToAddRows = false;
            this.dgvFacturaDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacturaDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProdId,
            this.colProdNombre,
            this.colVehiculoId,
            this.colCantidad,
            this.colPrecio});
            this.dgvFacturaDetalle.Location = new System.Drawing.Point(520, 47);
            this.dgvFacturaDetalle.Name = "dgvFacturaDetalle";
            this.dgvFacturaDetalle.Size = new System.Drawing.Size(474, 201);
            this.dgvFacturaDetalle.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(86, 55);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Producto:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // cmbFacturaDetalleProducto
            // 
            this.cmbFacturaDetalleProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFacturaDetalleProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFacturaDetalleProducto.FormattingEnabled = true;
            this.cmbFacturaDetalleProducto.Location = new System.Drawing.Point(188, 47);
            this.cmbFacturaDetalleProducto.Margin = new System.Windows.Forms.Padding(2);
            this.cmbFacturaDetalleProducto.Name = "cmbFacturaDetalleProducto";
            this.cmbFacturaDetalleProducto.Size = new System.Drawing.Size(278, 28);
            this.cmbFacturaDetalleProducto.TabIndex = 12;
            this.cmbFacturaDetalleProducto.SelectedIndexChanged += new System.EventHandler(this.cmbFacturaDetalleProducto_SelectedIndexChanged);
            // 
            // cmbFacturaDetalleVehiculo
            // 
            this.cmbFacturaDetalleVehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFacturaDetalleVehiculo.Enabled = false;
            this.cmbFacturaDetalleVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFacturaDetalleVehiculo.FormattingEnabled = true;
            this.cmbFacturaDetalleVehiculo.Location = new System.Drawing.Point(188, 89);
            this.cmbFacturaDetalleVehiculo.Margin = new System.Windows.Forms.Padding(2);
            this.cmbFacturaDetalleVehiculo.Name = "cmbFacturaDetalleVehiculo";
            this.cmbFacturaDetalleVehiculo.Size = new System.Drawing.Size(278, 28);
            this.cmbFacturaDetalleVehiculo.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(89, 97);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Vehículo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(86, 138);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 20);
            this.label7.TabIndex = 26;
            this.label7.Text = "Cantidad:";
            // 
            // txtFacturaDetalleCantidad
            // 
            this.txtFacturaDetalleCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFacturaDetalleCantidad.Location = new System.Drawing.Point(186, 132);
            this.txtFacturaDetalleCantidad.Margin = new System.Windows.Forms.Padding(2);
            this.txtFacturaDetalleCantidad.Name = "txtFacturaDetalleCantidad";
            this.txtFacturaDetalleCantidad.Size = new System.Drawing.Size(280, 26);
            this.txtFacturaDetalleCantidad.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(102, 178);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 20);
            this.label8.TabIndex = 28;
            this.label8.Text = "Precio:";
            // 
            // txtFacturaDetallePrecio
            // 
            this.txtFacturaDetallePrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFacturaDetallePrecio.Location = new System.Drawing.Point(186, 172);
            this.txtFacturaDetallePrecio.Margin = new System.Windows.Forms.Padding(2);
            this.txtFacturaDetallePrecio.Name = "txtFacturaDetallePrecio";
            this.txtFacturaDetallePrecio.Size = new System.Drawing.Size(280, 26);
            this.txtFacturaDetallePrecio.TabIndex = 29;
            // 
            // txtFacturaDescripcion
            // 
            this.txtFacturaDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFacturaDescripcion.Location = new System.Drawing.Point(188, 64);
            this.txtFacturaDescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.txtFacturaDescripcion.Multiline = true;
            this.txtFacturaDescripcion.Name = "txtFacturaDescripcion";
            this.txtFacturaDescripcion.Size = new System.Drawing.Size(280, 84);
            this.txtFacturaDescripcion.TabIndex = 30;
            // 
            // btnFacturaDetalleAdd
            // 
            this.btnFacturaDetalleAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturaDetalleAdd.Location = new System.Drawing.Point(186, 213);
            this.btnFacturaDetalleAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnFacturaDetalleAdd.Name = "btnFacturaDetalleAdd";
            this.btnFacturaDetalleAdd.Size = new System.Drawing.Size(280, 35);
            this.btnFacturaDetalleAdd.TabIndex = 38;
            this.btnFacturaDetalleAdd.Text = "Agregar Producto";
            this.btnFacturaDetalleAdd.UseVisualStyleBackColor = true;
            this.btnFacturaDetalleAdd.Click += new System.EventHandler(this.btnFacturaDetalleAdd_Click);
            // 
            // colProdId
            // 
            this.colProdId.HeaderText = "Prod ID";
            this.colProdId.Name = "colProdId";
            this.colProdId.ReadOnly = true;
            this.colProdId.Visible = false;
            // 
            // colProdNombre
            // 
            this.colProdNombre.HeaderText = "Producto";
            this.colProdNombre.Name = "colProdNombre";
            this.colProdNombre.ReadOnly = true;
            // 
            // colVehiculoId
            // 
            this.colVehiculoId.HeaderText = "Vehiculo ID";
            this.colVehiculoId.Name = "colVehiculoId";
            this.colVehiculoId.ReadOnly = true;
            this.colVehiculoId.Visible = false;
            // 
            // colCantidad
            // 
            this.colCantidad.HeaderText = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            // 
            // colPrecio
            // 
            this.colPrecio.HeaderText = "Precio";
            this.colPrecio.Name = "colPrecio";
            // 
            // lblfacturaDetalleMsg
            // 
            this.lblfacturaDetalleMsg.AutoSize = true;
            this.lblfacturaDetalleMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfacturaDetalleMsg.Location = new System.Drawing.Point(185, 16);
            this.lblfacturaDetalleMsg.Name = "lblfacturaDetalleMsg";
            this.lblfacturaDetalleMsg.Size = new System.Drawing.Size(154, 16);
            this.lblfacturaDetalleMsg.TabIndex = 39;
            this.lblfacturaDetalleMsg.Text = "Aquí va la respuesta.";
            this.lblfacturaDetalleMsg.Visible = false;
            // 
            // lblResultadoMsg
            // 
            this.lblResultadoMsg.AutoSize = true;
            this.lblResultadoMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoMsg.Location = new System.Drawing.Point(344, 43);
            this.lblResultadoMsg.Name = "lblResultadoMsg";
            this.lblResultadoMsg.Size = new System.Drawing.Size(177, 20);
            this.lblResultadoMsg.TabIndex = 39;
            this.lblResultadoMsg.Text = "Aquí va la respuesta.";
            this.lblResultadoMsg.Visible = false;
            // 
            // CrearFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 644);
            this.Controls.Add(this.lblResultadoMsg);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbCrearProducto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCrear);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CrearFactura";
            this.Text = "CrearFactura";
            this.Load += new System.EventHandler(this.CrearFactura_Load);
            this.gbCrearProducto.ResumeLayout(false);
            this.gbCrearProducto.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturaDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCrearProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvFacturaDetalle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmbFacturaDetalleVehiculo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbFacturaDetalleProducto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFacturaDetallePrecio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFacturaDetalleCantidad;
        private System.Windows.Forms.TextBox txtFacturaDescripcion;
        private System.Windows.Forms.Button btnFacturaDetalleAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProdId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProdNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVehiculoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecio;
        private System.Windows.Forms.Label lblfacturaDetalleMsg;
        private System.Windows.Forms.Label lblResultadoMsg;
    }
}
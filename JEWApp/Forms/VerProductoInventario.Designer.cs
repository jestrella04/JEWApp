namespace JEWApp.Forms
{
    partial class VerProductoInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerProductoInventario));
            this.dgvProductoInventario = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbInventarioProducto = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInventarioCantidadDisponible = new System.Windows.Forms.TextBox();
            this.txtInventarioCantidadMinima = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAgregarInventario = new System.Windows.Forms.Button();
            this.txtInventarioPrecio = new System.Windows.Forms.TextBox();
            this.lblResultadoMsg = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductoInventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProductoInventario
            // 
            this.dgvProductoInventario.AllowUserToAddRows = false;
            this.dgvProductoInventario.AllowUserToDeleteRows = false;
            this.dgvProductoInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductoInventario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvProductoInventario.Location = new System.Drawing.Point(9, 93);
            this.dgvProductoInventario.Margin = new System.Windows.Forms.Padding(2);
            this.dgvProductoInventario.Name = "dgvProductoInventario";
            this.dgvProductoInventario.ReadOnly = true;
            this.dgvProductoInventario.RowTemplate.Height = 24;
            this.dgvProductoInventario.Size = new System.Drawing.Size(1018, 408);
            this.dgvProductoInventario.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Inventario de Productos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(28, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // cmbInventarioProducto
            // 
            this.cmbInventarioProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInventarioProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbInventarioProducto.FormattingEnabled = true;
            this.cmbInventarioProducto.Location = new System.Drawing.Point(19, 50);
            this.cmbInventarioProducto.Margin = new System.Windows.Forms.Padding(2);
            this.cmbInventarioProducto.Name = "cmbInventarioProducto";
            this.cmbInventarioProducto.Size = new System.Drawing.Size(200, 28);
            this.cmbInventarioProducto.TabIndex = 10;
            this.cmbInventarioProducto.SelectionChangeCommitted += new System.EventHandler(this.cmbInventarioProducto_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Producto:";
            // 
            // txtInventarioCantidadDisponible
            // 
            this.txtInventarioCantidadDisponible.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInventarioCantidadDisponible.Location = new System.Drawing.Point(241, 52);
            this.txtInventarioCantidadDisponible.Margin = new System.Windows.Forms.Padding(2);
            this.txtInventarioCantidadDisponible.Name = "txtInventarioCantidadDisponible";
            this.txtInventarioCantidadDisponible.Size = new System.Drawing.Size(200, 26);
            this.txtInventarioCantidadDisponible.TabIndex = 28;
            // 
            // txtInventarioCantidadMinima
            // 
            this.txtInventarioCantidadMinima.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInventarioCantidadMinima.Location = new System.Drawing.Point(463, 52);
            this.txtInventarioCantidadMinima.Margin = new System.Windows.Forms.Padding(2);
            this.txtInventarioCantidadMinima.Name = "txtInventarioCantidadMinima";
            this.txtInventarioCantidadMinima.Size = new System.Drawing.Size(200, 26);
            this.txtInventarioCantidadMinima.TabIndex = 29;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnAgregarInventario);
            this.groupBox1.Controls.Add(this.txtInventarioPrecio);
            this.groupBox1.Controls.Add(this.cmbInventarioProducto);
            this.groupBox1.Controls.Add(this.txtInventarioCantidadMinima);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtInventarioCantidadDisponible);
            this.groupBox1.Location = new System.Drawing.Point(9, 519);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1018, 96);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Insertar o Actualizar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(682, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 34;
            this.label5.Text = "Precio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(460, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 16);
            this.label4.TabIndex = 33;
            this.label4.Text = "Cantidad mínima:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(238, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 16);
            this.label3.TabIndex = 32;
            this.label3.Text = "Cantidad disponible:";
            // 
            // btnAgregarInventario
            // 
            this.btnAgregarInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarInventario.Location = new System.Drawing.Point(907, 51);
            this.btnAgregarInventario.Name = "btnAgregarInventario";
            this.btnAgregarInventario.Size = new System.Drawing.Size(90, 27);
            this.btnAgregarInventario.TabIndex = 31;
            this.btnAgregarInventario.Text = "Actualizar";
            this.btnAgregarInventario.UseVisualStyleBackColor = true;
            this.btnAgregarInventario.Click += new System.EventHandler(this.btnAgregarInventario_Click);
            // 
            // txtInventarioPrecio
            // 
            this.txtInventarioPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInventarioPrecio.Location = new System.Drawing.Point(685, 52);
            this.txtInventarioPrecio.Margin = new System.Windows.Forms.Padding(2);
            this.txtInventarioPrecio.Name = "txtInventarioPrecio";
            this.txtInventarioPrecio.Size = new System.Drawing.Size(200, 26);
            this.txtInventarioPrecio.TabIndex = 30;
            // 
            // lblResultadoMsg
            // 
            this.lblResultadoMsg.AutoSize = true;
            this.lblResultadoMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoMsg.Location = new System.Drawing.Point(468, 49);
            this.lblResultadoMsg.Name = "lblResultadoMsg";
            this.lblResultadoMsg.Size = new System.Drawing.Size(177, 20);
            this.lblResultadoMsg.TabIndex = 40;
            this.lblResultadoMsg.Text = "Aquí va la respuesta.";
            this.lblResultadoMsg.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID Producto";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre Producto";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Cantidad Disponible";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Cantidad Mínima";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Precio";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 150;
            // 
            // VerProductoInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 630);
            this.Controls.Add(this.lblResultadoMsg);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvProductoInventario);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "VerProductoInventario";
            this.Text = "VerInventario";
            this.Load += new System.EventHandler(this.VerProductoInventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductoInventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProductoInventario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmbInventarioProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInventarioCantidadDisponible;
        private System.Windows.Forms.TextBox txtInventarioCantidadMinima;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAgregarInventario;
        private System.Windows.Forms.TextBox txtInventarioPrecio;
        private System.Windows.Forms.Label lblResultadoMsg;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}
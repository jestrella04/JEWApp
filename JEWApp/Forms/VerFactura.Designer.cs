namespace JEWApp.Forms
{
    partial class VerFactura
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
            this.gbCrearProducto = new System.Windows.Forms.GroupBox();
            this.cmbEmpleado = new System.Windows.Forms.ComboBox();
            this.cmbVehiculo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbCrearProducto.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCrearProducto
            // 
            this.gbCrearProducto.Controls.Add(this.cmbEmpleado);
            this.gbCrearProducto.Controls.Add(this.cmbVehiculo);
            this.gbCrearProducto.Controls.Add(this.label2);
            this.gbCrearProducto.Controls.Add(this.label3);
            this.gbCrearProducto.Controls.Add(this.cmbCliente);
            this.gbCrearProducto.Controls.Add(this.label4);
            this.gbCrearProducto.Location = new System.Drawing.Point(13, 115);
            this.gbCrearProducto.Margin = new System.Windows.Forms.Padding(4);
            this.gbCrearProducto.Name = "gbCrearProducto";
            this.gbCrearProducto.Padding = new System.Windows.Forms.Padding(4);
            this.gbCrearProducto.Size = new System.Drawing.Size(1355, 561);
            this.gbCrearProducto.TabIndex = 17;
            this.gbCrearProducto.TabStop = false;
            // 
            // cmbEmpleado
            // 
            this.cmbEmpleado.Enabled = false;
            this.cmbEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEmpleado.FormattingEnabled = true;
            this.cmbEmpleado.Location = new System.Drawing.Point(315, 150);
            this.cmbEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbEmpleado.Name = "cmbEmpleado";
            this.cmbEmpleado.Size = new System.Drawing.Size(372, 33);
            this.cmbEmpleado.TabIndex = 11;
            // 
            // cmbVehiculo
            // 
            this.cmbVehiculo.Enabled = false;
            this.cmbVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbVehiculo.FormattingEnabled = true;
            this.cmbVehiculo.Location = new System.Drawing.Point(315, 100);
            this.cmbVehiculo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbVehiculo.Name = "cmbVehiculo";
            this.cmbVehiculo.Size = new System.Drawing.Size(372, 33);
            this.cmbVehiculo.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(201, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(185, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vehiculo:";
            // 
            // cmbCliente
            // 
            this.cmbCliente.Enabled = false;
            this.cmbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(315, 50);
            this.cmbCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(372, 33);
            this.cmbCliente.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(173, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Empleado:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 39);
            this.label1.TabIndex = 16;
            this.label1.Text = "Ver Factura";
            // 
            // VerFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1381, 689);
            this.Controls.Add(this.gbCrearProducto);
            this.Controls.Add(this.label1);
            this.Name = "VerFactura";
            this.Text = "VerFactura";
            this.gbCrearProducto.ResumeLayout(false);
            this.gbCrearProducto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCrearProducto;
        private System.Windows.Forms.ComboBox cmbEmpleado;
        private System.Windows.Forms.ComboBox cmbVehiculo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}
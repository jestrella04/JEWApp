namespace JEWApp.Forms
{
    partial class VerVehiculoLista
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
            this.dgwVehiculos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwVehiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwVehiculos
            // 
            this.dgwVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwVehiculos.Location = new System.Drawing.Point(12, 115);
            this.dgwVehiculos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgwVehiculos.Name = "dgwVehiculos";
            this.dgwVehiculos.RowTemplate.Height = 24;
            this.dgwVehiculos.Size = new System.Drawing.Size(1357, 528);
            this.dgwVehiculos.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Listado de Vehiculos";
            // 
            // VerVehiculosLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1381, 654);
            this.Controls.Add(this.dgwVehiculos);
            this.Controls.Add(this.label1);
            this.Name = "VerVehiculosLista";
            this.Text = "VerVehiculosLista";
            ((System.ComponentModel.ISupportInitialize)(this.dgwVehiculos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwVehiculos;
        private System.Windows.Forms.Label label1;
    }
}
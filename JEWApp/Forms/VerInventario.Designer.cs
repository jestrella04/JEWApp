namespace JEWApp.Forms
{
    partial class VerInventario
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
            this.dgwInventarioProductos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwInventarioProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwInventarioProductos
            // 
            this.dgwInventarioProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwInventarioProductos.Location = new System.Drawing.Point(12, 115);
            this.dgwInventarioProductos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgwInventarioProductos.Name = "dgwInventarioProductos";
            this.dgwInventarioProductos.RowTemplate.Height = 24;
            this.dgwInventarioProductos.Size = new System.Drawing.Size(1357, 526);
            this.dgwInventarioProductos.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "Inventario de Productos";
            // 
            // VerInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1381, 654);
            this.Controls.Add(this.dgwInventarioProductos);
            this.Controls.Add(this.label1);
            this.Name = "VerInventario";
            this.Text = "VerInventario";
            ((System.ComponentModel.ISupportInitialize)(this.dgwInventarioProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwInventarioProductos;
        private System.Windows.Forms.Label label1;
    }
}
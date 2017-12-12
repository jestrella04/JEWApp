namespace JEWApp.Forms
{
    partial class VerFacturasLista
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
            this.dgwFacturas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwFacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwFacturas
            // 
            this.dgwFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwFacturas.Location = new System.Drawing.Point(12, 115);
            this.dgwFacturas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgwFacturas.Name = "dgwFacturas";
            this.dgwFacturas.RowTemplate.Height = 24;
            this.dgwFacturas.Size = new System.Drawing.Size(1357, 528);
            this.dgwFacturas.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "Listado de Facturas";
            // 
            // VerFacturasLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1381, 654);
            this.Controls.Add(this.dgwFacturas);
            this.Controls.Add(this.label1);
            this.Name = "VerFacturasLista";
            this.Text = "VerFacturasLista";
            ((System.ComponentModel.ISupportInitialize)(this.dgwFacturas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwFacturas;
        private System.Windows.Forms.Label label1;
    }
}
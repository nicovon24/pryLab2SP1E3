
namespace pryVonLab2BibliotecaSP1
{
    partial class frmConsulta
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
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.dgvCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCodigoEditorial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCodigoAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCodigoDistrib = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvCodigo,
            this.dgvNombre,
            this.dgvCodigoEditorial,
            this.dgvCodigoAutor,
            this.dgvCodigoDistrib});
            this.dataGridView4.Location = new System.Drawing.Point(-3, -1);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(547, 455);
            this.dataGridView4.TabIndex = 3;
            this.dataGridView4.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView4_CellContentClick);
            // 
            // dgvCodigo
            // 
            this.dgvCodigo.HeaderText = "Codigo";
            this.dgvCodigo.Name = "dgvCodigo";
            // 
            // dgvNombre
            // 
            this.dgvNombre.HeaderText = "Nombre";
            this.dgvNombre.Name = "dgvNombre";
            // 
            // dgvCodigoEditorial
            // 
            this.dgvCodigoEditorial.HeaderText = "Editorial";
            this.dgvCodigoEditorial.Name = "dgvCodigoEditorial";
            // 
            // dgvCodigoAutor
            // 
            this.dgvCodigoAutor.HeaderText = "Codigo Autor";
            this.dgvCodigoAutor.Name = "dgvCodigoAutor";
            // 
            // dgvCodigoDistrib
            // 
            this.dgvCodigoDistrib.HeaderText = "Codigo Distribuidor";
            this.dgvCodigoDistrib.Name = "dgvCodigoDistrib";
            // 
            // frmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 450);
            this.Controls.Add(this.dataGridView4);
            this.Name = "frmConsulta";
            this.Text = "Consulta";
            this.Load += new System.EventHandler(this.frmConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCodigoEditorial;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCodigoAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCodigoDistrib;
    }
}
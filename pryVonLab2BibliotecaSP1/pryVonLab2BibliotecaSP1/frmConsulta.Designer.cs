
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
            this.grdData = new System.Windows.Forms.DataGridView();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.dgvCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCodigoEditorial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCodigoAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCodigoDistrib = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
            this.SuspendLayout();
            // 
            // grdData
            // 
            this.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvCodigo,
            this.dgvNombre,
            this.dgvCodigoEditorial,
            this.dgvCodigoAutor,
            this.dgvCodigoDistrib});
            this.grdData.Location = new System.Drawing.Point(16, 25);
            this.grdData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grdData.Name = "grdData";
            this.grdData.RowHeadersWidth = 51;
            this.grdData.Size = new System.Drawing.Size(901, 525);
            this.grdData.TabIndex = 3;
            this.grdData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView4_CellContentClick);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(948, 25);
            this.btnPrev.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(83, 32);
            this.btnPrev.TabIndex = 4;
            this.btnPrev.Text = "Previous";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(948, 75);
            this.btnNext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(83, 32);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(948, 130);
            this.btnShowAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(83, 32);
            this.btnShowAll.TabIndex = 6;
            this.btnShowAll.Text = "Show all";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(948, 181);
            this.btnClearAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(83, 32);
            this.btnClearAll.TabIndex = 7;
            this.btnClearAll.Text = "Clear all";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // dgvCodigo
            // 
            this.dgvCodigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvCodigo.HeaderText = "Codigo";
            this.dgvCodigo.MinimumWidth = 6;
            this.dgvCodigo.Name = "dgvCodigo";
            this.dgvCodigo.Width = 80;
            // 
            // dgvNombre
            // 
            this.dgvNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvNombre.HeaderText = "Nombre";
            this.dgvNombre.MinimumWidth = 6;
            this.dgvNombre.Name = "dgvNombre";
            this.dgvNombre.Width = 85;
            // 
            // dgvCodigoEditorial
            // 
            this.dgvCodigoEditorial.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvCodigoEditorial.HeaderText = "Editorial";
            this.dgvCodigoEditorial.MinimumWidth = 6;
            this.dgvCodigoEditorial.Name = "dgvCodigoEditorial";
            this.dgvCodigoEditorial.Width = 85;
            // 
            // dgvCodigoAutor
            // 
            this.dgvCodigoAutor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvCodigoAutor.HeaderText = "Codigo Autor";
            this.dgvCodigoAutor.MinimumWidth = 6;
            this.dgvCodigoAutor.Name = "dgvCodigoAutor";
            this.dgvCodigoAutor.Width = 114;
            // 
            // dgvCodigoDistrib
            // 
            this.dgvCodigoDistrib.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvCodigoDistrib.HeaderText = "Codigo Distribuidor";
            this.dgvCodigoDistrib.MinimumWidth = 6;
            this.dgvCodigoDistrib.Name = "dgvCodigoDistrib";
            this.dgvCodigoDistrib.Width = 138;
            // 
            // frmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 563);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.grdData);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmConsulta";
            this.Text = "Consulta";
            this.Load += new System.EventHandler(this.frmConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdData;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCodigoEditorial;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCodigoAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCodigoDistrib;
    }
}
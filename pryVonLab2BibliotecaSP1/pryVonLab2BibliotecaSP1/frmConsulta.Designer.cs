﻿
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
            this.dgvCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCodigoEditorial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCodigoAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCodigoDistrib = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
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
            this.grdData.Location = new System.Drawing.Point(29, 20);
            this.grdData.Name = "grdData";
            this.grdData.RowHeadersWidth = 51;
            this.grdData.Size = new System.Drawing.Size(514, 327);
            this.grdData.TabIndex = 3;
            this.grdData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView4_CellContentClick);
            // 
            // dgvCodigo
            // 
            this.dgvCodigo.HeaderText = "Codigo";
            this.dgvCodigo.MinimumWidth = 6;
            this.dgvCodigo.Name = "dgvCodigo";
            this.dgvCodigo.Width = 125;
            // 
            // dgvNombre
            // 
            this.dgvNombre.HeaderText = "Nombre";
            this.dgvNombre.MinimumWidth = 6;
            this.dgvNombre.Name = "dgvNombre";
            this.dgvNombre.Width = 125;
            // 
            // dgvCodigoEditorial
            // 
            this.dgvCodigoEditorial.HeaderText = "Editorial";
            this.dgvCodigoEditorial.MinimumWidth = 6;
            this.dgvCodigoEditorial.Name = "dgvCodigoEditorial";
            this.dgvCodigoEditorial.Width = 125;
            // 
            // dgvCodigoAutor
            // 
            this.dgvCodigoAutor.HeaderText = "Codigo Autor";
            this.dgvCodigoAutor.MinimumWidth = 6;
            this.dgvCodigoAutor.Name = "dgvCodigoAutor";
            this.dgvCodigoAutor.Width = 125;
            // 
            // dgvCodigoDistrib
            // 
            this.dgvCodigoDistrib.HeaderText = "Codigo Distribuidor";
            this.dgvCodigoDistrib.MinimumWidth = 6;
            this.dgvCodigoDistrib.Name = "dgvCodigoDistrib";
            this.dgvCodigoDistrib.Width = 125;
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(482, 366);
            this.btnPrev.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(62, 26);
            this.btnPrev.TabIndex = 4;
            this.btnPrev.Text = "Previous";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(482, 407);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(62, 26);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(394, 366);
            this.btnShowAll.Margin = new System.Windows.Forms.Padding(2);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(62, 26);
            this.btnShowAll.TabIndex = 6;
            this.btnShowAll.Text = "Show all";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // frmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 488);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.grdData);
            this.Name = "frmConsulta";
            this.Text = "Consulta";
            this.Load += new System.EventHandler(this.frmConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdData;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCodigoEditorial;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCodigoAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCodigoDistrib;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnShowAll;
    }
}
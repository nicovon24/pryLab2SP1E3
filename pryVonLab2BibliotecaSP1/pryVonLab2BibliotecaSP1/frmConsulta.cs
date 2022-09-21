using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryVonLab2BibliotecaSP1
{
    public partial class frmConsulta : Form
    {
        string[,] matrizData = new string[21,5];
        int rowMatriz = 0; //this variable will allow us to add rows to the matrix
        int rowGrd = 0; //will add +1 or -1 row each time we make a query
        public frmConsulta()
        {
            InitializeComponent();
            StreamReader sr = new StreamReader("./LIBRO.txt", true);
            char separador = Convert.ToChar(",");
            while (!sr.EndOfStream)
            {
                //---
                //will store the data from the file
                string[] arrDataFile = sr.ReadLine().Split(separador);
            
                //---
                //editorial, we want to convert its id into the name of the distribuitor
                int editorial = Convert.ToInt32(arrDataFile[2]);
                string editorialString = "";

                switch (editorial)
                {
                    case 1: editorialString = "Prentice Hall"; break;
                    case 2: editorialString = "Cuspide"; break;
                    case 3: editorialString = "Rama"; break;
                    case 4: editorialString = "Mc Graw Hill"; break;
                    case 5: editorialString = "Anay Multimedia"; break;
                    case 6: editorialString = "Peuser"; break;
                    case 7: editorialString = "Colombo"; break;
                }

                //---
                //distribuidor, we want to convert its id into the name of the distribuitor
                int distribuidor = Convert.ToInt32(arrDataFile[4]);
                string distribuidorString = "";

                switch (distribuidor) {
                    case 1: distribuidorString = "Los alarces"; break;
                    case 2: distribuidorString = "Mayocor Libros"; break;
                    case 3: distribuidorString = "La buena lectura"; break;
                    case 4: distribuidorString = "Sam Walter"; break;
                    case 5: distribuidorString = "Infinito"; break;
                    case 6: distribuidorString = "Delta al Cuadrado"; break;
                    case 7: distribuidorString = "Rapilent"; break;
                }

                //---
                ////will store the data in an array so we can add it into the matrix
                matrizData[rowMatriz, 0] = arrDataFile[0]; //codigo
                matrizData[rowMatriz, 1] = arrDataFile[1]; //name
                matrizData[rowMatriz, 2] = editorialString; //editorial
                matrizData[rowMatriz, 3] = arrDataFile[3]; //author
                matrizData[rowMatriz, 4] = distribuidorString; //distribuidor
                rowMatriz++;
            }
        }

        private void frmConsulta_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //btnNext  
        private void button2_Click(object sender, EventArgs e)
        {
            if (rowGrd < 21)
            {
                grdData.Rows.Add(
                    matrizData[rowGrd, 0],
                    matrizData[rowGrd, 1],
                    matrizData[rowGrd, 2],
                    matrizData[rowGrd, 3],
                    matrizData[rowGrd, 4]
                );
                rowGrd++;
                btnNext.Enabled = true; //we verify that it is enabled
            }
            else
            {
                MessageBox.Show("You have showed all the data");
                btnNext.Enabled = false;
            }
            btnPrev.Enabled = true; //every time we click next, we can press next. We verify that is enabled.
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if(grdData.Rows.Count>1)  //counts the num of rows in the dgview
            {
                grdData.Rows.RemoveAt(rowGrd - 1);
                rowGrd--;
                btnPrev.Enabled = true; //we verify that it is enabled
            }
            else
            {
                MessageBox.Show("Can not remove data because you have 0 elements in the data grid view");
                btnPrev.Enabled = false;
            }
            btnNext.Enabled = true; //every time we click prev, we can press next. We verify that is enabled.
            btnShowAll.Enabled = true;
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            grdData.Rows.Clear(); //checking that the grd is empty
            for (int i = 0; i < 21; i++)
            {
                grdData.Rows.Add(
                    matrizData[i, 0],
                    matrizData[i, 1],
                    matrizData[i, 2],
                    matrizData[i, 3],
                    matrizData[i, 4]
                );
            }
            rowGrd = 21;
            btnShowAll.Enabled = false;
            btnClearAll.Enabled = true;
            btnNext.Enabled = false;
            btnPrev.Enabled = true;
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            grdData.Rows.Clear();
            rowGrd = 0;
            btnShowAll.Enabled = true;
            btnClearAll.Enabled = false;
            btnNext.Enabled = true;
            btnPrev.Enabled = true;
        }
    }
}

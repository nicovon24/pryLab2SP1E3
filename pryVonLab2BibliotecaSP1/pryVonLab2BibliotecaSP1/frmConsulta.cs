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
                //will store the data from the file
                string[] arrDataFile = sr.ReadLine().Split(separador);

                ////will store the data in an array so we can add it into the matrix
                matrizData[rowMatriz, 0] = arrDataFile[0];
                matrizData[rowMatriz, 1] = arrDataFile[1];
                matrizData[rowMatriz, 2] = arrDataFile[2];
                matrizData[rowMatriz, 3] = arrDataFile[3];
                matrizData[rowMatriz, 4] = arrDataFile[4];
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
            }
            else
            {
                MessageBox.Show("You have showed all the data");
            }

        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if(grdData.Rows.Count>1)  //counts the num of rows in the dgview
            {
                grdData.Rows.RemoveAt(rowGrd - 1);
                rowGrd--;
            }
            else
            {
                MessageBox.Show("Can not remove data because you have 0 elements in the data grid view");
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < 21; i++)
            {
                grdData.Rows.Add(
                    matrizData[i, 0],
                    matrizData[i, 1],
                    matrizData[i, 2],
                    matrizData[i, 3],
                    matrizData[i, 4]
                );
            }
        }
    }
}

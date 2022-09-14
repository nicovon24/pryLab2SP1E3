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
        int rowLength = 0; //this variable will allow us to add rows to the matrix
        int rowQuery = 0; //will add +1 or -1 row each time we make a query
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
                matrizData[rowLength,0] = arrDataFile[0];
                matrizData[rowLength, 1] = arrDataFile[1];
                matrizData[rowLength, 2] = arrDataFile[2];
                matrizData[rowLength, 3] = arrDataFile[3];
                matrizData[rowLength, 4] = arrDataFile[4];
                rowLength++;
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
            if (rowQuery < 21)
            {
                grdData.Rows.Add(
                    matrizData[rowQuery, 0],
                    matrizData[rowQuery, 1],
                    matrizData[rowQuery, 2],
                    matrizData[rowQuery, 3],
                    matrizData[rowQuery, 4]
                );
                rowQuery++;
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
                grdData.Rows.RemoveAt(rowQuery - 1);
                rowQuery--;
            }
            else
            {
                MessageBox.Show("Can not remove data because you have 0 elements in the data grid view");
            }
        }
    }
}

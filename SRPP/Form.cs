using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SRPP
{
    public partial class FormSRPP : Form
    {
        public FormSRPP()
        {
            InitializeComponent();
        }
        private string fileLocation;

        private int kReaded;

        private int[][] citiesMatrix;

        private FileOperations fileOperations;
        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
    
        }

        private void fileDataButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            fileDataTextBox.Clear();
            fileDataTextBox.Update();
            readDataButton.Enabled = false;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
               
                fileLocation = openFileDialog.FileName;
                fileDataTextBox.Text = fileLocation;
                readDataButton.Enabled = true;
            }
        }

        private void readDataButton_Click(object sender, EventArgs e)
        {

            fileOperations = new FileOperations(fileLocation, true);
          
         
            
            string[] dane = fileOperations.titleCutData();
            numberOfCityLabel.Text = dane[0]; 
            lengthCourseLabel.Text = dane[1];

            citiesMatrix = fileOperations.cityMatrix();

            dataGridViewOfPlaceCity.ColumnCount = 3;
            dataGridViewOfPlaceCity.RowCount = citiesMatrix.Length;
            xLabel.Text = citiesMatrix[0][0].ToString();
            yLabel.Text = citiesMatrix[0][1].ToString();
            dataGridViewOfPlaceCity.Columns[0].HeaderText = "Miasto";        
            dataGridViewOfPlaceCity.Columns[1].HeaderText = "X";
            dataGridViewOfPlaceCity.Columns[2].HeaderText = "Y";
            for (int i = 0; i < citiesMatrix.Length; i++)
            {
                dataGridViewOfPlaceCity.Rows[i].Cells[0].Value = i.ToString();
                for (int j = 0; j < 2; j++)
                {
                    dataGridViewOfPlaceCity.Rows[i].Cells[j+1].Value = citiesMatrix[i][j];
                     
                }
               
                lineChartCityMap.Series["Miasta"].Points.AddXY(citiesMatrix[i][0], citiesMatrix[i][1]);
                lineChartCityMap.Series["Miasta"].Color = Color.Blue;
            }
            lineChartCityMap.ChartAreas[0].AxisX.Minimum = 0;
            lineChartCityMap.ChartAreas[0].AxisX.Maximum = 500;
            lineChartCityMap.ChartAreas[0].AxisY.Minimum = 0;
            lineChartCityMap.ChartAreas[0].AxisY.Maximum = 500;
          
        }

        private void startProcedureButton_Click(object sender, EventArgs e)
        {
            SimulatedAnnealing sA = new SimulatedAnnealing(citiesMatrix, 2.0, Convert.ToInt32(lengthCourseLabel.Text), citiesMatrix.Length);
        }
    }
}

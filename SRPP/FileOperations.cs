using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SRPP
{
    class FileOperations
    {
        private FileStream fileStreamRead;
        private StreamReader streamRead;
        private FileStream fileStreamWrite;
        private StreamWriter streamWrite;
        private FileInfo fileInfo;
        private string nameFiles;
        /**
         * 
         **/
        public FileOperations(string nameFile, bool ifRead)
        {
            fileInfo = new FileInfo(nameFile);
            nameFiles = nameFile;

            if (ifRead == true)
            {
                fileStreamRead = new FileStream(nameFile, FileMode.Open, FileAccess.Read);
                streamRead = new StreamReader(fileStreamRead);
            }
            else
            {
                fileStreamWrite = new FileStream(nameFile, FileMode.Open, FileAccess.Write);
                streamWrite = new StreamWriter(fileStreamWrite);
            }
           
        }

        public string[] titleCutData()
        {
            string [] returnValue = new string[2];
            string [] dataTitle = fileInfo.Name.Split('_');
            returnValue[0] = dataTitle[0];
            dataTitle = dataTitle[1].Split('=');
            returnValue[1] = dataTitle[1];
            return returnValue;
        }
        
        public int[][] cityMatrix()
        {
            int numberOfCity = File.ReadAllLines(nameFiles).Length - 1;
            streamRead.ReadLine();
            int[][] placeCities = new int[numberOfCity][];

            for (int i = 0; i < numberOfCity; i++)
            {
                placeCities[i] = new int [2];
              
                string[] line = streamRead.ReadLine().Split(new string [] {" "},StringSplitOptions.RemoveEmptyEntries);
                string[] data = new string[2];

                for (int j = 0; j < 2; j++)
                {
                    placeCities[i][j] = Convert.ToInt32(line[j]);
                }
            }

            return placeCities;
        }

        public void saveResults (int [][] matrixTrace, double traceLength)
        {
            streamWrite.WriteLine(traceLength.ToString());
            streamWrite.WriteLine(matrixTrace.Length.ToString());
            String line = "";
            for(int i = 0; i < matrixTrace.Length; i++)
            {
                for (int j = 0; j < matrixTrace[i].Length; j++)
                {
                    line += matrixTrace[i][j] + " ";
                }
                streamWrite.WriteLine(line);
                line = "";
            }
        }
    }
}
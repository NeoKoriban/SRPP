namespace SRPP
{
    partial class FormSRPP
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.insertDataGroupBox = new System.Windows.Forms.GroupBox();
            this.OperationGroupBox = new System.Windows.Forms.GroupBox();
            this.saveResultsButton = new System.Windows.Forms.Button();
            this.lengthCoursesLabel = new System.Windows.Forms.Label();
            this.coursesLengthInfoLabel = new System.Windows.Forms.Label();
            this.temperatureLabelCounter = new System.Windows.Forms.Label();
            this.temperatureCountInfoLabel = new System.Windows.Forms.Label();
            this.temperatureTextBox = new System.Windows.Forms.TextBox();
            this.temperatureLabel = new System.Windows.Forms.Label();
            this.yLabel = new System.Windows.Forms.Label();
            this.yInfoLabel = new System.Windows.Forms.Label();
            this.xLabel = new System.Windows.Forms.Label();
            this.xInfoLabel = new System.Windows.Forms.Label();
            this.StarPointLabelInfo1 = new System.Windows.Forms.Label();
            this.startProcedureButton = new System.Windows.Forms.Button();
            this.lengthCourseLabel = new System.Windows.Forms.Label();
            this.lengthCourseInfoLabel = new System.Windows.Forms.Label();
            this.numberOfCityLabel = new System.Windows.Forms.Label();
            this.infoNumberOfCity = new System.Windows.Forms.Label();
            this.fileGroupBox = new System.Windows.Forms.GroupBox();
            this.readDataButton = new System.Windows.Forms.Button();
            this.fileDataTextBox = new System.Windows.Forms.TextBox();
            this.searchFileButton = new System.Windows.Forms.Button();
            this.dataGroupBox = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.resultTab = new System.Windows.Forms.TabPage();
            this.lineChartCityMap = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataTab = new System.Windows.Forms.TabPage();
            this.dataGridViewOfPlaceCity = new System.Windows.Forms.DataGridView();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.insertDataGroupBox.SuspendLayout();
            this.OperationGroupBox.SuspendLayout();
            this.fileGroupBox.SuspendLayout();
            this.dataGroupBox.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.resultTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lineChartCityMap)).BeginInit();
            this.dataTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOfPlaceCity)).BeginInit();
            this.SuspendLayout();
            // 
            // insertDataGroupBox
            // 
            this.insertDataGroupBox.Controls.Add(this.OperationGroupBox);
            this.insertDataGroupBox.Controls.Add(this.fileGroupBox);
            this.insertDataGroupBox.Location = new System.Drawing.Point(12, 6);
            this.insertDataGroupBox.Name = "insertDataGroupBox";
            this.insertDataGroupBox.Size = new System.Drawing.Size(244, 514);
            this.insertDataGroupBox.TabIndex = 1;
            this.insertDataGroupBox.TabStop = false;
            this.insertDataGroupBox.Text = "Wczytywanie danych";
            // 
            // OperationGroupBox
            // 
            this.OperationGroupBox.Controls.Add(this.saveResultsButton);
            this.OperationGroupBox.Controls.Add(this.lengthCoursesLabel);
            this.OperationGroupBox.Controls.Add(this.coursesLengthInfoLabel);
            this.OperationGroupBox.Controls.Add(this.temperatureLabelCounter);
            this.OperationGroupBox.Controls.Add(this.temperatureCountInfoLabel);
            this.OperationGroupBox.Controls.Add(this.temperatureTextBox);
            this.OperationGroupBox.Controls.Add(this.temperatureLabel);
            this.OperationGroupBox.Controls.Add(this.yLabel);
            this.OperationGroupBox.Controls.Add(this.yInfoLabel);
            this.OperationGroupBox.Controls.Add(this.xLabel);
            this.OperationGroupBox.Controls.Add(this.xInfoLabel);
            this.OperationGroupBox.Controls.Add(this.StarPointLabelInfo1);
            this.OperationGroupBox.Controls.Add(this.startProcedureButton);
            this.OperationGroupBox.Controls.Add(this.lengthCourseLabel);
            this.OperationGroupBox.Controls.Add(this.lengthCourseInfoLabel);
            this.OperationGroupBox.Controls.Add(this.numberOfCityLabel);
            this.OperationGroupBox.Controls.Add(this.infoNumberOfCity);
            this.OperationGroupBox.Location = new System.Drawing.Point(7, 136);
            this.OperationGroupBox.Name = "OperationGroupBox";
            this.OperationGroupBox.Size = new System.Drawing.Size(231, 372);
            this.OperationGroupBox.TabIndex = 4;
            this.OperationGroupBox.TabStop = false;
            this.OperationGroupBox.Text = "Operacje";
            // 
            // saveResultsButton
            // 
            this.saveResultsButton.Location = new System.Drawing.Point(6, 322);
            this.saveResultsButton.Name = "saveResultsButton";
            this.saveResultsButton.Size = new System.Drawing.Size(216, 33);
            this.saveResultsButton.TabIndex = 15;
            this.saveResultsButton.Text = "Zapisz wynik do pliku";
            this.saveResultsButton.UseVisualStyleBackColor = true;
            // 
            // lengthCoursesLabel
            // 
            this.lengthCoursesLabel.AutoSize = true;
            this.lengthCoursesLabel.Location = new System.Drawing.Point(159, 289);
            this.lengthCoursesLabel.Name = "lengthCoursesLabel";
            this.lengthCoursesLabel.Size = new System.Drawing.Size(13, 13);
            this.lengthCoursesLabel.TabIndex = 14;
            this.lengthCoursesLabel.Text = "0";
            // 
            // coursesLengthInfoLabel
            // 
            this.coursesLengthInfoLabel.AutoSize = true;
            this.coursesLengthInfoLabel.Location = new System.Drawing.Point(11, 289);
            this.coursesLengthInfoLabel.Name = "coursesLengthInfoLabel";
            this.coursesLengthInfoLabel.Size = new System.Drawing.Size(76, 13);
            this.coursesLengthInfoLabel.TabIndex = 13;
            this.coursesLengthInfoLabel.Text = "Długość trasy:";
            // 
            // temperatureLabelCounter
            // 
            this.temperatureLabelCounter.AutoSize = true;
            this.temperatureLabelCounter.Location = new System.Drawing.Point(159, 260);
            this.temperatureLabelCounter.Name = "temperatureLabelCounter";
            this.temperatureLabelCounter.Size = new System.Drawing.Size(13, 13);
            this.temperatureLabelCounter.TabIndex = 12;
            this.temperatureLabelCounter.Text = "0";
            // 
            // temperatureCountInfoLabel
            // 
            this.temperatureCountInfoLabel.AutoSize = true;
            this.temperatureCountInfoLabel.Location = new System.Drawing.Point(11, 260);
            this.temperatureCountInfoLabel.Name = "temperatureCountInfoLabel";
            this.temperatureCountInfoLabel.Size = new System.Drawing.Size(73, 13);
            this.temperatureCountInfoLabel.TabIndex = 11;
            this.temperatureCountInfoLabel.Text = "Temperatura: ";
            // 
            // temperatureTextBox
            // 
            this.temperatureTextBox.Location = new System.Drawing.Point(105, 167);
            this.temperatureTextBox.Name = "temperatureTextBox";
            this.temperatureTextBox.Size = new System.Drawing.Size(112, 20);
            this.temperatureTextBox.TabIndex = 10;
            // 
            // temperatureLabel
            // 
            this.temperatureLabel.AutoSize = true;
            this.temperatureLabel.Location = new System.Drawing.Point(11, 170);
            this.temperatureLabel.Name = "temperatureLabel";
            this.temperatureLabel.Size = new System.Drawing.Size(73, 13);
            this.temperatureLabel.TabIndex = 9;
            this.temperatureLabel.Text = "Temperatura: ";
            // 
            // yLabel
            // 
            this.yLabel.AutoSize = true;
            this.yLabel.Location = new System.Drawing.Point(170, 136);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(13, 13);
            this.yLabel.TabIndex = 8;
            this.yLabel.Text = "0";
            // 
            // yInfoLabel
            // 
            this.yInfoLabel.AutoSize = true;
            this.yInfoLabel.Location = new System.Drawing.Point(128, 136);
            this.yInfoLabel.Name = "yInfoLabel";
            this.yInfoLabel.Size = new System.Drawing.Size(26, 13);
            this.yInfoLabel.TabIndex = 7;
            this.yInfoLabel.Text = "Y  =";
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Location = new System.Drawing.Point(93, 136);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(13, 13);
            this.xLabel.TabIndex = 6;
            this.xLabel.Text = "0";
            // 
            // xInfoLabel
            // 
            this.xInfoLabel.AutoSize = true;
            this.xInfoLabel.Location = new System.Drawing.Point(53, 136);
            this.xInfoLabel.Name = "xInfoLabel";
            this.xInfoLabel.Size = new System.Drawing.Size(26, 13);
            this.xInfoLabel.TabIndex = 5;
            this.xInfoLabel.Text = "X  =";
            // 
            // StarPointLabelInfo1
            // 
            this.StarPointLabelInfo1.AutoSize = true;
            this.StarPointLabelInfo1.Location = new System.Drawing.Point(11, 105);
            this.StarPointLabelInfo1.Name = "StarPointLabelInfo1";
            this.StarPointLabelInfo1.Size = new System.Drawing.Size(53, 13);
            this.StarPointLabelInfo1.TabIndex = 4;
            this.StarPointLabelInfo1.Text = "Magazyn:";
            // 
            // startProcedureButton
            // 
            this.startProcedureButton.Location = new System.Drawing.Point(6, 207);
            this.startProcedureButton.Name = "startProcedureButton";
            this.startProcedureButton.Size = new System.Drawing.Size(216, 33);
            this.startProcedureButton.TabIndex = 2;
            this.startProcedureButton.Text = "Rozpocznij";
            this.startProcedureButton.UseVisualStyleBackColor = true;
            this.startProcedureButton.Click += new System.EventHandler(this.startProcedureButton_Click);
            // 
            // lengthCourseLabel
            // 
            this.lengthCourseLabel.AutoSize = true;
            this.lengthCourseLabel.Location = new System.Drawing.Point(159, 66);
            this.lengthCourseLabel.Name = "lengthCourseLabel";
            this.lengthCourseLabel.Size = new System.Drawing.Size(13, 13);
            this.lengthCourseLabel.TabIndex = 3;
            this.lengthCourseLabel.Text = "0";
            // 
            // lengthCourseInfoLabel
            // 
            this.lengthCourseInfoLabel.AutoSize = true;
            this.lengthCourseInfoLabel.Location = new System.Drawing.Point(11, 66);
            this.lengthCourseInfoLabel.Name = "lengthCourseInfoLabel";
            this.lengthCourseInfoLabel.Size = new System.Drawing.Size(80, 13);
            this.lengthCourseInfoLabel.TabIndex = 2;
            this.lengthCourseInfoLabel.Text = "Długość kursu:";
            // 
            // numberOfCityLabel
            // 
            this.numberOfCityLabel.AutoSize = true;
            this.numberOfCityLabel.Location = new System.Drawing.Point(159, 31);
            this.numberOfCityLabel.Name = "numberOfCityLabel";
            this.numberOfCityLabel.Size = new System.Drawing.Size(13, 13);
            this.numberOfCityLabel.TabIndex = 1;
            this.numberOfCityLabel.Text = "0";
            // 
            // infoNumberOfCity
            // 
            this.infoNumberOfCity.AutoSize = true;
            this.infoNumberOfCity.Location = new System.Drawing.Point(11, 31);
            this.infoNumberOfCity.Name = "infoNumberOfCity";
            this.infoNumberOfCity.Size = new System.Drawing.Size(68, 13);
            this.infoNumberOfCity.TabIndex = 0;
            this.infoNumberOfCity.Text = "Liczba miast:";
            // 
            // fileGroupBox
            // 
            this.fileGroupBox.Controls.Add(this.readDataButton);
            this.fileGroupBox.Controls.Add(this.fileDataTextBox);
            this.fileGroupBox.Controls.Add(this.searchFileButton);
            this.fileGroupBox.Location = new System.Drawing.Point(6, 19);
            this.fileGroupBox.Name = "fileGroupBox";
            this.fileGroupBox.Size = new System.Drawing.Size(232, 110);
            this.fileGroupBox.TabIndex = 3;
            this.fileGroupBox.TabStop = false;
            this.fileGroupBox.Text = "Otwarcie pliku";
            // 
            // readDataButton
            // 
            this.readDataButton.Enabled = false;
            this.readDataButton.Location = new System.Drawing.Point(122, 56);
            this.readDataButton.Name = "readDataButton";
            this.readDataButton.Size = new System.Drawing.Size(97, 33);
            this.readDataButton.TabIndex = 2;
            this.readDataButton.Text = "Wczytaj dane";
            this.readDataButton.UseVisualStyleBackColor = true;
            this.readDataButton.Click += new System.EventHandler(this.readDataButton_Click);
            // 
            // fileDataTextBox
            // 
            this.fileDataTextBox.Location = new System.Drawing.Point(10, 30);
            this.fileDataTextBox.Name = "fileDataTextBox";
            this.fileDataTextBox.Size = new System.Drawing.Size(208, 20);
            this.fileDataTextBox.TabIndex = 0;
            // 
            // searchFileButton
            // 
            this.searchFileButton.Location = new System.Drawing.Point(10, 56);
            this.searchFileButton.Name = "searchFileButton";
            this.searchFileButton.Size = new System.Drawing.Size(97, 33);
            this.searchFileButton.TabIndex = 1;
            this.searchFileButton.Text = "Szukaj pliku";
            this.searchFileButton.UseVisualStyleBackColor = true;
            this.searchFileButton.Click += new System.EventHandler(this.fileDataButton_Click);
            // 
            // dataGroupBox
            // 
            this.dataGroupBox.Controls.Add(this.tabControl1);
            this.dataGroupBox.Location = new System.Drawing.Point(262, 6);
            this.dataGroupBox.Name = "dataGroupBox";
            this.dataGroupBox.Size = new System.Drawing.Size(665, 514);
            this.dataGroupBox.TabIndex = 2;
            this.dataGroupBox.TabStop = false;
            this.dataGroupBox.Text = "Dane i wyniki";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.resultTab);
            this.tabControl1.Controls.Add(this.dataTab);
            this.tabControl1.Location = new System.Drawing.Point(6, 19);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(653, 489);
            this.tabControl1.TabIndex = 0;
            // 
            // resultTab
            // 
            this.resultTab.Controls.Add(this.lineChartCityMap);
            this.resultTab.Location = new System.Drawing.Point(4, 22);
            this.resultTab.Name = "resultTab";
            this.resultTab.Padding = new System.Windows.Forms.Padding(3);
            this.resultTab.Size = new System.Drawing.Size(645, 463);
            this.resultTab.TabIndex = 0;
            this.resultTab.Text = "Wynik";
            this.resultTab.UseVisualStyleBackColor = true;
            // 
            // lineChartCityMap
            // 
            chartArea1.Name = "ChartArea1";
            this.lineChartCityMap.ChartAreas.Add(chartArea1);
            this.lineChartCityMap.Location = new System.Drawing.Point(7, 8);
            this.lineChartCityMap.Name = "lineChartCityMap";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Name = "Miasta";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Name = "Trasa";
            this.lineChartCityMap.Series.Add(series1);
            this.lineChartCityMap.Series.Add(series2);
            this.lineChartCityMap.Size = new System.Drawing.Size(632, 442);
            this.lineChartCityMap.TabIndex = 0;
            this.lineChartCityMap.Text = "TrackCities";
            // 
            // dataTab
            // 
            this.dataTab.Controls.Add(this.dataGridViewOfPlaceCity);
            this.dataTab.Location = new System.Drawing.Point(4, 22);
            this.dataTab.Name = "dataTab";
            this.dataTab.Padding = new System.Windows.Forms.Padding(3);
            this.dataTab.Size = new System.Drawing.Size(645, 463);
            this.dataTab.TabIndex = 1;
            this.dataTab.Text = "Dane";
            this.dataTab.UseVisualStyleBackColor = true;
            // 
            // dataGridViewOfPlaceCity
            // 
            this.dataGridViewOfPlaceCity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOfPlaceCity.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridViewOfPlaceCity.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewOfPlaceCity.Name = "dataGridViewOfPlaceCity";
            this.dataGridViewOfPlaceCity.ReadOnly = true;
            this.dataGridViewOfPlaceCity.Size = new System.Drawing.Size(630, 451);
            this.dataGridViewOfPlaceCity.TabIndex = 0;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // FormSRPP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 526);
            this.Controls.Add(this.dataGroupBox);
            this.Controls.Add(this.insertDataGroupBox);
            this.Name = "FormSRPP";
            this.Text = "Problem komiwojażera";
            this.insertDataGroupBox.ResumeLayout(false);
            this.OperationGroupBox.ResumeLayout(false);
            this.OperationGroupBox.PerformLayout();
            this.fileGroupBox.ResumeLayout(false);
            this.fileGroupBox.PerformLayout();
            this.dataGroupBox.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.resultTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lineChartCityMap)).EndInit();
            this.dataTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOfPlaceCity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox insertDataGroupBox;
        private System.Windows.Forms.Button searchFileButton;
        private System.Windows.Forms.TextBox fileDataTextBox;
        private System.Windows.Forms.GroupBox dataGroupBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage resultTab;
        private System.Windows.Forms.TabPage dataTab;
        private System.Windows.Forms.GroupBox fileGroupBox;
        private System.Windows.Forms.GroupBox OperationGroupBox;
        private System.Windows.Forms.Button startProcedureButton;
        private System.Windows.Forms.Label lengthCourseLabel;
        private System.Windows.Forms.Label lengthCourseInfoLabel;
        private System.Windows.Forms.Label numberOfCityLabel;
        private System.Windows.Forms.Label infoNumberOfCity;
        private System.Windows.Forms.Label yLabel;
        private System.Windows.Forms.Label yInfoLabel;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.Label xInfoLabel;
        private System.Windows.Forms.Label StarPointLabelInfo1;
        private System.Windows.Forms.DataVisualization.Charting.Chart lineChartCityMap;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button readDataButton;
        private System.Windows.Forms.Button saveResultsButton;
        private System.Windows.Forms.Label lengthCoursesLabel;
        private System.Windows.Forms.Label coursesLengthInfoLabel;
        private System.Windows.Forms.Label temperatureLabelCounter;
        private System.Windows.Forms.Label temperatureCountInfoLabel;
        private System.Windows.Forms.TextBox temperatureTextBox;
        private System.Windows.Forms.Label temperatureLabel;
        private System.Windows.Forms.DataGridView dataGridViewOfPlaceCity;
    }
}


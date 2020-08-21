namespace BenefitControl
{
    partial class CostByTypePage
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.CostByTypePageTitle = new System.Windows.Forms.Label();
            this.costTotalAmountChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.returnButton = new System.Windows.Forms.Button();
            this.costNameCheckList = new System.Windows.Forms.CheckedListBox();
            this.allSelectedCheckBox = new System.Windows.Forms.CheckBox();
            this.costUnitPriceChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.totalAmountButton = new System.Windows.Forms.RadioButton();
            this.unitPriceButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.costTotalAmountChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.costUnitPriceChart)).BeginInit();
            this.SuspendLayout();
            // 
            // CostByTypePageTitle
            // 
            this.CostByTypePageTitle.Font = new System.Drawing.Font("楷体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CostByTypePageTitle.Location = new System.Drawing.Point(260, 60);
            this.CostByTypePageTitle.Name = "CostByTypePageTitle";
            this.CostByTypePageTitle.Size = new System.Drawing.Size(489, 71);
            this.CostByTypePageTitle.TabIndex = 6;
            this.CostByTypePageTitle.Text = "支出细节/种类";
            this.CostByTypePageTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // costTotalAmountChart
            // 
            chartArea3.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea3.AxisX.IsMarginVisible = false;
            chartArea3.AxisX.MajorGrid.Enabled = false;
            chartArea3.AxisX.ScaleBreakStyle.MaxNumberOfBreaks = 1;
            chartArea3.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea3.AxisY.IsMarginVisible = false;
            chartArea3.AxisY.MajorGrid.Enabled = false;
            chartArea3.AxisY.ScaleBreakStyle.MaxNumberOfBreaks = 1;
            chartArea3.Name = "ChartArea1";
            chartArea3.Position.Auto = false;
            chartArea3.Position.Height = 72.11099F;
            chartArea3.Position.Width = 94F;
            chartArea3.Position.X = 3F;
            chartArea3.Position.Y = 25.889F;
            this.costTotalAmountChart.ChartAreas.Add(chartArea3);
            legend3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend3.MaximumAutoSize = 30F;
            legend3.Name = "Legend1";
            legend3.Position.Auto = false;
            legend3.Position.Height = 8.026756F;
            legend3.Position.Width = 80.95219F;
            legend3.Position.X = 11.5F;
            legend3.Position.Y = 14.889F;
            this.costTotalAmountChart.Legends.Add(legend3);
            this.costTotalAmountChart.Location = new System.Drawing.Point(12, 134);
            this.costTotalAmountChart.Name = "costTotalAmountChart";
            this.costTotalAmountChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            this.costTotalAmountChart.Size = new System.Drawing.Size(984, 300);
            this.costTotalAmountChart.TabIndex = 7;
            this.costTotalAmountChart.Text = "chart1";
            title3.Font = new System.Drawing.Font("楷体", 15.75F);
            title3.Name = "Title1";
            title3.Text = "支出详表";
            this.costTotalAmountChart.Titles.Add(title3);
            // 
            // returnButton
            // 
            this.returnButton.BackColor = System.Drawing.Color.White;
            this.returnButton.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.returnButton.Location = new System.Drawing.Point(865, 35);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(105, 39);
            this.returnButton.TabIndex = 8;
            this.returnButton.Text = "返回";
            this.returnButton.UseVisualStyleBackColor = false;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // costNameCheckList
            // 
            this.costNameCheckList.CheckOnClick = true;
            this.costNameCheckList.Font = new System.Drawing.Font("楷体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.costNameCheckList.FormattingEnabled = true;
            this.costNameCheckList.Location = new System.Drawing.Point(64, 478);
            this.costNameCheckList.MultiColumn = true;
            this.costNameCheckList.Name = "costNameCheckList";
            this.costNameCheckList.Size = new System.Drawing.Size(876, 44);
            this.costNameCheckList.TabIndex = 9;
            this.costNameCheckList.SelectedIndexChanged += new System.EventHandler(this.costNameCheckList_SelectedIndexChanged);
            // 
            // allSelectedCheckBox
            // 
            this.allSelectedCheckBox.AutoSize = true;
            this.allSelectedCheckBox.Font = new System.Drawing.Font("楷体", 11.25F);
            this.allSelectedCheckBox.Location = new System.Drawing.Point(67, 453);
            this.allSelectedCheckBox.Name = "allSelectedCheckBox";
            this.allSelectedCheckBox.Size = new System.Drawing.Size(58, 19);
            this.allSelectedCheckBox.TabIndex = 10;
            this.allSelectedCheckBox.Text = "全选";
            this.allSelectedCheckBox.UseVisualStyleBackColor = true;
            this.allSelectedCheckBox.CheckedChanged += new System.EventHandler(this.allSelectedCheckBox_CheckedChanged);
            // 
            // costUnitPriceChart
            // 
            chartArea4.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea4.AxisX.IsMarginVisible = false;
            chartArea4.AxisX.MajorGrid.Enabled = false;
            chartArea4.AxisX.ScaleBreakStyle.MaxNumberOfBreaks = 1;
            chartArea4.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea4.AxisY.IsMarginVisible = false;
            chartArea4.AxisY.MajorGrid.Enabled = false;
            chartArea4.AxisY.ScaleBreakStyle.MaxNumberOfBreaks = 1;
            chartArea4.Name = "ChartArea1";
            chartArea4.Position.Auto = false;
            chartArea4.Position.Height = 72.11099F;
            chartArea4.Position.Width = 94F;
            chartArea4.Position.X = 3F;
            chartArea4.Position.Y = 25.889F;
            this.costUnitPriceChart.ChartAreas.Add(chartArea4);
            legend4.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend4.MaximumAutoSize = 30F;
            legend4.Name = "Legend1";
            legend4.Position.Auto = false;
            legend4.Position.Height = 8.026756F;
            legend4.Position.Width = 80.95219F;
            legend4.Position.X = 11.5F;
            legend4.Position.Y = 14.889F;
            this.costUnitPriceChart.Legends.Add(legend4);
            this.costUnitPriceChart.Location = new System.Drawing.Point(12, 134);
            this.costUnitPriceChart.Name = "costUnitPriceChart";
            this.costUnitPriceChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            this.costUnitPriceChart.Size = new System.Drawing.Size(984, 300);
            this.costUnitPriceChart.TabIndex = 11;
            title4.Font = new System.Drawing.Font("楷体", 15.75F);
            title4.Name = "Title1";
            title4.Text = "支出单价详表";
            this.costUnitPriceChart.Titles.Add(title4);
            // 
            // totalAmountButton
            // 
            this.totalAmountButton.AutoSize = true;
            this.totalAmountButton.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.totalAmountButton.Location = new System.Drawing.Point(12, 112);
            this.totalAmountButton.Name = "totalAmountButton";
            this.totalAmountButton.Size = new System.Drawing.Size(58, 20);
            this.totalAmountButton.TabIndex = 12;
            this.totalAmountButton.TabStop = true;
            this.totalAmountButton.Text = "总价";
            this.totalAmountButton.UseVisualStyleBackColor = true;
            this.totalAmountButton.CheckedChanged += new System.EventHandler(this.totalAmountButton_CheckedChanged);
            // 
            // unitPriceButton
            // 
            this.unitPriceButton.AutoSize = true;
            this.unitPriceButton.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.unitPriceButton.Location = new System.Drawing.Point(76, 112);
            this.unitPriceButton.Name = "unitPriceButton";
            this.unitPriceButton.Size = new System.Drawing.Size(58, 20);
            this.unitPriceButton.TabIndex = 13;
            this.unitPriceButton.TabStop = true;
            this.unitPriceButton.Text = "单价";
            this.unitPriceButton.UseVisualStyleBackColor = true;
            // 
            // CostByTypePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.unitPriceButton);
            this.Controls.Add(this.totalAmountButton);
            this.Controls.Add(this.costUnitPriceChart);
            this.Controls.Add(this.allSelectedCheckBox);
            this.Controls.Add(this.costNameCheckList);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.costTotalAmountChart);
            this.Controls.Add(this.CostByTypePageTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "CostByTypePage";
            ((System.ComponentModel.ISupportInitialize)(this.costTotalAmountChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.costUnitPriceChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CostByTypePageTitle;
        private System.Windows.Forms.DataVisualization.Charting.Chart costTotalAmountChart;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.CheckedListBox costNameCheckList;
        private System.Windows.Forms.CheckBox allSelectedCheckBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart costUnitPriceChart;
        private System.Windows.Forms.RadioButton totalAmountButton;
        private System.Windows.Forms.RadioButton unitPriceButton;
    }
}
namespace BenefitControl
{
    partial class MonthBenefitPage
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
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.monthBenefitPageTitle = new System.Windows.Forms.Label();
            this.returnButton = new System.Windows.Forms.Button();
            this.monthBenefitChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.monthBenefitPanel = new System.Windows.Forms.Panel();
            this.daySelectionDropdown = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.totalBenefitLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.totalCostLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.totalIncomeLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dayDetailButton = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dayBenefitLabel = new System.Windows.Forms.Label();
            this.dayCostLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dayIncomeLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dayLabel = new System.Windows.Forms.Label();
            this.benefitDetailLabel = new System.Windows.Forms.Label();
            this.costDetailButton = new System.Windows.Forms.Button();
            this.monthCostDetailChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.monthBenefitChart)).BeginInit();
            this.monthBenefitPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monthCostDetailChart)).BeginInit();
            this.SuspendLayout();
            // 
            // monthBenefitPageTitle
            // 
            this.monthBenefitPageTitle.Font = new System.Drawing.Font("楷体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.monthBenefitPageTitle.Location = new System.Drawing.Point(263, 60);
            this.monthBenefitPageTitle.Name = "monthBenefitPageTitle";
            this.monthBenefitPageTitle.Size = new System.Drawing.Size(489, 71);
            this.monthBenefitPageTitle.TabIndex = 5;
            this.monthBenefitPageTitle.Text = "饭店流水/月份";
            this.monthBenefitPageTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // monthBenefitChart
            // 
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.IsMarginVisible = false;
            chartArea1.AxisX.IsStartedFromZero = false;
            chartArea1.AxisX.LabelStyle.IsEndLabelVisible = false;
            chartArea1.AxisX.MajorGrid.LineWidth = 0;
            chartArea1.AxisY.MajorGrid.LineWidth = 0;
            chartArea1.Name = "ChartArea1";
            this.monthBenefitChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.monthBenefitChart.Legends.Add(legend1);
            this.monthBenefitChart.Location = new System.Drawing.Point(12, 134);
            this.monthBenefitChart.Name = "monthBenefitChart";
            this.monthBenefitChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.LegendText = "支出";
            series1.Name = "costSeries";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.LegendText = "收入";
            series2.Name = "incomeSeries";
            this.monthBenefitChart.Series.Add(series1);
            this.monthBenefitChart.Series.Add(series2);
            this.monthBenefitChart.Size = new System.Drawing.Size(984, 215);
            this.monthBenefitChart.TabIndex = 9;
            title1.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "ChartTitle";
            title1.Text = "支出-收入对比图";
            this.monthBenefitChart.Titles.Add(title1);
            // 
            // monthBenefitPanel
            // 
            this.monthBenefitPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.monthBenefitPanel.Controls.Add(this.daySelectionDropdown);
            this.monthBenefitPanel.Controls.Add(this.tableLayoutPanel1);
            this.monthBenefitPanel.Controls.Add(this.dayDetailButton);
            this.monthBenefitPanel.Controls.Add(this.label15);
            this.monthBenefitPanel.Controls.Add(this.label14);
            this.monthBenefitPanel.Controls.Add(this.dayBenefitLabel);
            this.monthBenefitPanel.Controls.Add(this.dayCostLabel);
            this.monthBenefitPanel.Controls.Add(this.label11);
            this.monthBenefitPanel.Controls.Add(this.dayIncomeLabel);
            this.monthBenefitPanel.Controls.Add(this.label6);
            this.monthBenefitPanel.Controls.Add(this.label5);
            this.monthBenefitPanel.Controls.Add(this.label4);
            this.monthBenefitPanel.Controls.Add(this.dayLabel);
            this.monthBenefitPanel.Controls.Add(this.benefitDetailLabel);
            this.monthBenefitPanel.Location = new System.Drawing.Point(42, 405);
            this.monthBenefitPanel.Name = "monthBenefitPanel";
            this.monthBenefitPanel.Size = new System.Drawing.Size(403, 300);
            this.monthBenefitPanel.TabIndex = 15;
            // 
            // daySelectionDropdown
            // 
            this.daySelectionDropdown.BackColor = System.Drawing.Color.White;
            this.daySelectionDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.daySelectionDropdown.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.daySelectionDropdown.Font = new System.Drawing.Font("宋体", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.daySelectionDropdown.FormattingEnabled = true;
            this.daySelectionDropdown.Location = new System.Drawing.Point(294, 129);
            this.daySelectionDropdown.Name = "daySelectionDropdown";
            this.daySelectionDropdown.Size = new System.Drawing.Size(89, 25);
            this.daySelectionDropdown.TabIndex = 16;
            this.daySelectionDropdown.SelectedIndexChanged += new System.EventHandler(this.daySelectionDropdown_SelectedIndexChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.69663F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.30337F));
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-2, 35);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(404, 82);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.totalBenefitLabel);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(93, 53);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(305, 28);
            this.panel3.TabIndex = 16;
            // 
            // totalBenefitLabel
            // 
            this.totalBenefitLabel.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.totalBenefitLabel.Location = new System.Drawing.Point(0, 3);
            this.totalBenefitLabel.Margin = new System.Windows.Forms.Padding(0);
            this.totalBenefitLabel.Name = "totalBenefitLabel";
            this.totalBenefitLabel.Size = new System.Drawing.Size(266, 23);
            this.totalBenefitLabel.TabIndex = 15;
            this.totalBenefitLabel.Text = "1,000,000,000";
            this.totalBenefitLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(266, 2);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(39, 27);
            this.label9.TabIndex = 15;
            this.label9.Text = " 円";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.totalCostLabel);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(93, 27);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(305, 24);
            this.panel2.TabIndex = 16;
            // 
            // totalCostLabel
            // 
            this.totalCostLabel.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.totalCostLabel.Location = new System.Drawing.Point(0, 1);
            this.totalCostLabel.Margin = new System.Windows.Forms.Padding(0);
            this.totalCostLabel.Name = "totalCostLabel";
            this.totalCostLabel.Size = new System.Drawing.Size(266, 23);
            this.totalCostLabel.TabIndex = 15;
            this.totalCostLabel.Text = "1,000,000,000";
            this.totalCostLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(266, 0);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(39, 27);
            this.label8.TabIndex = 15;
            this.label8.Text = " 円";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.totalIncomeLabel);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(93, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(305, 24);
            this.panel1.TabIndex = 15;
            // 
            // totalIncomeLabel
            // 
            this.totalIncomeLabel.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.totalIncomeLabel.Location = new System.Drawing.Point(0, 1);
            this.totalIncomeLabel.Margin = new System.Windows.Forms.Padding(0);
            this.totalIncomeLabel.Name = "totalIncomeLabel";
            this.totalIncomeLabel.Size = new System.Drawing.Size(266, 23);
            this.totalIncomeLabel.TabIndex = 14;
            this.totalIncomeLabel.Text = "1,000,000,000";
            this.totalIncomeLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(266, 0);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(39, 27);
            this.label7.TabIndex = 13;
            this.label7.Text = " 円";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(1, 53);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 28);
            this.label3.TabIndex = 13;
            this.label3.Text = "利润  :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(1, 1);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "总收入:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(1, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "总支出:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // dayDetailButton
            // 
            this.dayDetailButton.BackColor = System.Drawing.Color.White;
            this.dayDetailButton.Font = new System.Drawing.Font("楷体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dayDetailButton.Location = new System.Drawing.Point(153, 129);
            this.dayDetailButton.Name = "dayDetailButton";
            this.dayDetailButton.Size = new System.Drawing.Size(112, 25);
            this.dayDetailButton.TabIndex = 12;
            this.dayDetailButton.Text = "查看该日流水";
            this.dayDetailButton.UseVisualStyleBackColor = false;
            this.dayDetailButton.Click += new System.EventHandler(this.dayDetailButton_Click);
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(240, 245);
            this.label15.Margin = new System.Windows.Forms.Padding(0);
            this.label15.Name = "label15";
            this.label15.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label15.Size = new System.Drawing.Size(39, 27);
            this.label15.TabIndex = 19;
            this.label15.Text = " 円";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(240, 207);
            this.label14.Margin = new System.Windows.Forms.Padding(0);
            this.label14.Name = "label14";
            this.label14.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label14.Size = new System.Drawing.Size(39, 27);
            this.label14.TabIndex = 18;
            this.label14.Text = " 円";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dayBenefitLabel
            // 
            this.dayBenefitLabel.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dayBenefitLabel.Location = new System.Drawing.Point(75, 246);
            this.dayBenefitLabel.Margin = new System.Windows.Forms.Padding(0);
            this.dayBenefitLabel.Name = "dayBenefitLabel";
            this.dayBenefitLabel.Size = new System.Drawing.Size(165, 23);
            this.dayBenefitLabel.TabIndex = 17;
            this.dayBenefitLabel.Text = "1,000,000,000";
            this.dayBenefitLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // dayCostLabel
            // 
            this.dayCostLabel.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dayCostLabel.Location = new System.Drawing.Point(75, 207);
            this.dayCostLabel.Margin = new System.Windows.Forms.Padding(0);
            this.dayCostLabel.Name = "dayCostLabel";
            this.dayCostLabel.Size = new System.Drawing.Size(165, 23);
            this.dayCostLabel.TabIndex = 16;
            this.dayCostLabel.Text = "1,000,000,000";
            this.dayCostLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(240, 167);
            this.label11.Margin = new System.Windows.Forms.Padding(0);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label11.Size = new System.Drawing.Size(39, 27);
            this.label11.TabIndex = 14;
            this.label11.Text = " 円";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dayIncomeLabel
            // 
            this.dayIncomeLabel.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dayIncomeLabel.Location = new System.Drawing.Point(75, 168);
            this.dayIncomeLabel.Margin = new System.Windows.Forms.Padding(0);
            this.dayIncomeLabel.Name = "dayIncomeLabel";
            this.dayIncomeLabel.Size = new System.Drawing.Size(165, 23);
            this.dayIncomeLabel.TabIndex = 15;
            this.dayIncomeLabel.Text = "1,000,000,000";
            this.dayIncomeLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(17, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 23);
            this.label6.TabIndex = 15;
            this.label6.Text = "利润：";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(17, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 23);
            this.label5.TabIndex = 14;
            this.label5.Text = "支出:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(17, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 23);
            this.label4.TabIndex = 13;
            this.label4.Text = "收入:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // dayLabel
            // 
            this.dayLabel.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dayLabel.Location = new System.Drawing.Point(17, 131);
            this.dayLabel.Name = "dayLabel";
            this.dayLabel.Size = new System.Drawing.Size(116, 23);
            this.dayLabel.TabIndex = 13;
            this.dayLabel.Text = "十一日细节";
            // 
            // benefitDetailLabel
            // 
            this.benefitDetailLabel.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.benefitDetailLabel.Location = new System.Drawing.Point(0, -1);
            this.benefitDetailLabel.Margin = new System.Windows.Forms.Padding(0);
            this.benefitDetailLabel.Name = "benefitDetailLabel";
            this.benefitDetailLabel.Size = new System.Drawing.Size(397, 36);
            this.benefitDetailLabel.TabIndex = 4;
            this.benefitDetailLabel.Text = "流水细节";
            this.benefitDetailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // costDetailButton
            // 
            this.costDetailButton.BackColor = System.Drawing.Color.White;
            this.costDetailButton.Font = new System.Drawing.Font("楷体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.costDetailButton.Location = new System.Drawing.Point(959, 469);
            this.costDetailButton.Name = "costDetailButton";
            this.costDetailButton.Size = new System.Drawing.Size(28, 131);
            this.costDetailButton.TabIndex = 14;
            this.costDetailButton.Text = "点击查看具体细节";
            this.costDetailButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.costDetailButton.UseVisualStyleBackColor = false;
            this.costDetailButton.Click += new System.EventHandler(this.costDetailButton_Click);
            // 
            // monthCostDetailChart
            // 
            chartArea2.InnerPlotPosition.Auto = false;
            chartArea2.InnerPlotPosition.Height = 65F;
            chartArea2.InnerPlotPosition.Width = 65F;
            chartArea2.InnerPlotPosition.X = 12F;
            chartArea2.InnerPlotPosition.Y = 22F;
            chartArea2.Name = "costDetailChartArea";
            chartArea2.Position.Auto = false;
            chartArea2.Position.Height = 100F;
            chartArea2.Position.Width = 100F;
            this.monthCostDetailChart.ChartAreas.Add(chartArea2);
            this.monthCostDetailChart.Location = new System.Drawing.Point(545, 405);
            this.monthCostDetailChart.Name = "monthCostDetailChart";
            series3.ChartArea = "costDetailChartArea";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.CustomProperties = "PieLineColor=Black, PieLabelStyle=Outside";
            series3.Label = "#VALX (#PERCENT{P2})";
            series3.Legend = "Legend1";
            series3.Name = "costSeries";
            this.monthCostDetailChart.Series.Add(series3);
            this.monthCostDetailChart.Size = new System.Drawing.Size(399, 300);
            this.monthCostDetailChart.TabIndex = 10;
            title2.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            title2.Name = "costDetailChartTitle";
            title2.Text = "支出细节";
            this.monthCostDetailChart.Titles.Add(title2);
            // 
            // MonthBenefitPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.monthBenefitPanel);
            this.Controls.Add(this.costDetailButton);
            this.Controls.Add(this.monthCostDetailChart);
            this.Controls.Add(this.monthBenefitChart);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.monthBenefitPageTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MonthBenefitPage";
            ((System.ComponentModel.ISupportInitialize)(this.monthBenefitChart)).EndInit();
            this.monthBenefitPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.monthCostDetailChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label monthBenefitPageTitle;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart monthBenefitChart;
        private System.Windows.Forms.Panel monthBenefitPanel;
        private System.Windows.Forms.Button dayDetailButton;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label dayBenefitLabel;
        private System.Windows.Forms.Label dayCostLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label dayIncomeLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label dayLabel;
        private System.Windows.Forms.Label benefitDetailLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label totalBenefitLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label totalCostLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label totalIncomeLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox daySelectionDropdown;
        private System.Windows.Forms.Button costDetailButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart monthCostDetailChart;
    }
}
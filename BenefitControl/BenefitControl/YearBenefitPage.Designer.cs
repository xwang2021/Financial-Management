namespace BenefitControl
{
    partial class YearBenefitPage
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea17 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series25 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series26 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title17 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea18 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series27 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title18 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.yearBenefitPageTitle = new System.Windows.Forms.Label();
            this.returnButton = new System.Windows.Forms.Button();
            this.yearBenefitChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.yearBenefitPanel = new System.Windows.Forms.Panel();
            this.monthSelectionDropdown = new System.Windows.Forms.ComboBox();
            this.monthDetailButton = new System.Windows.Forms.Button();
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
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.monthBenefitLabel = new System.Windows.Forms.Label();
            this.monthCostLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.monthIncomeLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.monthLabel = new System.Windows.Forms.Label();
            this.benefitDetailLabel = new System.Windows.Forms.Label();
            this.linePanel = new System.Windows.Forms.Panel();
            this.costDetailButton = new System.Windows.Forms.Button();
            this.yearCostDetailChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.yearBenefitChart)).BeginInit();
            this.yearBenefitPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yearCostDetailChart)).BeginInit();
            this.SuspendLayout();
            // 
            // yearBenefitPageTitle
            // 
            this.yearBenefitPageTitle.Font = new System.Drawing.Font("楷体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.yearBenefitPageTitle.Location = new System.Drawing.Point(263, 60);
            this.yearBenefitPageTitle.Name = "yearBenefitPageTitle";
            this.yearBenefitPageTitle.Size = new System.Drawing.Size(489, 71);
            this.yearBenefitPageTitle.TabIndex = 4;
            this.yearBenefitPageTitle.Text = "饭店流水/年份";
            this.yearBenefitPageTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // returnButton
            // 
            this.returnButton.BackColor = System.Drawing.Color.White;
            this.returnButton.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.returnButton.Location = new System.Drawing.Point(865, 35);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(105, 39);
            this.returnButton.TabIndex = 7;
            this.returnButton.Text = "返回";
            this.returnButton.UseVisualStyleBackColor = false;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // yearBenefitChart
            // 
            chartArea17.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea17.Name = "ChartArea1";
            this.yearBenefitChart.ChartAreas.Add(chartArea17);
            legend9.Name = "chartLegend";
            this.yearBenefitChart.Legends.Add(legend9);
            this.yearBenefitChart.Location = new System.Drawing.Point(12, 134);
            this.yearBenefitChart.Name = "yearBenefitChart";
            series25.ChartArea = "ChartArea1";
            series25.Legend = "chartLegend";
            series25.LegendText = "支出";
            series25.Name = "costSeries";
            series26.ChartArea = "ChartArea1";
            series26.Legend = "chartLegend";
            series26.LegendText = "收入";
            series26.Name = "incomeSeries";
            this.yearBenefitChart.Series.Add(series25);
            this.yearBenefitChart.Series.Add(series26);
            this.yearBenefitChart.Size = new System.Drawing.Size(984, 215);
            this.yearBenefitChart.TabIndex = 8;
            title17.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title17.Name = "ChartTitle";
            title17.Text = "收入-支出 详表";
            this.yearBenefitChart.Titles.Add(title17);
            // 
            // yearBenefitPanel
            // 
            this.yearBenefitPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.yearBenefitPanel.Controls.Add(this.monthSelectionDropdown);
            this.yearBenefitPanel.Controls.Add(this.monthDetailButton);
            this.yearBenefitPanel.Controls.Add(this.tableLayoutPanel1);
            this.yearBenefitPanel.Controls.Add(this.label15);
            this.yearBenefitPanel.Controls.Add(this.label14);
            this.yearBenefitPanel.Controls.Add(this.monthBenefitLabel);
            this.yearBenefitPanel.Controls.Add(this.monthCostLabel);
            this.yearBenefitPanel.Controls.Add(this.label11);
            this.yearBenefitPanel.Controls.Add(this.monthIncomeLabel);
            this.yearBenefitPanel.Controls.Add(this.label6);
            this.yearBenefitPanel.Controls.Add(this.label5);
            this.yearBenefitPanel.Controls.Add(this.label4);
            this.yearBenefitPanel.Controls.Add(this.monthLabel);
            this.yearBenefitPanel.Controls.Add(this.benefitDetailLabel);
            this.yearBenefitPanel.Location = new System.Drawing.Point(47, 405);
            this.yearBenefitPanel.Name = "yearBenefitPanel";
            this.yearBenefitPanel.Size = new System.Drawing.Size(397, 300);
            this.yearBenefitPanel.TabIndex = 11;
            // 
            // monthSelectionDropdown
            // 
            this.monthSelectionDropdown.BackColor = System.Drawing.Color.White;
            this.monthSelectionDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.monthSelectionDropdown.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.monthSelectionDropdown.Font = new System.Drawing.Font("宋体", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.monthSelectionDropdown.ForeColor = System.Drawing.SystemColors.WindowText;
            this.monthSelectionDropdown.FormattingEnabled = true;
            this.monthSelectionDropdown.Location = new System.Drawing.Point(290, 129);
            this.monthSelectionDropdown.Name = "monthSelectionDropdown";
            this.monthSelectionDropdown.Size = new System.Drawing.Size(89, 25);
            this.monthSelectionDropdown.TabIndex = 12;
            this.monthSelectionDropdown.SelectedIndexChanged += new System.EventHandler(this.monthSelectionDropdown_SelectedIndexChanged);
            // 
            // monthDetailButton
            // 
            this.monthDetailButton.BackColor = System.Drawing.Color.White;
            this.monthDetailButton.Font = new System.Drawing.Font("楷体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.monthDetailButton.Location = new System.Drawing.Point(139, 129);
            this.monthDetailButton.Name = "monthDetailButton";
            this.monthDetailButton.Size = new System.Drawing.Size(112, 25);
            this.monthDetailButton.TabIndex = 12;
            this.monthDetailButton.Text = "查看该月流水";
            this.monthDetailButton.UseVisualStyleBackColor = false;
            this.monthDetailButton.Click += new System.EventHandler(this.monthDetailButton_Click);
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 35);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(397, 82);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.totalBenefitLabel);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(91, 53);
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
            this.panel2.Location = new System.Drawing.Point(91, 27);
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
            this.panel1.Location = new System.Drawing.Point(91, 1);
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
            // monthBenefitLabel
            // 
            this.monthBenefitLabel.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.monthBenefitLabel.Location = new System.Drawing.Point(75, 246);
            this.monthBenefitLabel.Margin = new System.Windows.Forms.Padding(0);
            this.monthBenefitLabel.Name = "monthBenefitLabel";
            this.monthBenefitLabel.Size = new System.Drawing.Size(165, 23);
            this.monthBenefitLabel.TabIndex = 17;
            this.monthBenefitLabel.Text = "1,000,000,000";
            this.monthBenefitLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // monthCostLabel
            // 
            this.monthCostLabel.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.monthCostLabel.Location = new System.Drawing.Point(75, 207);
            this.monthCostLabel.Margin = new System.Windows.Forms.Padding(0);
            this.monthCostLabel.Name = "monthCostLabel";
            this.monthCostLabel.Size = new System.Drawing.Size(165, 23);
            this.monthCostLabel.TabIndex = 16;
            this.monthCostLabel.Text = "1,000,000,000";
            this.monthCostLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
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
            // monthIncomeLabel
            // 
            this.monthIncomeLabel.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.monthIncomeLabel.Location = new System.Drawing.Point(75, 168);
            this.monthIncomeLabel.Margin = new System.Windows.Forms.Padding(0);
            this.monthIncomeLabel.Name = "monthIncomeLabel";
            this.monthIncomeLabel.Size = new System.Drawing.Size(165, 23);
            this.monthIncomeLabel.TabIndex = 15;
            this.monthIncomeLabel.Text = "1,000,000,000";
            this.monthIncomeLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
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
            // monthLabel
            // 
            this.monthLabel.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.monthLabel.Location = new System.Drawing.Point(17, 131);
            this.monthLabel.Name = "monthLabel";
            this.monthLabel.Size = new System.Drawing.Size(116, 23);
            this.monthLabel.TabIndex = 13;
            this.monthLabel.Text = "十二月细节";
            // 
            // benefitDetailLabel
            // 
            this.benefitDetailLabel.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.benefitDetailLabel.Location = new System.Drawing.Point(0, -1);
            this.benefitDetailLabel.Margin = new System.Windows.Forms.Padding(0);
            this.benefitDetailLabel.Name = "benefitDetailLabel";
            this.benefitDetailLabel.Size = new System.Drawing.Size(396, 36);
            this.benefitDetailLabel.TabIndex = 4;
            this.benefitDetailLabel.Text = "流水细节";
            this.benefitDetailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // linePanel
            // 
            this.linePanel.Location = new System.Drawing.Point(12, 355);
            this.linePanel.Name = "linePanel";
            this.linePanel.Size = new System.Drawing.Size(984, 27);
            this.linePanel.TabIndex = 14;
            // 
            // costDetailButton
            // 
            this.costDetailButton.BackColor = System.Drawing.Color.White;
            this.costDetailButton.Font = new System.Drawing.Font("楷体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.costDetailButton.Location = new System.Drawing.Point(959, 469);
            this.costDetailButton.Name = "costDetailButton";
            this.costDetailButton.Size = new System.Drawing.Size(28, 131);
            this.costDetailButton.TabIndex = 13;
            this.costDetailButton.Text = "点击查看具体细节";
            this.costDetailButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.costDetailButton.UseVisualStyleBackColor = false;
            this.costDetailButton.Click += new System.EventHandler(this.costDetailButton_Click);
            // 
            // yearCostDetailChart
            // 
            chartArea18.InnerPlotPosition.Auto = false;
            chartArea18.InnerPlotPosition.Height = 65F;
            chartArea18.InnerPlotPosition.Width = 65F;
            chartArea18.InnerPlotPosition.X = 12F;
            chartArea18.InnerPlotPosition.Y = 22F;
            chartArea18.Name = "costDetailChartArea";
            chartArea18.Position.Auto = false;
            chartArea18.Position.Height = 100F;
            chartArea18.Position.Width = 100F;
            this.yearCostDetailChart.ChartAreas.Add(chartArea18);
            this.yearCostDetailChart.Location = new System.Drawing.Point(545, 405);
            this.yearCostDetailChart.Name = "yearCostDetailChart";
            series27.ChartArea = "costDetailChartArea";
            series27.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series27.CustomProperties = "PieLineColor=Black, PieLabelStyle=Outside";
            series27.Label = "#VALX(#PERCENT{P2})";
            series27.Name = "costSeries";
            this.yearCostDetailChart.Series.Add(series27);
            this.yearCostDetailChart.Size = new System.Drawing.Size(399, 300);
            this.yearCostDetailChart.TabIndex = 9;
            title18.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            title18.Name = "costDetailChartTitle";
            title18.Text = "支出细节";
            this.yearCostDetailChart.Titles.Add(title18);
            // 
            // YearBenefitPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.linePanel);
            this.Controls.Add(this.costDetailButton);
            this.Controls.Add(this.yearCostDetailChart);
            this.Controls.Add(this.yearBenefitPanel);
            this.Controls.Add(this.yearBenefitChart);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.yearBenefitPageTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "YearBenefitPage";
            ((System.ComponentModel.ISupportInitialize)(this.yearBenefitChart)).EndInit();
            this.yearBenefitPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.yearCostDetailChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label yearBenefitPageTitle;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart yearBenefitChart;
        private System.Windows.Forms.Panel yearBenefitPanel;
        private System.Windows.Forms.Label benefitDetailLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button monthDetailButton;
        private System.Windows.Forms.Label monthLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label totalIncomeLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label totalBenefitLabel;
        private System.Windows.Forms.Label totalCostLabel;
        private System.Windows.Forms.Label monthIncomeLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label monthCostLabel;
        private System.Windows.Forms.Label monthBenefitLabel;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox monthSelectionDropdown;
        private System.Windows.Forms.Panel linePanel;
        private System.Windows.Forms.Button costDetailButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart yearCostDetailChart;
    }
}
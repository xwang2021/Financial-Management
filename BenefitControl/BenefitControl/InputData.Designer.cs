namespace BenefitControl
{
    partial class InputData
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.inputPageTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.currentDayLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.inputTable = new System.Windows.Forms.DataGridView();
            this.costType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.removeColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label12 = new System.Windows.Forms.Label();
            this.addCostButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.costAmountTextbox = new System.Windows.Forms.TextBox();
            this.costQuantityTextbox = new System.Windows.Forms.TextBox();
            this.costTypeSelectionDropdown = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.costNameTextbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.incomeTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.restaurantLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputTable)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputPageTitle
            // 
            this.inputPageTitle.Font = new System.Drawing.Font("楷体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.inputPageTitle.Location = new System.Drawing.Point(260, 60);
            this.inputPageTitle.Name = "inputPageTitle";
            this.inputPageTitle.Size = new System.Drawing.Size(489, 71);
            this.inputPageTitle.TabIndex = 7;
            this.inputPageTitle.Text = "请输入当日收支";
            this.inputPageTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(279, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "日期：";
            // 
            // currentDayLabel
            // 
            this.currentDayLabel.AutoSize = true;
            this.currentDayLabel.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.currentDayLabel.Location = new System.Drawing.Point(343, 131);
            this.currentDayLabel.Name = "currentDayLabel";
            this.currentDayLabel.Size = new System.Drawing.Size(154, 24);
            this.currentDayLabel.TabIndex = 9;
            this.currentDayLabel.Text = "2017年5月8日";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.67933F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.32068F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(29, 178);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.87554F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.12447F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(949, 522);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.inputTable);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.addCostButton);
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(216, 68);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(732, 453);
            this.panel2.TabIndex = 11;
            // 
            // inputTable
            // 
            this.inputTable.AllowUserToAddRows = false;
            this.inputTable.AllowUserToResizeColumns = false;
            this.inputTable.AllowUserToResizeRows = false;
            this.inputTable.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.inputTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.inputTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inputTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.costType,
            this.costName,
            this.costAmount,
            this.costQuantity,
            this.costUnitPrice,
            this.removeColumn});
            this.inputTable.Location = new System.Drawing.Point(-1, 92);
            this.inputTable.Margin = new System.Windows.Forms.Padding(0);
            this.inputTable.MultiSelect = false;
            this.inputTable.Name = "inputTable";
            this.inputTable.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.inputTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.inputTable.RowHeadersVisible = false;
            this.inputTable.RowTemplate.Height = 23;
            this.inputTable.ShowEditingIcon = false;
            this.inputTable.Size = new System.Drawing.Size(734, 361);
            this.inputTable.TabIndex = 16;
            this.inputTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.inputTable_CellContentClick);
            // 
            // costType
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.costType.DefaultCellStyle = dataGridViewCellStyle2;
            this.costType.HeaderText = "  类别";
            this.costType.Name = "costType";
            this.costType.ReadOnly = true;
            this.costType.Width = 136;
            // 
            // costName
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.costName.DefaultCellStyle = dataGridViewCellStyle3;
            this.costName.HeaderText = "  名称";
            this.costName.Name = "costName";
            this.costName.ReadOnly = true;
            this.costName.Width = 137;
            // 
            // costAmount
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.costAmount.DefaultCellStyle = dataGridViewCellStyle4;
            this.costAmount.HeaderText = "  金额(円)";
            this.costAmount.Name = "costAmount";
            this.costAmount.ReadOnly = true;
            this.costAmount.Width = 137;
            // 
            // costQuantity
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.costQuantity.DefaultCellStyle = dataGridViewCellStyle5;
            this.costQuantity.HeaderText = "  数量";
            this.costQuantity.Name = "costQuantity";
            this.costQuantity.ReadOnly = true;
            this.costQuantity.Width = 137;
            // 
            // costUnitPrice
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.costUnitPrice.DefaultCellStyle = dataGridViewCellStyle6;
            this.costUnitPrice.HeaderText = "  单价(円)";
            this.costUnitPrice.Name = "costUnitPrice";
            this.costUnitPrice.ReadOnly = true;
            this.costUnitPrice.Width = 137;
            // 
            // removeColumn
            // 
            this.removeColumn.HeaderText = "";
            this.removeColumn.Name = "removeColumn";
            this.removeColumn.ReadOnly = true;
            this.removeColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.removeColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.removeColumn.Width = 28;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(-1, 60);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(734, 32);
            this.label12.TabIndex = 1;
            this.label12.Text = "支出列表";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addCostButton
            // 
            this.addCostButton.BackColor = System.Drawing.Color.White;
            this.addCostButton.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.addCostButton.Location = new System.Drawing.Point(672, -1);
            this.addCostButton.Margin = new System.Windows.Forms.Padding(0);
            this.addCostButton.Name = "addCostButton";
            this.addCostButton.Size = new System.Drawing.Size(61, 62);
            this.addCostButton.TabIndex = 1;
            this.addCostButton.Text = "添加";
            this.addCostButton.UseVisualStyleBackColor = false;
            this.addCostButton.Click += new System.EventHandler(this.addCostButton_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.costAmountTextbox, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.costQuantityTextbox, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.costTypeSelectionDropdown, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label11, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.costNameTextbox, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label10, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label9, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(674, 60);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // costAmountTextbox
            // 
            this.costAmountTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.costAmountTextbox.Font = new System.Drawing.Font("楷体", 17.5F);
            this.costAmountTextbox.Location = new System.Drawing.Point(337, 30);
            this.costAmountTextbox.Margin = new System.Windows.Forms.Padding(0);
            this.costAmountTextbox.Name = "costAmountTextbox";
            this.costAmountTextbox.Size = new System.Drawing.Size(167, 27);
            this.costAmountTextbox.TabIndex = 4;
            this.costAmountTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // costQuantityTextbox
            // 
            this.costQuantityTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.costQuantityTextbox.Font = new System.Drawing.Font("楷体", 17.5F);
            this.costQuantityTextbox.Location = new System.Drawing.Point(505, 30);
            this.costQuantityTextbox.Margin = new System.Windows.Forms.Padding(0);
            this.costQuantityTextbox.Name = "costQuantityTextbox";
            this.costQuantityTextbox.Size = new System.Drawing.Size(167, 27);
            this.costQuantityTextbox.TabIndex = 5;
            this.costQuantityTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // costTypeSelectionDropdown
            // 
            this.costTypeSelectionDropdown.BackColor = System.Drawing.Color.White;
            this.costTypeSelectionDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.costTypeSelectionDropdown.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.costTypeSelectionDropdown.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.costTypeSelectionDropdown.FormattingEnabled = true;
            this.costTypeSelectionDropdown.Items.AddRange(new object[] {
            "-请选择类别-"});
            this.costTypeSelectionDropdown.Location = new System.Drawing.Point(1, 30);
            this.costTypeSelectionDropdown.Margin = new System.Windows.Forms.Padding(0);
            this.costTypeSelectionDropdown.Name = "costTypeSelectionDropdown";
            this.costTypeSelectionDropdown.Size = new System.Drawing.Size(167, 29);
            this.costTypeSelectionDropdown.TabIndex = 1;
            this.costTypeSelectionDropdown.SelectedIndexChanged += new System.EventHandler(this.costTypeComboBox_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(505, 1);
            this.label11.Margin = new System.Windows.Forms.Padding(0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(167, 28);
            this.label11.TabIndex = 3;
            this.label11.Text = "数量";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // costNameTextbox
            // 
            this.costNameTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.costNameTextbox.Font = new System.Drawing.Font("楷体", 17.5F);
            this.costNameTextbox.Location = new System.Drawing.Point(169, 30);
            this.costNameTextbox.Margin = new System.Windows.Forms.Padding(0);
            this.costNameTextbox.Name = "costNameTextbox";
            this.costNameTextbox.Size = new System.Drawing.Size(167, 27);
            this.costNameTextbox.TabIndex = 3;
            this.costNameTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(1, 1);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(167, 28);
            this.label8.TabIndex = 0;
            this.label8.Text = "类别";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(337, 1);
            this.label10.Margin = new System.Windows.Forms.Padding(0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(167, 28);
            this.label10.TabIndex = 2;
            this.label10.Text = "金额";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(169, 1);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(167, 28);
            this.label9.TabIndex = 1;
            this.label9.Text = "名称";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.incomeTextbox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(1, 68);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(214, 453);
            this.panel1.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(5, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "请输入收入金额";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(175, 162);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(47, 27);
            this.label7.TabIndex = 14;
            this.label7.Text = " 円";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // incomeTextbox
            // 
            this.incomeTextbox.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.incomeTextbox.Location = new System.Drawing.Point(5, 162);
            this.incomeTextbox.Margin = new System.Windows.Forms.Padding(0);
            this.incomeTextbox.Name = "incomeTextbox";
            this.incomeTextbox.Size = new System.Drawing.Size(170, 31);
            this.incomeTextbox.TabIndex = 11;
            this.incomeTextbox.Text = "150,000,000.00";
            this.incomeTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("楷体", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(1, 1);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 66);
            this.label3.TabIndex = 11;
            this.label3.Text = "收入";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("楷体", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(216, 1);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(732, 66);
            this.label4.TabIndex = 12;
            this.label4.Text = "支出";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(519, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "餐厅：";
            // 
            // ReturnButton
            // 
            this.ReturnButton.BackColor = System.Drawing.Color.White;
            this.ReturnButton.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ReturnButton.Location = new System.Drawing.Point(865, 35);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(105, 39);
            this.ReturnButton.TabIndex = 13;
            this.ReturnButton.Text = "返回";
            this.ReturnButton.UseVisualStyleBackColor = false;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.White;
            this.saveButton.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.saveButton.Location = new System.Drawing.Point(865, 126);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(105, 32);
            this.saveButton.TabIndex = 14;
            this.saveButton.Text = "保存";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // restaurantLabel
            // 
            this.restaurantLabel.AutoSize = true;
            this.restaurantLabel.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.restaurantLabel.Location = new System.Drawing.Point(582, 130);
            this.restaurantLabel.Name = "restaurantLabel";
            this.restaurantLabel.Size = new System.Drawing.Size(106, 24);
            this.restaurantLabel.TabIndex = 15;
            this.restaurantLabel.Text = "牡丹餐厅";
            // 
            // InputData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.restaurantLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.currentDayLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputPageTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "InputData";
            this.Load += new System.EventHandler(this.InputData_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inputTable)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label inputPageTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label currentDayLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox incomeTextbox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button addCostButton;
        private System.Windows.Forms.ComboBox costTypeSelectionDropdown;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox costNameTextbox;
        private System.Windows.Forms.TextBox costQuantityTextbox;
        private System.Windows.Forms.TextBox costAmountTextbox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label restaurantLabel;
        private System.Windows.Forms.DataGridView inputTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn costType;
        private System.Windows.Forms.DataGridViewTextBoxColumn costName;
        private System.Windows.Forms.DataGridViewTextBoxColumn costAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn costQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn costUnitPrice;
        private System.Windows.Forms.DataGridViewButtonColumn removeColumn;
    }
}
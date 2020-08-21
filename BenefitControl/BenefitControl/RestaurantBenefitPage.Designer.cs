namespace BenefitControl
{
    partial class RestaurantBenefitPage
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
            this.yearLabel = new System.Windows.Forms.Label();
            this.yearBenefitPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.monthlyBenefitButton = new System.Windows.Forms.Button();
            this.benefitTextLabel = new System.Windows.Forms.Label();
            this.expenseTextLabel = new System.Windows.Forms.Label();
            this.incomeTextLabel = new System.Windows.Forms.Label();
            this.yearTextLabel = new System.Windows.Forms.Label();
            this.profitLabel = new System.Windows.Forms.Label();
            this.expenseLabel = new System.Windows.Forms.Label();
            this.incomeLabel = new System.Windows.Forms.Label();
            this.restaurantBenefitPageTitle = new System.Windows.Forms.Label();
            this.yearSelectionDropdown = new System.Windows.Forms.ComboBox();
            this.yearSelectionLabel = new System.Windows.Forms.Label();
            this.returnButton = new System.Windows.Forms.Button();
            this.yearBenefitPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Font = new System.Drawing.Font("楷体", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.yearLabel.Location = new System.Drawing.Point(146, 42);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(68, 27);
            this.yearLabel.TabIndex = 0;
            this.yearLabel.Text = "2017";
            // 
            // yearBenefitPanel
            // 
            this.yearBenefitPanel.Controls.Add(this.label3);
            this.yearBenefitPanel.Controls.Add(this.label2);
            this.yearBenefitPanel.Controls.Add(this.label1);
            this.yearBenefitPanel.Controls.Add(this.monthlyBenefitButton);
            this.yearBenefitPanel.Controls.Add(this.benefitTextLabel);
            this.yearBenefitPanel.Controls.Add(this.expenseTextLabel);
            this.yearBenefitPanel.Controls.Add(this.incomeTextLabel);
            this.yearBenefitPanel.Controls.Add(this.yearTextLabel);
            this.yearBenefitPanel.Controls.Add(this.profitLabel);
            this.yearBenefitPanel.Controls.Add(this.expenseLabel);
            this.yearBenefitPanel.Controls.Add(this.incomeLabel);
            this.yearBenefitPanel.Controls.Add(this.yearLabel);
            this.yearBenefitPanel.Location = new System.Drawing.Point(109, 184);
            this.yearBenefitPanel.Name = "yearBenefitPanel";
            this.yearBenefitPanel.Size = new System.Drawing.Size(376, 407);
            this.yearBenefitPanel.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(320, 316);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 34);
            this.label3.TabIndex = 7;
            this.label3.Text = " 円";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(320, 223);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 34);
            this.label2.TabIndex = 7;
            this.label2.Text = " 円";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(320, 133);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 34);
            this.label1.TabIndex = 6;
            this.label1.Text = " 円";
            // 
            // monthlyBenefitButton
            // 
            this.monthlyBenefitButton.BackColor = System.Drawing.Color.White;
            this.monthlyBenefitButton.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.monthlyBenefitButton.Location = new System.Drawing.Point(220, 41);
            this.monthlyBenefitButton.Name = "monthlyBenefitButton";
            this.monthlyBenefitButton.Size = new System.Drawing.Size(150, 30);
            this.monthlyBenefitButton.TabIndex = 6;
            this.monthlyBenefitButton.Text = "查看该年流水";
            this.monthlyBenefitButton.UseVisualStyleBackColor = false;
            this.monthlyBenefitButton.Click += new System.EventHandler(this.monthlyBenefitButton_Click);
            // 
            // benefitTextLabel
            // 
            this.benefitTextLabel.AutoSize = true;
            this.benefitTextLabel.Font = new System.Drawing.Font("楷体", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.benefitTextLabel.Location = new System.Drawing.Point(44, 314);
            this.benefitTextLabel.Name = "benefitTextLabel";
            this.benefitTextLabel.Size = new System.Drawing.Size(96, 27);
            this.benefitTextLabel.TabIndex = 6;
            this.benefitTextLabel.Text = "利润：";
            // 
            // expenseTextLabel
            // 
            this.expenseTextLabel.AutoSize = true;
            this.expenseTextLabel.Font = new System.Drawing.Font("楷体", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.expenseTextLabel.Location = new System.Drawing.Point(44, 223);
            this.expenseTextLabel.Name = "expenseTextLabel";
            this.expenseTextLabel.Size = new System.Drawing.Size(96, 27);
            this.expenseTextLabel.TabIndex = 5;
            this.expenseTextLabel.Text = "支出：";
            // 
            // incomeTextLabel
            // 
            this.incomeTextLabel.AutoSize = true;
            this.incomeTextLabel.Font = new System.Drawing.Font("楷体", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.incomeTextLabel.Location = new System.Drawing.Point(44, 133);
            this.incomeTextLabel.Name = "incomeTextLabel";
            this.incomeTextLabel.Size = new System.Drawing.Size(96, 27);
            this.incomeTextLabel.TabIndex = 4;
            this.incomeTextLabel.Text = "收入：";
            // 
            // yearTextLabel
            // 
            this.yearTextLabel.Font = new System.Drawing.Font("楷体", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.yearTextLabel.Location = new System.Drawing.Point(44, 42);
            this.yearTextLabel.Name = "yearTextLabel";
            this.yearTextLabel.Size = new System.Drawing.Size(96, 27);
            this.yearTextLabel.TabIndex = 3;
            this.yearTextLabel.Text = "年份：";
            // 
            // profitLabel
            // 
            this.profitLabel.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.profitLabel.Location = new System.Drawing.Point(134, 314);
            this.profitLabel.Name = "profitLabel";
            this.profitLabel.Size = new System.Drawing.Size(188, 27);
            this.profitLabel.TabIndex = 2;
            this.profitLabel.Text = "5800000";
            this.profitLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // expenseLabel
            // 
            this.expenseLabel.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.expenseLabel.Location = new System.Drawing.Point(130, 223);
            this.expenseLabel.Name = "expenseLabel";
            this.expenseLabel.Size = new System.Drawing.Size(192, 27);
            this.expenseLabel.TabIndex = 2;
            this.expenseLabel.Text = "61300000";
            this.expenseLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // incomeLabel
            // 
            this.incomeLabel.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.incomeLabel.Location = new System.Drawing.Point(126, 133);
            this.incomeLabel.Name = "incomeLabel";
            this.incomeLabel.Size = new System.Drawing.Size(196, 27);
            this.incomeLabel.TabIndex = 1;
            this.incomeLabel.Text = "71000000";
            this.incomeLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // restaurantBenefitPageTitle
            // 
            this.restaurantBenefitPageTitle.Font = new System.Drawing.Font("楷体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.restaurantBenefitPageTitle.Location = new System.Drawing.Point(263, 60);
            this.restaurantBenefitPageTitle.Name = "restaurantBenefitPageTitle";
            this.restaurantBenefitPageTitle.Size = new System.Drawing.Size(489, 71);
            this.restaurantBenefitPageTitle.TabIndex = 3;
            this.restaurantBenefitPageTitle.Text = "饭店流水/餐厅";
            this.restaurantBenefitPageTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yearSelectionDropdown
            // 
            this.yearSelectionDropdown.BackColor = System.Drawing.Color.White;
            this.yearSelectionDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yearSelectionDropdown.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.yearSelectionDropdown.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.yearSelectionDropdown.FormattingEnabled = true;
            this.yearSelectionDropdown.Location = new System.Drawing.Point(617, 229);
            this.yearSelectionDropdown.Name = "yearSelectionDropdown";
            this.yearSelectionDropdown.Size = new System.Drawing.Size(195, 28);
            this.yearSelectionDropdown.TabIndex = 4;
            this.yearSelectionDropdown.SelectedIndexChanged += new System.EventHandler(this.yearSelectionDropdown_SelectedIndexChanged);
            // 
            // yearSelectionLabel
            // 
            this.yearSelectionLabel.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.yearSelectionLabel.Location = new System.Drawing.Point(615, 201);
            this.yearSelectionLabel.Name = "yearSelectionLabel";
            this.yearSelectionLabel.Size = new System.Drawing.Size(197, 23);
            this.yearSelectionLabel.TabIndex = 5;
            this.yearSelectionLabel.Text = "选择想要查看的年份";
            // 
            // returnButton
            // 
            this.returnButton.BackColor = System.Drawing.Color.White;
            this.returnButton.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.returnButton.Location = new System.Drawing.Point(865, 38);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(105, 39);
            this.returnButton.TabIndex = 6;
            this.returnButton.Text = "返回";
            this.returnButton.UseVisualStyleBackColor = false;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // RestaurantBenefitPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.yearSelectionLabel);
            this.Controls.Add(this.yearSelectionDropdown);
            this.Controls.Add(this.restaurantBenefitPageTitle);
            this.Controls.Add(this.yearBenefitPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "RestaurantBenefitPage";
            this.Load += new System.EventHandler(this.RestaurantBenefitPage_Load);
            this.yearBenefitPanel.ResumeLayout(false);
            this.yearBenefitPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Panel yearBenefitPanel;
        private System.Windows.Forms.Label expenseLabel;
        private System.Windows.Forms.Label incomeLabel;
        private System.Windows.Forms.Label profitLabel;
        private System.Windows.Forms.Label yearTextLabel;
        private System.Windows.Forms.Label benefitTextLabel;
        private System.Windows.Forms.Label expenseTextLabel;
        private System.Windows.Forms.Label incomeTextLabel;
        private System.Windows.Forms.Label restaurantBenefitPageTitle;
        private System.Windows.Forms.ComboBox yearSelectionDropdown;
        private System.Windows.Forms.Label yearSelectionLabel;
        private System.Windows.Forms.Button monthlyBenefitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button returnButton;
    }
}
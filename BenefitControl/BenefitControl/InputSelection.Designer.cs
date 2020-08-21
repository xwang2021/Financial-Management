namespace BenefitControl
{
    partial class InputSelection
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
            this.inputSelectionPageTitle = new System.Windows.Forms.Label();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.restaurantSelectionDropdown = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.inputButton = new System.Windows.Forms.Button();
            this.dateLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputSelectionPageTitle
            // 
            this.inputSelectionPageTitle.Font = new System.Drawing.Font("楷体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.inputSelectionPageTitle.Location = new System.Drawing.Point(260, 60);
            this.inputSelectionPageTitle.Name = "inputSelectionPageTitle";
            this.inputSelectionPageTitle.Size = new System.Drawing.Size(489, 71);
            this.inputSelectionPageTitle.TabIndex = 8;
            this.inputSelectionPageTitle.Text = "日期/餐厅选择";
            this.inputSelectionPageTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ReturnButton
            // 
            this.ReturnButton.BackColor = System.Drawing.Color.White;
            this.ReturnButton.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ReturnButton.Location = new System.Drawing.Point(865, 35);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(105, 39);
            this.ReturnButton.TabIndex = 14;
            this.ReturnButton.Text = "返回";
            this.ReturnButton.UseVisualStyleBackColor = false;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // restaurantSelectionDropdown
            // 
            this.restaurantSelectionDropdown.BackColor = System.Drawing.Color.White;
            this.restaurantSelectionDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.restaurantSelectionDropdown.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.restaurantSelectionDropdown.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.restaurantSelectionDropdown.FormattingEnabled = true;
            this.restaurantSelectionDropdown.Items.AddRange(new object[] {
            "-请选择餐厅-"});
            this.restaurantSelectionDropdown.Location = new System.Drawing.Point(504, 239);
            this.restaurantSelectionDropdown.Name = "restaurantSelectionDropdown";
            this.restaurantSelectionDropdown.Size = new System.Drawing.Size(154, 28);
            this.restaurantSelectionDropdown.TabIndex = 15;
            this.restaurantSelectionDropdown.SelectedIndexChanged += new System.EventHandler(this.restaurantSelectionDropdown_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("楷体", 18F);
            this.label1.Location = new System.Drawing.Point(362, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 28);
            this.label1.TabIndex = 16;
            this.label1.Text = "餐厅列表：";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("楷体", 15F);
            this.dateTimePicker.Location = new System.Drawing.Point(504, 341);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(154, 30);
            this.dateTimePicker.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("楷体", 18F);
            this.label2.Location = new System.Drawing.Point(405, 341);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 28);
            this.label2.TabIndex = 19;
            this.label2.Text = "日期：";
            // 
            // inputButton
            // 
            this.inputButton.BackColor = System.Drawing.Color.White;
            this.inputButton.Font = new System.Drawing.Font("楷体", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.inputButton.Location = new System.Drawing.Point(366, 445);
            this.inputButton.Name = "inputButton";
            this.inputButton.Size = new System.Drawing.Size(292, 52);
            this.inputButton.TabIndex = 20;
            this.inputButton.Text = "输入收支数据";
            this.inputButton.UseVisualStyleBackColor = false;
            this.inputButton.Click += new System.EventHandler(this.inputButton_Click);
            // 
            // dateLabel
            // 
            this.dateLabel.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateLabel.Location = new System.Drawing.Point(504, 340);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(154, 30);
            this.dateLabel.TabIndex = 21;
            this.dateLabel.Text = "2017年1月1日";
            this.dateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InputSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.inputButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.restaurantSelectionDropdown);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.inputSelectionPageTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "InputSelection";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label inputSelectionPageTitle;
        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.ComboBox restaurantSelectionDropdown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button inputButton;
        private System.Windows.Forms.Label dateLabel;
    }
}
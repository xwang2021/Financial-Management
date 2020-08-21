namespace BenefitControl
{
    partial class FrontPage
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.checkBenefitButton = new System.Windows.Forms.Button();
            this.monthBenefitPageTitle = new System.Windows.Forms.Label();
            this.inputButton = new System.Windows.Forms.Button();
            this.actionSelectionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkBenefitButton
            // 
            this.checkBenefitButton.AutoSize = true;
            this.checkBenefitButton.BackColor = System.Drawing.Color.White;
            this.checkBenefitButton.Font = new System.Drawing.Font("楷体", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBenefitButton.Location = new System.Drawing.Point(374, 400);
            this.checkBenefitButton.Name = "checkBenefitButton";
            this.checkBenefitButton.Size = new System.Drawing.Size(266, 89);
            this.checkBenefitButton.TabIndex = 1;
            this.checkBenefitButton.Text = "查看流水";
            this.checkBenefitButton.UseVisualStyleBackColor = false;
            this.checkBenefitButton.Click += new System.EventHandler(this.checkBenefitButton_Click);
            // 
            // monthBenefitPageTitle
            // 
            this.monthBenefitPageTitle.Font = new System.Drawing.Font("楷体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.monthBenefitPageTitle.Location = new System.Drawing.Point(260, 60);
            this.monthBenefitPageTitle.Name = "monthBenefitPageTitle";
            this.monthBenefitPageTitle.Size = new System.Drawing.Size(489, 71);
            this.monthBenefitPageTitle.TabIndex = 6;
            this.monthBenefitPageTitle.Text = "牡丹饭店账目管理软件";
            this.monthBenefitPageTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inputButton
            // 
            this.inputButton.AutoSize = true;
            this.inputButton.BackColor = System.Drawing.Color.White;
            this.inputButton.Font = new System.Drawing.Font("楷体", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.inputButton.Location = new System.Drawing.Point(374, 255);
            this.inputButton.Name = "inputButton";
            this.inputButton.Size = new System.Drawing.Size(266, 89);
            this.inputButton.TabIndex = 7;
            this.inputButton.Text = "输入收支数据";
            this.inputButton.UseVisualStyleBackColor = false;
            this.inputButton.Click += new System.EventHandler(this.inputButton_Click);
            // 
            // actionSelectionLabel
            // 
            this.actionSelectionLabel.Font = new System.Drawing.Font("楷体", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.actionSelectionLabel.Location = new System.Drawing.Point(429, 188);
            this.actionSelectionLabel.Name = "actionSelectionLabel";
            this.actionSelectionLabel.Size = new System.Drawing.Size(156, 31);
            this.actionSelectionLabel.TabIndex = 8;
            this.actionSelectionLabel.Text = "请选择";
            this.actionSelectionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrontPage
            // 
            this.AcceptButton = this.inputButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.actionSelectionLabel);
            this.Controls.Add(this.inputButton);
            this.Controls.Add(this.monthBenefitPageTitle);
            this.Controls.Add(this.checkBenefitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrontPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button checkBenefitButton;
        private System.Windows.Forms.Label monthBenefitPageTitle;
        private System.Windows.Forms.Button inputButton;
        private System.Windows.Forms.Label actionSelectionLabel;
    }
}


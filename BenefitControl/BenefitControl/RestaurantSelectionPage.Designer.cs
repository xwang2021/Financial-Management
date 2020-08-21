namespace BenefitControl
{
    partial class RestaurantSelectionPage
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
            this.restaurantListPanel = new System.Windows.Forms.Panel();
            this.restaurantListLabel = new System.Windows.Forms.Label();
            this.addRestaurantButton = new System.Windows.Forms.Button();
            this.restaurantPageTitle = new System.Windows.Forms.Label();
            this.newRestaurantBox = new System.Windows.Forms.TextBox();
            this.returnButton = new System.Windows.Forms.Button();
            this.restaurantListPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // restaurantListPanel
            // 
            this.restaurantListPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.restaurantListPanel.Controls.Add(this.restaurantListLabel);
            this.restaurantListPanel.Location = new System.Drawing.Point(109, 184);
            this.restaurantListPanel.Margin = new System.Windows.Forms.Padding(0);
            this.restaurantListPanel.Name = "restaurantListPanel";
            this.restaurantListPanel.Size = new System.Drawing.Size(325, 407);
            this.restaurantListPanel.TabIndex = 0;
            // 
            // restaurantListLabel
            // 
            this.restaurantListLabel.BackColor = System.Drawing.Color.LightCoral;
            this.restaurantListLabel.Font = new System.Drawing.Font("楷体", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.restaurantListLabel.Location = new System.Drawing.Point(0, 0);
            this.restaurantListLabel.Margin = new System.Windows.Forms.Padding(0);
            this.restaurantListLabel.Name = "restaurantListLabel";
            this.restaurantListLabel.Size = new System.Drawing.Size(325, 60);
            this.restaurantListLabel.TabIndex = 1;
            this.restaurantListLabel.Text = "餐厅列表";
            this.restaurantListLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addRestaurantButton
            // 
            this.addRestaurantButton.BackColor = System.Drawing.Color.White;
            this.addRestaurantButton.Font = new System.Drawing.Font("楷体", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.addRestaurantButton.Location = new System.Drawing.Point(542, 383);
            this.addRestaurantButton.Name = "addRestaurantButton";
            this.addRestaurantButton.Size = new System.Drawing.Size(325, 61);
            this.addRestaurantButton.TabIndex = 1;
            this.addRestaurantButton.Text = "添加一个新餐厅";
            this.addRestaurantButton.UseVisualStyleBackColor = false;
            this.addRestaurantButton.Click += new System.EventHandler(this.addRestaurantButton_Click);
            // 
            // restaurantPageTitle
            // 
            this.restaurantPageTitle.Font = new System.Drawing.Font("楷体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.restaurantPageTitle.Location = new System.Drawing.Point(263, 60);
            this.restaurantPageTitle.Name = "restaurantPageTitle";
            this.restaurantPageTitle.Size = new System.Drawing.Size(489, 71);
            this.restaurantPageTitle.TabIndex = 2;
            this.restaurantPageTitle.Text = "请选择想要查看的餐厅";
            this.restaurantPageTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // newRestaurantBox
            // 
            this.newRestaurantBox.Font = new System.Drawing.Font("宋体", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.newRestaurantBox.Location = new System.Drawing.Point(542, 317);
            this.newRestaurantBox.Name = "newRestaurantBox";
            this.newRestaurantBox.Size = new System.Drawing.Size(325, 38);
            this.newRestaurantBox.TabIndex = 3;
            // 
            // returnButton
            // 
            this.returnButton.BackColor = System.Drawing.Color.White;
            this.returnButton.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.returnButton.Location = new System.Drawing.Point(865, 35);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(105, 39);
            this.returnButton.TabIndex = 10;
            this.returnButton.Text = "返回";
            this.returnButton.UseVisualStyleBackColor = false;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // RestaurantSelectionPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.addRestaurantButton);
            this.Controls.Add(this.newRestaurantBox);
            this.Controls.Add(this.restaurantPageTitle);
            this.Controls.Add(this.restaurantListPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "RestaurantSelectionPage";
            this.restaurantListPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel restaurantListPanel;
        private System.Windows.Forms.Label restaurantListLabel;
        private System.Windows.Forms.Button addRestaurantButton;
        private System.Windows.Forms.Label restaurantPageTitle;
        private System.Windows.Forms.TextBox newRestaurantBox;
        private System.Windows.Forms.Button returnButton;
    }
}
using BenefitControl.CostData;
using BenefitControl.IncomeData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace BenefitControl
{
    public partial class RestaurantSelectionPage : Form
    {
        public CostWrapper costWrapper { set; get; }
        public IncomeWrapper incomeWrapper { set; get; }

        private bool isAppClose = true;
        private List<Restaurant> restaurantList = new List<Restaurant>();
        private int width;
        private int height;
        private Font font;
        private Point location;

        public RestaurantSelectionPage()
        {
            InitializeComponent();

            this.width = restaurantListLabel.Width;
            this.height = restaurantListLabel.Height;
            this.font = restaurantListLabel.Font;
            this.location = restaurantListLabel.Location;

            List<Restaurant> predefinedList = new List<Restaurant>()
            {
                Restaurant.RESTAURANT_1,
                Restaurant.RESTAURANT_2
            };
            restaurantList.AddRange(predefinedList);

            Load += RestaurantSelectionPage_Load;
        }

        private void RestaurantSelectionPage_Load(object sender, System.EventArgs e)
        {
            populateRestaurantList();
        }

        private void populateRestaurantList()
        {
            for (int i = 0; i < restaurantList.Count; i++)
            {
                location.Y += height;
                Button button = new Button()
                {
                    Name = "restaurantButton" + i,
                    Text = restaurantList[i].name,
                    Width = width,
                    Height = height,
                    Font = font,
                    Location = location
                };
                button.Click += new System.EventHandler(restaurantButtonOnClick);

                restaurantListPanel.Controls.Add(button);
            }
        }

        private void restaurantButtonOnClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            RestaurantBenefitPage yearly = new RestaurantBenefitPage();

            // This should pass the real object.
            yearly.restaurant = new Restaurant(button.Text);
            yearly.restaurantCost = costWrapper.getRestaurantCost(new Restaurant(button.Text));
            yearly.restaurantIncome = incomeWrapper.getRestaurantIncome(new Restaurant(button.Text));

            yearly.Show();
            yearly.Location = this.Location;
            yearly.Owner = this;
            this.Hide();
        }

        private void addRestaurantButton_Click(object sender, EventArgs e)
        {
            string newRestaurant = newRestaurantBox.Text;
            if (String.IsNullOrEmpty(newRestaurant))
            {
                MessageBox.Show("餐厅名不能为空", "餐厅名无效", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                addNewButtonToList(newRestaurant);
            }
        }

        private void addNewButtonToList(string newRestaurant)
        {
            restaurantList.Add(new Restaurant(newRestaurant));
            int index = restaurantList.Count - 1;
            location.Y += height;
            Button button = new Button()
            {
                Name = "restaurantButton" + index,
                Text = newRestaurant,
                Width = width,
                Height = height,
                Font = font,
                Location = location
            };

            restaurantListPanel.Controls.Add(button);
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            FrontPage frontPage = (FrontPage)this.Owner;
            frontPage.Show();
            frontPage.Location = this.Location;
            isAppClose = false;
            this.Close();
            isAppClose = true;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            if (isAppClose)
                Application.Exit();
        }
    }
}

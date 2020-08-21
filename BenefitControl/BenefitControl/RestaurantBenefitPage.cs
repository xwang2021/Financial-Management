using BenefitControl.CostData;
using BenefitControl.IncomeData;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace BenefitControl
{
    public partial class RestaurantBenefitPage : Form
    {
        public Restaurant restaurant { get; set; }
        public RestaurantCostWrapper restaurantCost { get; set; }
        public RestaurantIncomeWrapper restaurantIncome { get; set; }

        private bool isAppClose = true;
        private YearCostWrapper currentYearCostWrapper;
        private YearIncomeWrapper currentYearIncomeWrapper;

        public RestaurantBenefitPage()
        {
            InitializeComponent();
            InitializePage();

            Load += RestaurantBenefitPage_Load;
        }

        private void InitializePage()
        {
            DateTime localDate = DateTime.Now;
            int currentYear = localDate.Year;
            while (currentYear >= CommonSettings.BASE_DATE.Year)
            {
                yearSelectionDropdown.Items.Add(currentYear);
                currentYear--;
            }
        }

        private void RestaurantBenefitPage_Load(object sender, System.EventArgs e)
        {
            yearSelectionDropdown.SelectedIndex = 0;
            UpdateRestaurantBenefitInfo();
        }

        private void UpdateRestaurantBenefitInfo()
        {
            restaurantBenefitPageTitle.Text = restaurant.name + " 流水";
        }

        private void yearSelectionDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            string currentSelection = yearSelectionDropdown.SelectedItem.ToString();
            updateYearBenefitPanel(currentSelection);
        }

        private void updateYearBenefitPanel(string currentSelectedYear)
        {
            yearLabel.Text = currentSelectedYear;
            monthlyBenefitButton.Text = "查看该年流水";
            currentYearCostWrapper = restaurantCost.getYearCost(int.Parse(currentSelectedYear));
            currentYearIncomeWrapper = restaurantIncome.getYearIncome(int.Parse(currentSelectedYear));

            incomeLabel.Text = currentYearIncomeWrapper.getTotalAmount().ToString("N");
            expenseLabel.Text = currentYearCostWrapper.getTotalAmount().ToString("N");
            profitLabel.Text = (currentYearIncomeWrapper.getTotalAmount() - currentYearCostWrapper.getTotalAmount()).ToString("N");
        }

        private void monthlyBenefitButton_Click(object sender, EventArgs e)
        {
            YearBenefitPage yearBenefitPage = new YearBenefitPage();
            yearBenefitPage.restaurant = this.restaurant;
            yearBenefitPage.year = int.Parse(yearLabel.Text);
            yearBenefitPage.currentYearCostWrapper = this.currentYearCostWrapper;
            yearBenefitPage.currentYearIncomeWrapper = this.currentYearIncomeWrapper;

            yearBenefitPage.Show();
            yearBenefitPage.Location = this.Location;
            yearBenefitPage.Owner = this;
            this.Hide();
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            RestaurantSelectionPage restaurantPage = (RestaurantSelectionPage)this.Owner;
            restaurantPage.Show();
            restaurantPage.Location = this.Location;
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

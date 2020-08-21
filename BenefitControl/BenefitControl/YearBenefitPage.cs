using BenefitControl.CostData;
using BenefitControl.IncomeData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace BenefitControl
{
    public partial class YearBenefitPage : Form
    {
        public Restaurant restaurant { get; set; }
        public int year { get; set; }
        public YearCostWrapper currentYearCostWrapper { get; set; }
        public YearIncomeWrapper currentYearIncomeWrapper { get; set; }

        private bool isAppClose = true;

        public YearBenefitPage()
        {
            InitializeComponent();
            InitializePage();

            Load += YearBenefitPage_Load;
        }

        private void InitializePage()
        {
            foreach (string month in CommonSettings.MONTH_LIST)
                monthSelectionDropdown.Items.Add(month);
        }

        private void YearBenefitPage_Load(object sender, System.EventArgs e)
        {
            UpdateYearBenefitTitle();
            UpdateChartValue();
            UpdateCostDetailChartValue();
            UpdateTotalBenefitLabel();

            monthSelectionDropdown.SelectedIndex = 0;
        }

        private void UpdateChartValue()
        {
            for (int i = 1; i <= 12; i++)
            {
                double cost = currentYearCostWrapper.getMonthCost(i).getTotalAmount();
                yearBenefitChart.Series["costSeries"].Points.AddXY(CommonSettings.MONTH_LIST[i - 1], cost);

                double income = currentYearIncomeWrapper.getMonthIncome(i).getTotalAmount();
                yearBenefitChart.Series["incomeSeries"].Points.AddXY(CommonSettings.MONTH_LIST[i - 1], income);
            }
        }

        private void UpdateCostDetailChartValue()
        {
            List<double> amountList = new List<double>();
            List<string> labelList = new List<string>();
            foreach (Cost.CostType costType in Enum.GetValues(typeof(Cost.CostType)))
            {
                yearCostDetailChart.Series["costSeries"].Points.AddXY(
                    Cost.getCostTypeName(costType), currentYearCostWrapper.getCostByType(costType));
            }
            yearCostDetailChart.Titles["costDetailChartTitle"].Text = year + "全年支出细节";
        }

        private void UpdateTotalBenefitLabel()
        {
            totalIncomeLabel.Text = currentYearIncomeWrapper.getTotalAmount().ToString("N");
            totalCostLabel.Text = currentYearCostWrapper.getTotalAmount().ToString("N");
            totalBenefitLabel.Text = (currentYearIncomeWrapper.getTotalAmount() - currentYearCostWrapper.getTotalAmount()).ToString("N");
        }

        private void UpdateYearBenefitTitle()
        {
            yearBenefitPageTitle.Text = restaurant.name + year + "年流水";
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            RestaurantBenefitPage restaurantPage = (RestaurantBenefitPage)this.Owner;
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

        private void monthSelectionDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            string currentSelection = monthSelectionDropdown.SelectedItem.ToString();
            monthLabel.Text = currentSelection + "细节";
            UpdateMonthBenefitPanel(monthSelectionDropdown.SelectedIndex);
        }

        private void UpdateMonthBenefitPanel(int selectionIndex)
        {
            double monthIncome = currentYearIncomeWrapper.getMonthIncome(selectionIndex + 1).getTotalAmount();
            double monthCost = currentYearCostWrapper.getMonthCost(selectionIndex + 1).getTotalAmount();
            monthIncomeLabel.Text = monthIncome.ToString("N");
            monthCostLabel.Text = monthCost.ToString("N");
            monthBenefitLabel.Text = (monthIncome - monthCost).ToString("N");
        }

        private void monthDetailButton_Click(object sender, EventArgs e)
        {
            MonthBenefitPage monthBenefitPage = new MonthBenefitPage();
            monthBenefitPage.restaurant = this.restaurant;
            monthBenefitPage.year = this.year;
            int selectedMonth = monthSelectionDropdown.SelectedIndex + 1;
            monthBenefitPage.month = selectedMonth;
            monthBenefitPage.currentMonthCostWrapper = this.currentYearCostWrapper.getMonthCost(selectedMonth);
            monthBenefitPage.currentMonthIncomeWrapper = this.currentYearIncomeWrapper.getMonthIncome(selectedMonth);

            monthBenefitPage.Show();
            monthBenefitPage.Location = this.Location;
            monthBenefitPage.Owner = this;
            this.Hide();
        }

        private void costDetailButton_Click(object sender, EventArgs e)
        {
            CostDetailData costDetailData = new YearCostDetailData(restaurant, year, currentYearCostWrapper);

            CostDetailPage costDetailPage = new CostDetailPage();
            costDetailPage.costDetailData = costDetailData;

            costDetailPage.Show();
            costDetailPage.Location = this.Location;
            costDetailPage.Owner = this;
            this.Hide();
        }
    }
}

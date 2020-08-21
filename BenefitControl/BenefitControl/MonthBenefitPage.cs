using BenefitControl.CostData;
using BenefitControl.IncomeData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BenefitControl
{
    public partial class MonthBenefitPage : Form
    {
        public Restaurant restaurant { get; set; }
        public int year { get; set; }
        public int month { get; set; }
        public MonthCostWrapper currentMonthCostWrapper { get; set; }
        public MonthIncomeWrapper currentMonthIncomeWrapper { get; set; }

        private bool isAppClose = true;

        public MonthBenefitPage()
        {
            InitializeComponent();

            Load += MonthBenefitPage_Load;
        }

        private void MonthBenefitPage_Load(object sender, System.EventArgs e)
        {
            UpdateMonthBenefitInfo();
            UpdateChartValue();
            UpdateCostDetailChartValue();
            UpdateTotalBenefitLabel();
        }

        private void UpdateChartValue()
        {
            DateTime monthBaseTime = new DateTime(year, month, 1);
            DateTime nextMonthTime = monthBaseTime.AddMonths(1);
            while (monthBaseTime.CompareTo(nextMonthTime) < 0)
            {
                double cost = currentMonthCostWrapper.getDayCost(monthBaseTime.Day).getAmount();
                monthBenefitChart.Series["costSeries"].Points.AddXY(monthBaseTime.Day.ToString() + "日", cost);

                double income = currentMonthIncomeWrapper.getDayIncome(monthBaseTime.Day).getAmount();
                monthBenefitChart.Series["incomeSeries"].Points.AddXY(monthBaseTime.Day.ToString() + "日", income);

                daySelectionDropdown.Items.Add(CommonSettings.DAY_LIST[monthBaseTime.Day - 1]);
                monthBaseTime = monthBaseTime.AddDays(1);
            }
            daySelectionDropdown.SelectedIndex = 0;
        }

        private void UpdateCostDetailChartValue()
        {
            List<double> amountList = new List<double>();
            List<string> labelList = new List<string>();
            foreach (Cost.CostType costType in Enum.GetValues(typeof(Cost.CostType)))
            {
                monthCostDetailChart.Series["costSeries"].Points.AddXY(
                    Cost.getCostTypeName(costType), currentMonthCostWrapper.getCostByType(costType));
            }
            monthCostDetailChart.Titles["costDetailChartTitle"].Text = month + "月支出细节";
        }

        private void UpdateTotalBenefitLabel()
        {
            totalIncomeLabel.Text = currentMonthIncomeWrapper.getTotalAmount().ToString("N");
            totalCostLabel.Text = currentMonthCostWrapper.getTotalAmount().ToString("N");
            totalBenefitLabel.Text = (currentMonthIncomeWrapper.getTotalAmount() - currentMonthCostWrapper.getTotalAmount()).ToString("N");
        }

        private void UpdateMonthBenefitInfo()
        {
            monthBenefitPageTitle.Text = restaurant.name + year + "年" + month + "月流水";
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            YearBenefitPage yearPage = (YearBenefitPage)this.Owner;
            yearPage.Show();
            yearPage.Location = this.Location;
            isAppClose = false;
            this.Close();
            isAppClose = true;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            if (isAppClose)
                Application.Exit();
        }

        private void costDetailButton_Click(object sender, EventArgs e)
        {
            CostDetailData costDetailData = new MonthCostDetailData(restaurant, year, month, currentMonthCostWrapper);

            CostDetailPage costDetailPage = new CostDetailPage();
            costDetailPage.costDetailData = costDetailData;

            costDetailPage.Show();
            costDetailPage.Location = this.Location;
            costDetailPage.Owner = this;
            this.Hide();
        }

        private void UpdateDayBenefitPanel(int selectionIndex)
        {
            double dayIncome = currentMonthIncomeWrapper.getDayIncome(selectionIndex).getAmount();
            double dayCost = currentMonthCostWrapper.getDayCost(selectionIndex).getAmount();
            dayIncomeLabel.Text = dayIncome.ToString("N");
            dayCostLabel.Text = dayCost.ToString("N");
            dayBenefitLabel.Text = (dayIncome - dayCost).ToString("N");
        }

        private void daySelectionDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            string currentSelection = daySelectionDropdown.SelectedItem.ToString();
            dayLabel.Text = currentSelection;
            UpdateDayBenefitPanel(daySelectionDropdown.SelectedIndex + 1);
        }

        private void dayDetailButton_Click(object sender, EventArgs e)
        {
            DayBenefitPage dayBenefitPage = new DayBenefitPage(false);
            dayBenefitPage.restaurant = this.restaurant;
            dayBenefitPage.year = this.year;
            dayBenefitPage.month = this.month;
            int selectedDay = daySelectionDropdown.SelectedIndex + 1;
            dayBenefitPage.day = selectedDay;
            dayBenefitPage.currentDayCostWrapper = this.currentMonthCostWrapper.getDayCost(selectedDay);
            dayBenefitPage.currentIncome = this.currentMonthIncomeWrapper.getDayIncome(selectedDay);

            dayBenefitPage.Show();
            dayBenefitPage.Location = this.Location;
            dayBenefitPage.Owner = this;
            this.Hide();
        }
    }
}

using BenefitControl.CostData;
using BenefitControl.IncomeData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace BenefitControl
{
    public partial class InputSelection : Form
    {
        private readonly bool isManager;
        private readonly RestaurantWrapper restaurantWrapper;

        public CostWrapper costWrapper { set; get; }
        public IncomeWrapper incomeWrapper { set; get; }

        private bool isAppClose = true;

        public InputSelection(bool isManager)
        {
            InitializeComponent();
            this.isManager = isManager;
            restaurantWrapper = new RestaurantWrapper();
            
            InitializePage();
        }

        public void updateBenefitValue(DayCostWrapper cost, Income income, Restaurant restaurant, int year, int month, int day)
        {
            costWrapper = CostUpdater.updateCost(costWrapper, cost, restaurant, year, month, day);
            incomeWrapper = IncomeUpdater.updateIncome(incomeWrapper, income, restaurant, year, month, day);
            saveIncomeDataToFile();
            saveCostDataToFile();
        }

        private void InitializePage()
        {
            if (isManager)
            {
                inputSelectionPageTitle.Text = "请选择日期与餐厅";
                dateTimePicker.Visible = true;
                dateLabel.Visible = false;
            }
            else
            {
                inputSelectionPageTitle.Text = "请选择餐厅";
                dateTimePicker.Visible = false;
                DateTime date = DateTime.Now;
                dateLabel.Text = date.Year + "年" + date.Month + "月" + date.Day + "日";
                dateLabel.Visible = true;
            }

            foreach (Restaurant restaurant in restaurantWrapper.getCurrentRestaurantList())
            {
                restaurantSelectionDropdown.Items.Add(restaurant.name);
            }
            restaurantSelectionDropdown.SelectedIndex = 0;

            dateTimePicker.MinDate = CommonSettings.BASE_DATE;
            dateTimePicker.MaxDate = DateTime.Now;
            dateTimePicker.Value = DateTime.Now;
        }

        private void restaurantSelectionDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            inputButton.Enabled = restaurantSelectionDropdown.SelectedIndex != 0;
        }

        private void inputButton_Click(object sender, EventArgs e)
        {
            Restaurant restaurant = restaurantWrapper.getRestaurantByName(restaurantSelectionDropdown.SelectedItem.ToString());
            InputData inputPage = new InputData(isManager, restaurant, dateTimePicker.Value);
            inputPage.costWrapper = this.costWrapper;
            inputPage.incomeWrapper = this.incomeWrapper;
            inputPage.Show();
            inputPage.Location = this.Location;
            inputPage.Owner = this;
            this.Hide();
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            FrontPage frontPage = (FrontPage) this.Owner;
            frontPage.updateCostAndIncomeValue(costWrapper, incomeWrapper);
            frontPage.Location = this.Location;
            frontPage.Show();
            isAppClose = false;
            this.Close();
            isAppClose = true;
        }

        private void saveIncomeDataToFile()
        {
            FileStream fs = new FileStream(CommonSettings.INCOME_FILE_PATH, FileMode.Create);

            BinaryFormatter formatter = new BinaryFormatter();
            try
            {
                formatter.Serialize(fs, incomeWrapper);
            }
            catch (SerializationException e)
            {
                Console.WriteLine("Failed to serialize. Reason: " + e.Message);
                throw;
            }
            finally
            {
                fs.Close();
            }
        }

        private void saveCostDataToFile()
        {
            FileStream fs = new FileStream(CommonSettings.COST_FILE_PATH, FileMode.Create);

            BinaryFormatter formatter = new BinaryFormatter();
            try
            {
                formatter.Serialize(fs, costWrapper);
            }
            catch (SerializationException e)
            {
                Console.WriteLine("Failed to serialize. Reason: " + e.Message);
                throw;
            }
            finally
            {
                fs.Close();
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            if (isAppClose)
                Application.Exit();
        }
    }
}

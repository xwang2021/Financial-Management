using BenefitControl.CostData;
using BenefitControl.IncomeData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BenefitControl
{
    public partial class FrontPage : Form
    {
        private readonly bool isManager;
        
        private CostWrapper costWrapper;
        private IncomeWrapper incomeWrapper;

        public FrontPage(bool isManager)
        {
            this.isManager = isManager;
            InitializeComponent();
            InitializePage();

            checkDataPathExist();
            TestData testData = new TestData();
            this.costWrapper = readCostFromFile();
            this.incomeWrapper = readIncomeFromFile();
        }

        public void updateCostAndIncomeValue(CostWrapper newCostWrapper, IncomeWrapper newIncomeWrapper)
        {
            this.costWrapper = newCostWrapper;
            this.incomeWrapper = newIncomeWrapper;
        }

        private void InitializePage()
        {
            checkBenefitButton.Visible = isManager;
            actionSelectionLabel.Visible = isManager;

            inputButton.Select();
        }

        private void checkDataPathExist()
        {
            if (!Directory.Exists(CommonSettings.DATA_PATH))
            {
                Directory.CreateDirectory(CommonSettings.DATA_PATH);
            }
        }

        private CostWrapper readCostFromFile()
        {
            CostWrapper cost = null;

            FileStream file;
            try
            {
                file = new FileStream(CommonSettings.COST_FILE_PATH, FileMode.Open);
            }
            catch (FileNotFoundException)
            {
                file = new FileStream(CommonSettings.COST_FILE_PATH, FileMode.Create);
            }

            try
            {
                BinaryFormatter formatter = new BinaryFormatter();

                cost = (CostWrapper)formatter.Deserialize(file);
            }
            catch (SerializationException e)
            {
                Console.WriteLine("Failed to deserialize. Reason: " + e.Message);
                return CostWrapper.EMPTY_COST_WRAPPER;
            }
            finally
            {
                file.Close();
            }

            return cost;
        }

        private IncomeWrapper readIncomeFromFile()
        {
            IncomeWrapper income = null;

            FileStream file;
            try
            {
                file = new FileStream(CommonSettings.INCOME_FILE_PATH, FileMode.Open);
            }
            catch (FileNotFoundException)
            {
                file = new FileStream(CommonSettings.INCOME_FILE_PATH, FileMode.Create);
            }

            try
            {
                BinaryFormatter formatter = new BinaryFormatter();

                income = (IncomeWrapper)formatter.Deserialize(file);
            }
            catch (SerializationException e)
            {
                Console.WriteLine("Failed to deserialize. Reason: " + e.Message);
                return IncomeWrapper.EMPTY_INCOME_WRAPPER;
            }
            finally
            {
                file.Close();
            }

            return income;
        }

        private void checkBenefitButton_Click(object sender, EventArgs e)
        {
            RestaurantSelectionPage restaurantPage = new RestaurantSelectionPage();
            restaurantPage.incomeWrapper = this.incomeWrapper;
            restaurantPage.costWrapper = this.costWrapper;
            restaurantPage.Show();
            restaurantPage.Location = this.Location;
            restaurantPage.Owner = this;
            this.Hide();
        }

        private void inputButton_Click(object sender, EventArgs e)
        {
            InputSelection inputSelectionPage = new InputSelection(isManager);
            inputSelectionPage.costWrapper = this.costWrapper;
            inputSelectionPage.incomeWrapper = this.incomeWrapper;
            inputSelectionPage.Show();
            inputSelectionPage.Location = this.Location;
            inputSelectionPage.Owner = this;
            this.Hide();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            Application.Exit();
        }
    }
}

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
    public partial class InputData : Form
    {
        private static Font COLUMN_VALUE_FONT = new Font("宋体", 12f);

        public CostWrapper costWrapper { set; get; }
        public IncomeWrapper incomeWrapper { set; get; }

        private readonly bool isManager;
        private readonly RestaurantWrapper restaurantWrapper;
        private readonly Restaurant currentRestaurant;
        private readonly DateTime currentDate;

        private bool isAppClose = true;
        private Cost.CostType currentCostType;
        private Food.FoodType currentFoodType;
        private List<Cost> costList = new List<Cost>();

        public InputData(bool isManager, Restaurant currentRestaurant, DateTime currentDate)
        {
            InitializeComponent();
            this.isManager = isManager;
            this.currentRestaurant = currentRestaurant;
            this.currentDate = currentDate;
            restaurantWrapper = new RestaurantWrapper();
            InitializePage();

            Load += InputData_Load;
        }

        private void InputData_Load(object sender, EventArgs e)
        {
            InitializeData();
        }

        private void InitializePage()
        {
            currentDayLabel.Text = currentDate.ToShortDateString();
            restaurantLabel.Text = currentRestaurant.name;

            foreach (Cost.CostType costType in Enum.GetValues(typeof(Cost.CostType)))
            {
                if (costType == Cost.CostType.FOOD)
                {
                    foreach (Food.FoodType foodType in Enum.GetValues(typeof(Food.FoodType)))
                    {
                        costTypeSelectionDropdown.Items.Add(Cost.getCostTypeName(costType) + "--" + Food.getFoodTypeName(foodType));
                    }
                }
                else
                {
                    costTypeSelectionDropdown.Items.Add(Cost.getCostTypeName(costType));
                }
            }
            costTypeSelectionDropdown.SelectedIndex = 0;
        }

        private void InitializeData()
        {
            clearAllInput();
            if (isValueExist())
            {
                fillIncomeAndCostValue();
            }
        }

        private bool isValueExist()
        {
            bool hasCost = costWrapper.isValueExist(currentRestaurant, currentDate);
            bool hasIncome = incomeWrapper.isValueExist(currentRestaurant, currentDate);
            return hasCost || hasIncome;
        }

        private void fillIncomeAndCostValue()
        {
            incomeTextbox.Text = incomeWrapper.getRestaurantIncome(currentRestaurant).getYearIncome(currentDate.Year)
                .getMonthIncome(currentDate.Month).getDayIncome(currentDate.Day).getAmount().ToString();
            DayCostWrapper dayCost = costWrapper.getRestaurantCost(currentRestaurant).getYearCost(currentDate.Year)
                .getMonthCost(currentDate.Month).getDayCost(currentDate.Day);
            costList = dayCost.getTotalCostList();
            fillCostValueTable();
        }

        private void fillCostValueTable()
        {
            foreach (Cost cost in costList)
            {
                addCostToCostTable(cost);
            }
        }

        private void clearAllInput()
        {
            incomeTextbox.Clear();
            clearCostInput();
        }

        private void clearCostInput()
        {
            costTypeSelectionDropdown.SelectedIndex = 0;
            costNameTextbox.Clear();
            costAmountTextbox.Clear();
            costQuantityTextbox.Clear();
            clearCostInputTable();
        }

        private void costTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (costTypeSelectionDropdown.SelectedIndex == 0)
            {
                return;
            }
            costNameTextbox.Clear();
            string currentSelection = costTypeSelectionDropdown.SelectedItem.ToString();
            if (currentSelection.StartsWith("食物"))
            {
                currentCostType = Cost.CostType.FOOD;
                currentFoodType = Food.getFoodTypeByName(currentSelection.Substring(4));
                costQuantityTextbox.Enabled = true;
            }
            else
            {
                currentCostType = Cost.getCostTypeByName(currentSelection);
                costQuantityTextbox.Text = "1";
                costQuantityTextbox.Enabled = false;
                if (currentSelection.StartsWith("维护"))
                {
                    costNameTextbox.Text = "维护";
                }
            }
        }

        private void addCostButton_Click(object sender, EventArgs e)
        {
            if (!isCurrentCostInputValid())
            {
                return;
            }
            Cost cost;
            switch (currentCostType)
            {
                case Cost.CostType.FOOD:
                    switch (currentFoodType)
                    {
                        case Food.FoodType.MEAT:
                            cost = new Meat(costNameTextbox.Text, double.Parse(costAmountTextbox.Text), double.Parse(costQuantityTextbox.Text),
                                currentRestaurant, Cost.PayMethod.MONTHLY, currentDate);
                            break;
                        case Food.FoodType.GRAIN:
                            cost = new Grain(costNameTextbox.Text, double.Parse(costAmountTextbox.Text), double.Parse(costQuantityTextbox.Text),
                                currentRestaurant, Cost.PayMethod.MONTHLY, currentDate);
                            break;
                        case Food.FoodType.VEGETABLE:
                            cost = new Vegetable(costNameTextbox.Text, double.Parse(costAmountTextbox.Text), double.Parse(costQuantityTextbox.Text),
                                currentRestaurant, Cost.PayMethod.MONTHLY, currentDate);
                            break;
                        case Food.FoodType.FLAVOR:
                            cost = new Flavor(costNameTextbox.Text, double.Parse(costAmountTextbox.Text), double.Parse(costQuantityTextbox.Text),
                                currentRestaurant, Cost.PayMethod.MONTHLY, currentDate);
                            break;
                        case Food.FoodType.SEAFOOD:
                            cost = new Seafood(costNameTextbox.Text, double.Parse(costAmountTextbox.Text), double.Parse(costQuantityTextbox.Text),
                                currentRestaurant, Cost.PayMethod.MONTHLY, currentDate);
                            break;
                        default:
                            return;
                    }
                    break;
                case Cost.CostType.SALARY:
                    cost = new Salary(costNameTextbox.Text, double.Parse(costAmountTextbox.Text), currentRestaurant, currentDate);
                    break;
                case Cost.CostType.BONUS:
                    cost = new Bonus(costNameTextbox.Text, double.Parse(costAmountTextbox.Text), currentRestaurant, "",
                        Cost.PayMethod.DAILY, currentDate);
                    break;
                case Cost.CostType.EXTRA_COST:
                    cost = new ExtraCost(costNameTextbox.Text, double.Parse(costAmountTextbox.Text), currentRestaurant, "",
                        Cost.PayMethod.MONTHLY, currentDate);
                    break;
                case Cost.CostType.MAINTENANCE:
                    cost = new MaintenanceCost(double.Parse(costAmountTextbox.Text), currentRestaurant, currentDate);
                    break;
                default:
                    return;
            }
            costList.Add(cost);
            addCostToCostTable(cost);
        }

        private bool isCurrentCostInputValid()
        {
            if (costTypeSelectionDropdown.SelectedIndex == 0)
            {
                MessageBox.Show("请选择类别", "类别无效", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (String.IsNullOrWhiteSpace(costNameTextbox.Text))
            {
                MessageBox.Show("名称不能为空", "名称无效", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (String.IsNullOrWhiteSpace(costAmountTextbox.Text))
            {
                MessageBox.Show("金额不能为空", "金额无效", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            double doubleValue;
            if (!double.TryParse(costAmountTextbox.Text, out doubleValue))
            {
                MessageBox.Show("金额必须为数字", "金额无效", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (String.IsNullOrWhiteSpace(costQuantityTextbox.Text))
            {
                MessageBox.Show("数量不能为空", "数量无效", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            long longValue;
            if (!long.TryParse(costQuantityTextbox.Text, out longValue))
            {
                MessageBox.Show("数量必须为数字", "数量无效", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            return true;
        }
        
        private void addCostToCostTable(Cost cost)
        {
            int rowIndex = inputTable.Rows.Add();
            inputTable.Rows[rowIndex].Cells[0].Value = Cost.getCostTypeName(cost.getCostType());
            inputTable.Rows[rowIndex].Cells[1].Value = cost.getName();
            inputTable.Rows[rowIndex].Cells[2].Value = cost.getAmount().ToString("N");
            inputTable.Rows[rowIndex].Cells[3].Value = cost.getQuantity().ToString();
            inputTable.Rows[rowIndex].Cells[4].Value = cost.getUnitPrice().ToString("N");
            inputTable.Rows[rowIndex].Cells[5].Value = "X";
        }

        private void clearCostInputTable()
        {
            inputTable.Rows.Clear();
        }

        private void inputTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == inputTable.NewRowIndex || e.RowIndex < 0)
                return;

            if (e.ColumnIndex == inputTable.Columns["removeColumn"].Index)
            {
                inputTable.Rows.RemoveAt(e.RowIndex);
                costList.RemoveAt(e.RowIndex);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            DayBenefitPage dayBenefitPage = new DayBenefitPage(true);
            dayBenefitPage.restaurant = currentRestaurant;
            dayBenefitPage.year = currentDate.Year;
            dayBenefitPage.month = currentDate.Month;
            dayBenefitPage.day = currentDate.Day;
            dayBenefitPage.currentDayCostWrapper = new DayCostWrapper(currentDate.Day, costList);

            string incomeText = incomeTextbox.Text;
            if (string.IsNullOrWhiteSpace(incomeText))
            {
                dayBenefitPage.currentIncome = new Income(currentRestaurant, 0, currentDate);
            }
            else
            {
                dayBenefitPage.currentIncome = new Income(currentRestaurant, double.Parse(incomeText), currentDate);
            }
            dayBenefitPage.Show();
            dayBenefitPage.Location = this.Location;
            dayBenefitPage.Owner = this;
            this.Hide();
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            this.Owner.Location = this.Location;
            this.Owner.Show();
            isAppClose = false;
            this.Close();
            isAppClose = true;
        }

        public void setIsAppClose(bool isAppClose)
        {
            this.isAppClose = isAppClose;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            if (isAppClose)
                Application.Exit();
        }
    }
}

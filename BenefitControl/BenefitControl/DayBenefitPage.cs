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
using System.Windows;
using System.Windows.Forms;

namespace BenefitControl
{
    public partial class DayBenefitPage : Form
    {
        private readonly bool isPreview;

        public Restaurant restaurant { get; set; }
        public int year { get; set; }
        public int month { get; set; }
        public int day { get; set; }
        public DayCostWrapper currentDayCostWrapper { get; set; }
        public Income currentIncome { get; set; }

        private bool isAppClose = true;
        private Dictionary<Cost.CostType, DataGridView> tableMap = new Dictionary<Cost.CostType, DataGridView>();

        public DayBenefitPage(bool isPreview)
        {
            InitializeComponent();
            this.isPreview = isPreview;
            InitializePage();

            Load += DayBenefitPage_Load;
        }

        private void InitializePage()
        {
            saveButton.Visible = isPreview;
            cancelButton.Visible = isPreview;
            returnButton.Visible = !isPreview;

            tableMap.Add(Cost.CostType.FOOD, FoodTable);
            tableMap.Add(Cost.CostType.SALARY, SalaryTable);
            tableMap.Add(Cost.CostType.BONUS, BonusTable);
            tableMap.Add(Cost.CostType.EXTRA_COST, ExtraCostTable);
            tableMap.Add(Cost.CostType.MAINTENANCE, MaintenanceTable);
        }

        private void DayBenefitPage_Load(object sender, System.EventArgs e)
        {
            UpdateDayBenefitInfo();
            UpdateIncomePanel();
            UpdateCostPanel();
        }

        private void UpdateDayBenefitInfo()
        {
            if (isPreview)
            {
                dayBenefitPageTitle.Text = "请核对" + restaurant.name + year + "年" + month + "月" + day + "日流水";
            }
            else
            {
                dayBenefitPageTitle.Text = restaurant.name + year + "年" + month + "月" + day + "日流水";
            }
        }

        private void UpdateIncomePanel()
        {
            incomeLabel.Text = currentIncome.getAmount().ToString("N") + "円";
        }

        private void UpdateCostPanel()
        {
            foreach (Cost.CostType costType in Enum.GetValues(typeof(Cost.CostType)))
            {
                Dictionary<string, Tuple<double, List<Cost>>> costDetailMap = currentDayCostWrapper.getCostDetailByType(costType);
                UpdateSpecificDetailTable(tableMap[costType], costDetailMap);
            }
        }

        private void UpdateSpecificDetailTable(DataGridView table, Dictionary<string, Tuple<double, List<Cost>>> costDetailMap)
        {
            table.Visible = true;
            table.Controls.Clear();
            double totalAmount = 0;

            foreach (string name in costDetailMap.Keys)
            {
                double amount = costDetailMap[name].Item1;
                totalAmount += amount;
                InsertTableRowValue(table, name, amount);
            }
            InsertTableRowValue(table, "总计", totalAmount);
            table.Height = 25 * table.RowCount + 2;
        }

        private void InsertTableRowValue(DataGridView table, string name, double amount)
        {
            int rowIndex = table.Rows.Add();
            table.Rows[rowIndex].Cells[0] = InsertTableCellValue(name, DataGridViewContentAlignment.MiddleLeft);
            table.Rows[rowIndex].Cells[1] = InsertTableCellValue(amount.ToString("N"), DataGridViewContentAlignment.MiddleRight);
        }

        private DataGridViewCell InsertTableCellValue(string value, DataGridViewContentAlignment alignment)
        {
            return new DataGridViewTextBoxCell()
            {
                Value = value,
                Style = new DataGridViewCellStyle()
                {
                    BackColor = Color.White,
                    Font = new Font("宋体", 9.25f),
                    Alignment = alignment
                }
            };
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Owner.Location = this.Location;
            isAppClose = false;
            this.Close();
            isAppClose = true;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Owner.Location = this.Location;
            isAppClose = false;
            this.Close();
            isAppClose = true;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            InputData input = (InputData)this.Owner;
            InputSelection inputSelection = (InputSelection)input.Owner;

            inputSelection.updateBenefitValue(currentDayCostWrapper, currentIncome, restaurant, year, month, day);

            inputSelection.Show();
            inputSelection.Location = this.Location;
            isAppClose = false;
            this.Close();
            isAppClose = true;
            input.setIsAppClose(false);
            input.Close();
            input.setIsAppClose(true);
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            if (isAppClose)
                Application.Exit();
        }
    }
}

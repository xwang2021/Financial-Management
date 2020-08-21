using BenefitControl.CostData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace BenefitControl
{
    public partial class CostDetailPage : Form
    {
        public CostDetailData costDetailData { get; set; }

        private bool isAppClose = true;
        private Dictionary<Cost.CostType, DataGridView> tableMap = new Dictionary<Cost.CostType, DataGridView>();

        public CostDetailPage()
        {
            InitializeComponent();
            InitializePage();

            Load += CostDetailPage_Load;
        }

        private void InitializePage()
        {
            tableMap.Add(Cost.CostType.FOOD, FoodTable);
            tableMap.Add(Cost.CostType.SALARY, SalaryTable);
            tableMap.Add(Cost.CostType.BONUS, BonusTable);
            tableMap.Add(Cost.CostType.EXTRA_COST, ExtraCostTable);
            tableMap.Add(Cost.CostType.MAINTENANCE, MaintenanceTable);
        }

        private void CostDetailPage_Load(object sender, System.EventArgs e)
        {
            CostDetailPageTitle.Text = costDetailData.getTitle();
            UpdateCostDetailPanel();
        }

        private void UpdateCostDetailPanel()
        {
            foreach (Cost.CostType costType in Enum.GetValues(typeof(Cost.CostType)))
            {
                Dictionary<string, Tuple<double, List<Cost>>> costDetailMap = costDetailData.getCostDetailMap(costType);
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

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            this.Owner.Location = this.Location;
            this.Owner.Show();
            isAppClose = false;
            this.Close();
            isAppClose = true;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            if (isAppClose)
                Application.Exit();
        }

        private void foodLabel_Click(object sender, EventArgs e)
        {
            openCostByTypePage(Cost.CostType.FOOD);
        }

        private void salaryLabel_Click(object sender, EventArgs e)
        {
            openCostByTypePage(Cost.CostType.SALARY);
        }

        private void bonusLabel_Click(object sender, EventArgs e)
        {
            openCostByTypePage(Cost.CostType.BONUS);
        }

        private void extraCostLabel_Click(object sender, EventArgs e)
        {
            openCostByTypePage(Cost.CostType.EXTRA_COST);
        }

        private void maintenanceLabel_Click(object sender, EventArgs e)
        {
            openCostByTypePage(Cost.CostType.MAINTENANCE);
        }

        private void openCostByTypePage(Cost.CostType costType)
        {
            CostByTypePage costByTypePage = new CostByTypePage();
            costByTypePage.costType = costType;
            costByTypePage.costDetailData = costDetailData;

            costByTypePage.Show();
            costByTypePage.Location = this.Location;
            costByTypePage.Owner = this;
            this.Hide();
        }
    }
}

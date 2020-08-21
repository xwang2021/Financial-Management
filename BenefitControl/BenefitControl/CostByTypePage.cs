using BenefitControl.CostData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace BenefitControl
{
    public partial class CostByTypePage : Form
    {
        public CostDetailData costDetailData { get; set; }
        public Cost.CostType costType { get; set; }

        private bool isAppClose = true;
        private bool checkFromUi = false;
        private Dictionary<string, Tuple<Series, Series>> seriesMap = new Dictionary<string, Tuple<Series, Series>>();

        public CostByTypePage()
        {
            InitializeComponent();

            Load += CostByTypePage_Load;
        }

        private void CostByTypePage_Load(object sender, System.EventArgs e)
        {
            string title = costDetailData.getRestaurant().name + costDetailData.getTime();
            CostByTypePageTitle.Text = title + Cost.getCostTypeName(costType) + "支出";
            UpdateCostByTypeChart();
        }

        private void UpdateCostByTypeChart()
        {
            Dictionary<string, Tuple<double, List<Cost>>> costDetailMap = costDetailData.getCostDetailMap(costType);
            checkFromUi = false;
            allSelectedCheckBox.Checked = true;
            checkFromUi = true;
            costTotalAmountChart.Visible = true;
            costUnitPriceChart.Visible = false;
            totalAmountButton.Checked = true;
            foreach (string name in costDetailMap.Keys)
            {
                Series amountSeries = new Series(name);
                amountSeries.LegendText = name;
                amountSeries.ChartType = SeriesChartType.Line;
                amountSeries.BorderWidth = 3;

                Series unitPriceSeries = new Series(name);
                unitPriceSeries.LegendText = name;
                unitPriceSeries.ChartType = SeriesChartType.Line;
                unitPriceSeries.BorderWidth = 3;

                List<Cost> costList = costDetailMap[name].Item2;

                DetailType detailType = costDetailData.getDetailType();
                Dictionary<int, Tuple<double, double>> costMap = new Dictionary<int, Tuple<double, double>>();
                if (detailType == DetailType.Year)
                {
                    foreach (Cost cost in costList)
                    {
                        if (costMap.ContainsKey(cost.getMonth()))
                        {
                            Tuple<double, double> value = costMap[cost.getMonth()];
                            costMap[cost.getMonth()] = new Tuple<double, double>(value.Item1 + cost.getAmount(), value.Item2 + cost.getQuantity());
                        }
                        else
                        {
                            costMap.Add(cost.getMonth(), new Tuple<double, double>(cost.getAmount(), cost.getQuantity()));
                        }
                    }
                    for (int i = 1; i <= 12; i++)
                    {
                        if (costMap.ContainsKey(i))
                        {
                            amountSeries.Points.AddXY(i + "月", costMap[i].Item1);
                            unitPriceSeries.Points.AddXY(i + "月", costMap[i].Item1 / costMap[i].Item2);
                        }
                        else
                        {
                            amountSeries.Points.AddXY(i + "月", 0);
                            unitPriceSeries.Points.AddXY(i + "月", 0);
                        }
                    }
                }
                else if (detailType == DetailType.Month)
                {
                    foreach (Cost cost in costList)
                    {
                        costMap.Add(cost.getDay(), new Tuple<double, double>(cost.getAmount(), cost.getQuantity()));
                    }
                    MonthCostDetailData monthCostDetailData = (MonthCostDetailData) costDetailData;
                    int monthLength = new DateTime(monthCostDetailData.getYear(), monthCostDetailData.getMonth() + 1, 1)
                        .AddDays(-1).Day;
                    for (int i = 1; i <= monthLength; i++)
                    {
                        if (costMap.ContainsKey(i))
                        {
                            amountSeries.Points.AddXY(i + "日", costMap[i].Item1);
                            unitPriceSeries.Points.AddXY(i + "日", costMap[i].Item1 / costMap[i].Item2);
                        }
                        else
                        {
                            amountSeries.Points.AddXY(i + "日", 0);
                            unitPriceSeries.Points.AddXY(i + "日", 0);
                        }
                    }
                }

                amountSeries.ChartArea = "ChartArea1";
                unitPriceSeries.ChartArea = "ChartArea1";
                costTotalAmountChart.Series.Add(amountSeries);
                costUnitPriceChart.Series.Add(unitPriceSeries);

                seriesMap.Add(name, new Tuple<Series, Series>(amountSeries, unitPriceSeries));
                costNameCheckList.Items.Add(name, true);
            }
        }

        private void returnButton_Click(object sender, EventArgs e)
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

        private void costNameCheckList_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool allSelected = updateCostDetailSelectedPanel();
            checkFromUi = false;
            allSelectedCheckBox.Checked = allSelected;
            checkFromUi = true;
        }

        private bool updateCostDetailSelectedPanel()
        {
            costTotalAmountChart.ChartAreas.Clear();
            costTotalAmountChart.ChartAreas.Add(createChartArea());
            costUnitPriceChart.ChartAreas.Clear();
            costUnitPriceChart.ChartAreas.Add(createChartArea());
            bool allSelected = true;
            for (int i = 0; i < costNameCheckList.Items.Count; i++)
            {
                string name = costNameCheckList.GetItemText(costNameCheckList.Items[i]);
                Series amountSeries = seriesMap[name].Item1;
                amountSeries.Enabled = costNameCheckList.GetItemChecked(i);
                Series unitPriceSeries = seriesMap[name].Item2;
                unitPriceSeries.Enabled = costNameCheckList.GetItemChecked(i);
                if (!costNameCheckList.GetItemChecked(i))
                {
                    allSelected = false;
                }
            }
            return allSelected;
        }

        private void allSelectedCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkFromUi)
            {
                return;
            }
            for (int i = 0; i < costNameCheckList.Items.Count; i++)
            {
                costNameCheckList.SetItemChecked(i, allSelectedCheckBox.Checked);
            }
            updateCostDetailSelectedPanel();
        }

        private ChartArea createChartArea()
        {
            ChartArea chartArea = new ChartArea("ChartArea1");
            chartArea.AxisX.IntervalAutoMode = IntervalAutoMode.VariableCount;
            chartArea.AxisX.IsMarginVisible = false;
            chartArea.AxisX.MajorGrid.Enabled = false;
            chartArea.AxisX.ScaleBreakStyle.MaxNumberOfBreaks = 1;
            chartArea.AxisY.IntervalAutoMode = IntervalAutoMode.VariableCount;
            chartArea.AxisY.IsMarginVisible = false;
            chartArea.AxisY.MajorGrid.Enabled = false;
            chartArea.AxisY.ScaleBreakStyle.MaxNumberOfBreaks = 1;
            chartArea.Position.Auto = false;
            chartArea.Position.Height = 72.11099F;
            chartArea.Position.Width = 94F;
            chartArea.Position.X = 3F;
            chartArea.Position.Y = 25.889F;
            return chartArea;
        }

        private void totalAmountButton_CheckedChanged(object sender, EventArgs e)
        {
            bool totalIsChecked = totalAmountButton.Checked;
            costTotalAmountChart.Visible = totalIsChecked;
            costUnitPriceChart.Visible = !totalIsChecked;
        }
    }
}

using QuanLyThienNguyen.BBL;
using QuanLyThienNguyen.DAL;
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

namespace QuanLyThienNguyen.GUI
{
    public partial class TK_Form : Form
    {
        public TK_Form()
        {
            InitializeComponent();
        }
        private void button_TimKiem_Click(object sender, EventArgs e)
        {
            if (combobox_MaHTUH.SelectedItem != null) 
            {
                datagridview.DataSource = BBL_Statistical.Instance.View(combobox_MaHTUH.SelectedItem.ToString());
                if (combobox_LoaiThongKe.SelectedItem == null)
                {

                    combobox_LoaiThongKe.SelectedIndex = 0;
                }
                if (combobox_Chart.SelectedItem == null)
                {

                    combobox_Chart.SelectedIndex = 0;
                }
                chart.Series.Clear();
                chart.Series.Add(BBL_Statistical.Instance.Series(combobox_Chart.SelectedItem.ToString(), combobox_MaHTUH.SelectedItem.ToString(), combobox_LoaiThongKe.SelectedItem.ToString()));
                chart.ChartAreas[0].AxisY.Title = combobox_MaHTUH.SelectedItem.ToString();
                chart.ChartAreas[0].AxisY.Maximum = BBL_Statistical.Instance.data.Max()*1.1;
                chart.Update();     
            }
            else
            {
                MessageBox.Show("Lựa chọn hình thức ủng hộ !!!");
            }
        }

        private void TK_Form_Load(object sender, EventArgs e)
        {
            combobox_MaHTUH.Items.Clear();
            combobox_MaHTUH.Items.AddRange(BBL_ComboBox.Instance.Combobox_Statistical_TenHTUH().ToArray());
        }
    }
}

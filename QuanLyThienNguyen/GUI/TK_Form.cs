using QuanLyThienNguyen.BBL;
using System;
using System.Linq;
using System.Windows.Forms;

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
            if (combobox_TenHTUH.SelectedItem != null)
            {
                datagridview.DataSource = BBL_ThongKe.Instance.GetAllThongKe(combobox_TenHTUH.SelectedItem.ToString());
                if (combobox_LoaiThongKe.SelectedItem == null)
                {

                    combobox_LoaiThongKe.SelectedIndex = 0;
                }
                if (combobox_Chart.SelectedItem == null)
                {

                    combobox_Chart.SelectedIndex = 0;
                }
                chart.Series.Clear();
                chart.Series.Add(BBL_ThongKe.Instance.Series(combobox_Chart.SelectedItem.ToString(), combobox_TenHTUH.SelectedItem.ToString(), combobox_LoaiThongKe.SelectedItem.ToString()));
                chart.ChartAreas[0].AxisY.Title = combobox_TenHTUH.SelectedItem.ToString();
                chart.ChartAreas[0].AxisY.Maximum = BBL_ThongKe.Instance.data.Max() * 1.1;
                chart.Update();
            }
            else
            {
                MessageBox.Show("Lựa chọn hình thức ủng hộ !!!");
            }
        }

        private void TK_Form_Load(object sender, EventArgs e)
        {
            combobox_TenHTUH.Items.Clear();
            combobox_TenHTUH.Items.AddRange(BBL_ComboBox.Instance.Combobox_TK().ToArray());
            BBL_ThongKe.Instance.Delete();
            BBL_ThongKe.Instance.Add();
        }

        private void combobox_Chart_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combobox_TenHTUH.SelectedItem != null)
                button_TimKiem_Click(sender, e);
        }

        private void combobox_LoaiThongKe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combobox_TenHTUH.SelectedItem != null)
                button_TimKiem_Click(sender, e);
        }
    }
}

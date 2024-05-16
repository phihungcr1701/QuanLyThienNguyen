using System.Windows.Forms;
using QuanLyThienNguyen.BBL;
using QuanLyThienNguyen.DTO;

namespace QuanLyThienNguyen.GUI.Admin
{
    public partial class CTUH_Form : Form
    {
        public delegate void MyDel();
        public MyDel d {  get; set; }
        public CTUH_Form()
        {
            InitializeComponent();
            setCBB();
        }
        private void setCBB()
        {
            cbb_MaDUH.Items.AddRange(BBL_Activity.Instance.GetCBB("MaDUH", "DotUngHo").ToArray());
            cbb_MaDVUH.Items.AddRange(BBL_Activity.Instance.GetCBB("MaDVUH", "DonViUngHo").ToArray());
            cbb_MaHD.Items.AddRange(BBL_Activity.Instance.GetCBB("MaHD", "HoDan").ToArray());
            cbb_MaHTUH.Items.AddRange(BBL_Activity.Instance.GetCBB("MaHTUH", "HinhThucUngHo").ToArray());
        }

        private void btn_ThucHien_Click(object sender, EventArgs e)
        {
            int MaDUH = Convert.ToInt32(cbb_MaDUH.SelectedItem.ToString());
            int MaDVUH = Convert.ToInt32(cbb_MaDVUH.SelectedItem.ToString());
            int MaHD = Convert.ToInt32(cbb_MaHD.SelectedItem.ToString());
            int MaHTUH = Convert.ToInt32(cbb_MaHTUH.SelectedItem.ToString());
            double SoLuongUH = Convert.ToDouble(txt_SoLuongUH.Text);
            double SoLuongNUH = Convert.ToDouble(txt_SoLuongNUH.Text);
            Activity activity = new Activity(MaDUH, MaDVUH, MaHD, MaHTUH, SoLuongUH, SoLuongNUH);
            BBL_Activity.Instance.AddActivity(activity);
            this.Dispose();
            //d();
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}

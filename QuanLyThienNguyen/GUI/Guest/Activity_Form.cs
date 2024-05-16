using System.Windows.Forms;

namespace QuanLyThienNguyen.GUI
{
    public partial class Activity_Form : Form
    {
        public Activity_Form()
        {
            InitializeComponent();
        }

        public void GetLabel_GioiThieu(string st)
        {
            label_GioiThieu.Text = st;
        }
    }
}

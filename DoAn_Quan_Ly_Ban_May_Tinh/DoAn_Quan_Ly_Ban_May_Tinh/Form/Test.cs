using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAn_Quan_Ly_Ban_May_Tinh.Script;
namespace DoAn_Quan_Ly_Ban_May_Tinh
{   public partial class Test : Form
    {
 
        public Test()
        {
            InitializeComponent();
        }
        private Script.FormatData formatdata = new FormatData();
        private List<HangHoa> HangHoaList = new List<HangHoa>();
        private void uiComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void uiLabel21_Click(object sender, EventArgs e)
        {

        }

        private void Test_Load(object sender, EventArgs e)
        {
            formatdata.AddComboBoxLMH(txtlmh);
            formatdata.LoadDataGirdView(uiDataGridView2, HangHoaList);
            this.WindowState  = FormWindowState.Maximized;
        }

        private void uiDataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var index = uiDataGridView2.CurrentCell.RowIndex;
            if(index >= 0)
            {
                var selectrow = uiDataGridView2.Rows[index];
                txt_masp.Text  = selectrow.Cells[0].Value.ToString();
                txttensp.Text = selectrow.Cells[1].Value.ToString();
                txtsl.Value = int.Parse(selectrow.Cells[2].Value.ToString());
                txtgb.Text = selectrow.Cells[3].Value.ToString();
                txtlmh.Text = selectrow.Cells[4].Value.ToString();
                txtncn.Text = selectrow.Cells[5].Value.ToString();
            }
        }
        public void AddSaveFix(bool IsFix, bool IsAdd)
        {
            try
            {
                DBContext dBContext = new DBContext();
                if (IsFix == true)
                {

                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

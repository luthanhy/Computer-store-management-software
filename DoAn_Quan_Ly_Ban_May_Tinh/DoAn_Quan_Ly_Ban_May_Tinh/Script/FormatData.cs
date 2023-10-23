using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_Quan_Ly_Ban_May_Tinh.Script
{
    public class FormatData
    {
        public void LoadDataGirdView<T>(Sunny.UI.UIDataGridView dataGrid, List<T> data)
        {
            dataGrid.DataSource = null;
            dataGrid.DataSource = GetDataFormDB<T>();
        }
        public List<T> GetDataFormDB<T>()
        {
            List<T> result = new List<T>();
            DBContext dBContext = new DBContext();

            if (typeof(T) == typeof(HangHoa))
            {
                result.AddRange(dBContext.HangHoas.Cast<T>());
            }
            else if (typeof(T) == typeof(KhachHang))
            {
                result.AddRange(dBContext.KhachHangs.Cast<T>());
            }
            else if (typeof(T) == typeof(HoaDon))
            {
                result.AddRange(dBContext.HoaDons.Cast<T>());
            }
            else if (typeof(T) == typeof(ChiTietHoaDon))
            {
                result.AddRange(dBContext.ChiTietHoaDons.Cast<T>());
            }
            else if (typeof(T) == typeof(PhieuXuatHang))
            {
                result.AddRange(dBContext.PhieuXuatHangs.Cast<T>());
            }
            return result;
        }
        public void AddComboBoxLMH(Sunny.UI.UIComboBox comboBox)
        {
            comboBox.Items.Add("LapTop");
            comboBox.Items.Add("PC");
        }

    }
}

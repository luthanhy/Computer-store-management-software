using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_Quan_Ly_Ban_May_Tinh.Scripts
{
    public class Contant_Frame
    {
        public void LoadGridViewData<T>(DataGrid dataGrid, List<T> list)
        {
            dataGrid.DataSource = null;
            dataGrid.DataSource = list;
        }
        public List<T> GetDataFromDB<T>()
        {
            List<T> result =  new List<T>();
            //QLSVDBContext dbContext = new QLSVDBContext();

            //if (typeof(T) == typeof(Student))
            //{
            //    result.AddRange(dbContext.Student.Cast<T>());
            //}
            return result;
        }
    }
}

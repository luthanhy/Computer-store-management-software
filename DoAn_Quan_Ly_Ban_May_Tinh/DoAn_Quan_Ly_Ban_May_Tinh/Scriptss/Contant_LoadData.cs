using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_Quan_Ly_Ban_May_Tinh.Scriptss
{
    public class Contant_LoadData
    {
        #region LoadData
        public void LoadGridViewData<T>(DataGrid dataGrid, List<T> list)
        {
            dataGrid.DataSource = null;
            dataGrid.DataSource = list;
        }
        private List<T> GetDataFromDB<T>()
        {
            List<T> data = new List<T>();
            //QLSVDBContext dbContext = new QLSVDBContext();

            //if (typeof(T) == typeof())
            //{
            //    data.AddRange(dbContext.Student.Cast<T>());
            //}
            

            return data;
        }
        #endregion
        #region Add/Fix/Save

        //private void FlagEnableAddSave()
        //{
        //    try
        //    {
        //        if (Is_fix)
        //        {
        //            StudentData fix_student = connectDataBases.Student.Find(txt_idstudent.Text);
        //            if (fix_student == null)
        //            {
        //                MessageBox.Show("Don't find student to fix");
        //            }
        //            else
        //            {
        //                fix_student.Name = txt_namestudent.Text;
        //                fix_student.Class = txt_classstudent.Text;
        //                connectDataBases.Entry<StudentData>(fix_student).State = System.Data.Entity.EntityState.Modified;
        //                connectDataBases.SaveChanges();
        //                MessageBox.Show("Fix Success");
        //            }
        //        }
        //        else
        //        {
        //            if (txt_classstudent.ReadOnly == true)
        //            {
        //                MessageBox.Show("No Data To Save");
        //            }
        //            else
        //            {
        //                if (connectDataBases.Student.Find(txt_idstudent.Text) == null)
        //                {
        //                    if (string.IsNullOrEmpty(txt_idstudent.Text))
        //                    {
        //                        MessageBox.Show("Please enter id student");
        //                    }
        //                    else if (string.IsNullOrEmpty(txt_classstudent.Text))
        //                    {
        //                        MessageBox.Show("Please enter class student");
        //                    }
        //                    else if (string.IsNullOrEmpty(txt_namestudent.Text))
        //                    {
        //                        MessageBox.Show("Please enter name student");
        //                    }
        //                    else if (string.IsNullOrEmpty(txt_idstudent.Text) && string.IsNullOrEmpty(txt_namestudent.Text) && string.IsNullOrEmpty(txt_classstudent.Text))
        //                    {
        //                        MessageBox.Show("Please enter information student");

        //                    }
        //                    else
        //                    {
        //                        StudentData student = new StudentData();
        //                        connectDataBases.Student.Add(Init_Student(student));
        //                        connectDataBases.SaveChanges();
        //                        MessageBox.Show("Add student success");
        //                        InactiveText();

        //                    }
        //                }
        //                else
        //                {
        //                    MessageBox.Show("Id Can't duplicate");
        //                    txt_idstudent.Text = string.Empty;
        //                    InactiveText();
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.InnerException.Message);
        //    }
        //}
        //private void SetActiveText()
        //{
        //}
        #endregion
        #region Delete
        //private void DeleteStudentDB()
        //{
        //    try
        //    {
        //        var student = connectDataBases.Student.Find(txt_idstudent.Text);
        //        if (student != null)
        //        {
        //            connectDataBases.Student.Remove(student);
        //            connectDataBases.SaveChanges();
        //            InactiveText();
        //            MessageBox.Show("Delete student Success");
        //        }
        //        else
        //        {
        //            MessageBox.Show("Dont have student in Class");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}
        #endregion
        
    }
}

using empApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace empApp
{
    public partial class empAddForm : Form
    {
        public empAddForm(int id, Main main)
        {
            InitializeComponent();
            empAppTable.Id = id;
            this.main = main;
        }

        EmpAppTable empAppTable = new EmpAppTable();
        private readonly Main main;

        private void btn_empsave_Click(object sender, EventArgs e)
        {
            if (check() == true)
            {
                empAppTable.FullName = txt_name.Text.Trim();
                empAppTable.MotherName = txt_mothername.Text.Trim();
                empAppTable.Email = txt_email.Text.Trim();
                empAppTable.Address = txt_address.Text.Trim();
                empAppTable.Phone = txt_phone.Text.Trim();
                empAppTable.BirthData = dateTimePicker1.Value.Date;


                using (EmpAppContext EappContext = new EmpAppContext())
                {
                    if (empAppTable.Id == 0)
                    {
                        EappContext.EmpAppTables.Add(empAppTable);
                        MessageBox.Show("تمت الإضافة بنجاح");
                    }
                    else
                    {
                        EappContext.EmpAppTables.Update(empAppTable);
                        //EappContext.Entry(empAppTable).State = EntityState.Modified;
                        MessageBox.Show("تمت التعديل بنجاح");
                    }
                    EappContext.SaveChanges();
                }
                //Main main = new Main();
                main.loadData();
                //MessageBox.Show("تمت الإضافة بنجاح");
                this.Close();
            }
            else
            {
                MessageBox.Show("تحقق من متطلبات الادخال");
            }

        }
        bool check()
        {
            if (String.IsNullOrEmpty(txt_name.Text.Trim()) || txt_mothername.Text.Trim() == string.Empty
                || txt_address.Text.Trim() == string.Empty)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


    }
}

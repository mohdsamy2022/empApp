using empApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Windows.Forms;

namespace empApp
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        EmpAppTable empAppTable = new EmpAppTable();
        private void btn_add_Click(object sender, EventArgs e)
        {
            empAddForm empAddForm = new empAddForm(0, this);
            empAddForm.Show();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            empAppTable.Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            empAddForm empAddForm = new empAddForm(empAppTable.Id, this);
            empAddForm.Show();
            using (EmpAppContext EappContext = new EmpAppContext())
            {
                empAppTable = EappContext.EmpAppTables.Where(t => t.Id == empAppTable.Id).FirstOrDefault();
                empAddForm.txt_name.Text = empAppTable.FullName;
                empAddForm.txt_mothername.Text = empAppTable.MotherName;
                empAddForm.txt_email.Text = empAppTable.Email;
                empAddForm.txt_address.Text = empAppTable.Address;
                empAddForm.txt_phone.Text = empAppTable.Phone;
                empAddForm.dateTimePicker1.Value = empAppTable.BirthData;
            }

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Â· √‰  „ √ﬂœø", "⁄„·Ì… Õ–›", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                empAppTable.Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

                using (EmpAppContext EappContext = new EmpAppContext())
                {
                    empAppTable = EappContext.EmpAppTables.Where(t => t.Id == empAppTable.Id).FirstOrDefault();
                    EappContext.EmpAppTables.Remove(empAppTable);
                    EappContext.SaveChanges();
                    loadData();
                    MessageBox.Show(" „  ⁄„·Ì… «·Õ–› »‰Ã«Õ");
                }

                /*using (EmpAppContext EappContext = new EmpAppContext())
                {
                    var entry = EappContext.Entry(empAppTable);
                    if (entry.State == EntityState.Detached)
                    {
                        EappContext.EmpAppTables.Attach(empAppTable);
                    }
                    EappContext.EmpAppTables.Remove(empAppTable);
                    EappContext.SaveChanges();
                    loadData();
                    MessageBox.Show(" „  ⁄„·Ì… «·Õ–› »‰Ã«Õ");
                }*/
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            loadData();
        }
        public async void loadData()
        {
            //dataGridView1.AutoGenerateColumns = false;
            //dataGridView1.Columns.Clear();

            using (EmpAppContext EappContext = new EmpAppContext())
            {
                //dataGridView1.DataSource = EappContext.EmpAppTables.ToList<EmpAppTable>();
                dataGridView1.DataSource = await Task.Run(() => EappContext.EmpAppTables.ToList<EmpAppTable>());
            }
            dataGridView1.Columns[0].HeaderText = "«·„⁄—›";
            dataGridView1.Columns[1].HeaderText = "«·«”„ «·ﬂ«„·";
            dataGridView1.Columns[2].HeaderText = "«”„ «·«„";
            dataGridView1.Columns[3].HeaderText = " «—ÌŒ «·„Ì·«œ";
            dataGridView1.Columns[4].HeaderText = "«·⁄‰Ê«‰";
            dataGridView1.Columns[5].HeaderText = "—ﬁ„ «·Â« ›";
            dataGridView1.Columns[6].HeaderText = "«·»—Ìœ «·«·ﬂ —Ê‰Ì";
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            if (txt_search.Text != string.Empty)
            {
                Search(txt_search.Text);
            }
            else
            {
                loadData();
            }

        }

        private async void Search(string SearchItem)
        {
            using (EmpAppContext EappContext = new EmpAppContext())
            {
                //SearchItem = txt_search.Text;
                //dataGridView1.DataSource = EappContext.EmpAppTables.ToList<EmpAppTable>();
                //var flag = EappContext.EmpAppTables.Where(t => t.FullName.Contains(SearchItem)).ToList();
                // if (flag.Count > 0)
                // {
                //    dataGridView1.DataSource = flag;
                // }
                //if (flag)
                // {
                //dataGridView1.DataSource = await Task.Run(() => EappContext.EmpAppTables.Where(t => t.FullName == SearchItem).First());
                dataGridView1.DataSource = await Task.Run(() => EappContext.EmpAppTables.Where(t => t.FullName.Contains(SearchItem) || t.Address.Contains(SearchItem) || t.Phone.Contains(SearchItem) || t.MotherName.Contains(SearchItem)).ToList());
                //dataGridView1.DataSource = EappContext.EmpAppTables.Where(t => t.FullName.Contains(SearchItem)).ToList();
                // }

            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (txt_search.Text != string.Empty)
            {
                Search(txt_search.Text);
            }
            else
            {
                loadData();
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AddressBook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                panel1.Enabled = true;
                App.AddressBook.AddAddressBookRow(App.AddressBook.NewAddressBookRow());
                addressBookBindingSource.MoveLast();
                textBox1.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                App.AddressBook.RejectChanges();
            }
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            textBox1.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            addressBookBindingSource.ResetBindings(false);
            panel1.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                addressBookBindingSource.EndEdit();
                App.AddressBook.AcceptChanges();
                App.AddressBook.WriteXml(string.Format("{0}//data.dat", Application.StartupPath));
                panel1.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                App.AddressBook.RejectChanges();
            }
        }

        static AppData db;
        protected static AppData App
        {
            get
            {
                if (db == null)
                    db = new AppData();
                return db;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string filename = string.Format("{0}//data.dat", Application.StartupPath);
            if (File.Exists(filename))
                App.AddressBook.ReadXml(filename);
            addressBookBindingSource.DataSource = App.AddressBook;
            panel1.Enabled = false;

            textBox1.DataBindings.Add("Text", addressBookBindingSource, "Book Title", true, DataSourceUpdateMode.OnPropertyChanged);
            textBox2.DataBindings.Add("Text", addressBookBindingSource, "Book Author", true, DataSourceUpdateMode.OnPropertyChanged);
            dateTimePicker1.DataBindings.Add("Text", addressBookBindingSource, "Publishing Date", true, DataSourceUpdateMode.OnPropertyChanged);
            textBox3.DataBindings.Add("Text", addressBookBindingSource, "Genre", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    addressBookBindingSource.RemoveCurrent();
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (!string.IsNullOrEmpty(txtSearch.Text))
                {
                    var query = from o in App.AddressBook
                                where o.PhoneNumber == txtSearch.Text || o.FullName.Contains(txtSearch.Text) || o.Email == txtSearch.Text
                                select o;
                    dataGridView1.DataSource = query.ToList();
                }
                else
                    dataGridView1.DataSource = addressBookBindingSource;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

namespace ex_2
{
    public partial class Form_lab4_2 : Form
    {
        public Form_lab4_2()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string gender;
            string age = Convert.ToString(numericUpDown1.Value);
            string MaritialStatus;
            if (checkBox1.Checked)
            {
                MaritialStatus = "Maried";
            }
            else
            {
                MaritialStatus = "Single";
            }

            if (radioButton1.Checked)
            {
                gender = radioButton1.Text;
            }
            else
            {
                gender = radioButton2.Text;
            }

            MessageBox.Show("Gender :" + gender + "\n" + "Age:" + age + "\n" + "Maritial Status :" + MaritialStatus, "Message Box", MessageBoxButtons.OK);
        }

        private void Form_lab4_2_Load(object sender, EventArgs e)
        {

        }
    }
}

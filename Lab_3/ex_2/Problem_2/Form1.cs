namespace Problem_2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Today;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox2.Text;
            string surname = textBox1.Text;
            DateTime dateOfBirth = dateTimePicker1.Value;

            // Create a Person object
            Person_1 person = new Person_1(name, surname, dateOfBirth);

            // Calculate age
            int age = person.CalculateAge();

            // Display age in the corresponding text box
           label4.Text = age.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

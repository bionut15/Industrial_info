using ex_2;
using Ex_3;


namespace ex_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void displayForm1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_lab4_2 Form = new Form_lab4_2();
            Form.ShowDialog();
        }

        private void dsiplayForm2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pyramid_with_square_base  form = new Pyramid_with_square_base();
            form.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void lldToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

using Microsoft.VisualBasic.ApplicationServices;

namespace casinoDaddy2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void spinButton_Click(object sender, EventArgs e)
        {
            try
            {
                randomOutput random = new randomOutput();
                // Load the default image from a file

                // Loop through PictureBoxes 1-15 and set the image
                for (int i = 1; i <= 15; i++)
                {
                    Image image = Image.FromFile("C:\\Users\\OliverApelqvistEriks\\source\\repos\\casinoDaddy2\\images\\" + random.randomNumber(5+1) + ".png");
                    PictureBox pictureBox = (PictureBox)this.Controls.Find("pictureBox" + i.ToString(), true)[0];
                    pictureBox.Image = (image);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading default image: " + ex.Message);
            }
        }
    }
}
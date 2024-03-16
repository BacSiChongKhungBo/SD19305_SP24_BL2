namespace SD19305_Bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void openFromFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                axWindowsMediaPlayer1.URL = ofd.FileName;
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
        }
    }
}
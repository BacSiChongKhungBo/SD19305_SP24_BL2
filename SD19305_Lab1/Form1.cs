namespace SD19305_Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
            txt_result.Enabled = false;
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            int result = Convert.ToInt32(txt_soA.Text) + Convert.ToInt32(txt_soB.Text);
            txt_result.Text = result.ToString();

        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_result.Clear();
            txt_soA.Clear();
            txt_soB.Clear();
        }

        private void btn_checkout_Click(object sender, EventArgs e)
        {
            int tongtien = 0;
            if (checkBox1.Checked == true) // tương ứng đang chọn
            {
                tongtien += 250;
            }
            if (checkBox2.Checked == true) // tương ứng đang chọn
            {
                tongtien += 100;
            }
            if (checkBox3.Checked == true) // tương ứng đang chọn
            {
                tongtien += 450;
            }
            txt_hoadon.Text = tongtien.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //xóa là lỗi nhé
        }
    }
}
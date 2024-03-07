namespace SD19305_Bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //label
            //textbox
            
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            txt_MSV.Text = "PH12345";
            txt_hoten.Text = "Quỳnh Bei";
            rtxt_dchi.Text = "FBT Polyme";
            rbtn_nam.Checked = true;
            rbtn_TMDT.Checked = true;
            cbx_CSharp.Checked = true;
            dateTimePicker1.Value = DateTime.Now;
            dtgDisplay();
        }

        public void dtgDisplay()
        {
            //B1:xác định số cột
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "Mã Sinh Viên";
            dataGridView1.Columns[1].Name = "Họ Tên";
            dataGridView1.Columns[2].Name = "Địa Chỉ";
            dataGridView1.Columns[3].Name = "Giới tính";
            //B2:Dòng
            dataGridView1.Rows.Add(txt_MSV.Text, 
                                   txt_hoten.Text, 
                                   rtxt_dchi.Text, 
                                   rbtn_nam.Text);
        }
    }
}
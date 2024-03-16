using SD19305_Bai4_DAL.Context;
using SD19305_Bai4_DAL.DomainClass;

namespace SD19305_Bai4_PRL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dtgDisplay();
        }

        public void dtgDisplay()
        {
            Nhanvien nv = new Nhanvien();
            List<Nhanvien> lst = new List<Nhanvien>();
            MyContext m = new MyContext();
            lst = m.Nhanviens.ToList();
            //B1:xác định số cột
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "Họ tên";
            dataGridView1.Columns[1].Name = "Manv";
            dataGridView1.Columns[2].Name = "lương";
            dataGridView1.Columns[3].Name = "Dchi";
            dataGridView1.Columns[4].Name = "Giới tính";
            //B2:Dòng
            foreach(Nhanvien n in lst)
            {
                dataGridView1.Rows.Add(n.Hoten,
                                   n.Manv,
                                   n.Luong,
                                   n.Dchi,
                                   n.Phai);
            }
            
        }
    }
}

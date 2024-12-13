using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace LQD_10_12
{
    public partial class Form1 : Form
    {
        private DocGiaBLL docGiaBLL;
        public Form1()
        {
            InitializeComponent();
            docGiaBLL = new DocGiaBLL();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                GridDocGia.DataSource = docGiaBLL.GetAllDocGia();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnQLTaiKhoan_Click(object sender, EventArgs e)
        {

        }

        private void btnDSLoaiDocGia_Click(object sender, EventArgs e)
        {

        }

        private void btnThemDG_Click(object sender, EventArgs e)
        {

        }

        private void GridDocGia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

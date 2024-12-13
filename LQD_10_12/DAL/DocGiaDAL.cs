using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DocGiaDAL
    {
        // Chuỗi kết nối tới SQL Server



        // Phương thức lấy toàn bộ dữ liệu độc giả
        public DataTable GetAllDocGia()
        {
            SqlConnection connectionString = DBConnect.Connect();
            connectionString.Open();
            string query = "SELECT * FROM DocGia"; // Câu lệnh SQL
            SqlDataAdapter adapter = new SqlDataAdapter(query, connectionString);
            DataTable table = new DataTable(); // Lưu kết quả query
            adapter.Fill(table); // Đổ dữ liệu vào DataTable
            return table; // Trả dữ liệu về lớp BLL
            connectionString.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class DocGiaBLL
    {
        public DocGiaDAL docGiaDAL;

        public DocGiaBLL()
        {
            // Khởi tạo đối tượng DAL
            docGiaDAL = new DocGiaDAL();
        }

        // Phương thức lấy toàn bộ danh sách độc giả
        public DataTable GetAllDocGia()
        {
            // Gọi phương thức từ lớp DAL
            return docGiaDAL.GetAllDocGia();
        }
    }
}

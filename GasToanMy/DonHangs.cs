using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasToanMy
{
    public class DonHangs
    {
        public int ID { get; set; }
        public DateTime CreateDate { get; set;}
        public DateTime UpdateDate { get; set; }
        public string CreateUser { get; set; }
        public string UpdateUser { get; set; }
        public string Type { get; set; }
        public string Code { get; set; }
        public string CodeDonHang { get; set; }
        public string CodeSanPham { get; set; }
        public string TenSanPham { get; set; }
        public string RecordStatus { get; set; }
        public string Description { get; set; }
        public double SoLuong { get; set; }
        public double DonGia { get; set; }
        public double ThanhTien { get; set; }
    }
}

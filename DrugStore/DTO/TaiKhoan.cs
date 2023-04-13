using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiKhoan
    {
        private string sdt;
        private string name;
        private string pass;
        public TaiKhoan(string sdt, string name, string pass)
        {
            this.sdt = sdt;
            this.name = name;
            this.pass = pass;
        }
        public TaiKhoan(DataRow row)
        {
            this.SDT = row["SDT"].ToString();
            this.PASS = row["PASS"].ToString();
        }
        public TaiKhoan()
        {

        }
        public string SDT { get => sdt; set => sdt = value; }
        public string NAME { get => name; set => name = value; }
        public string PASS { get => pass; set => pass = value; }
    }
}

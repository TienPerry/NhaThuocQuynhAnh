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
        
        private string pass;
        public TaiKhoan(string pass)
        {
            
            this.pass = pass;
        }
        public TaiKhoan(DataRow row)
        {
            
            this.PASS = row["PASS"].ToString();
        }
        public TaiKhoan()
        {

        }
        
        public string PASS { get => pass; set => pass = value; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BDS_2020.Class
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows;

    public partial class LichSuXem
    {
        public DataProvider DP { get; set; }

        public LichSuXem()
        {
            DP = new DataProvider();
        }

        public string MaKH { get; set; }
        public string MaNha { get; set; }
        public string MaCN { get; set; }
        public Nullable<System.DateTime> NgayXem { get; set; }
        private string nhanXet;
        public string NhanXet {
            get
            {
                return nhanXet;
            }
            set
            {
                if(nhanXet != null)
                {
                    var viewHistoryList = DP.Database.LichSuXems.SingleOrDefault(p => p.MaKH == this.MaKH && p.MaCN == this.MaCN && p.MaNha == this.MaNha && p.NgayXem == this.NgayXem);
                    viewHistoryList.nhanXet = value;
                    DP.Database.SaveChanges();
                }
                nhanXet = value;
            }
        }
        public Nullable<bool> DeleteStatus { get; set; }
    
        public virtual BD BD { get; set; }
        public virtual KhachHang KhachHang { get; set; }
    }
}

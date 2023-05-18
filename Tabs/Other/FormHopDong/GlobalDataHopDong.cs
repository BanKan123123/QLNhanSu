using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace QLNhanSu.Tabs.Other.FormHopDong
{
    public class GlobalDataHopDong
    {
        public static int SelectedSoHopDong {  get; set; }    
        public static string SelectedNguoiDaiDien { get; set; }

        public static int SelectedManv { get; set; }

        public static string SelectedNgayBatDau { get; set; }

        public static string SelectedNgayKetThuc { get; set; }
        
        public static string SelectedNgayKy { get; set; }

        public static string SelectedNoiDung { get; set; }

        public static int SelectedLanKy { get; set; }   

        public static string SelectedThoiGian { get; set ; }

        public static float SelectedHeSoLuong { get; set; } 

        public static float SelectedLuongCoBan { get; set; }

        public static string SelectedLoaiHopDong { get; set; }  

        public static int SelectedMACTY { get; set; }
    }
}

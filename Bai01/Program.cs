

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai01
{
    class NhanVien
    {
        private string HoTen;
        private int soNgayCong;
        private int SoNgayLamThem;
        private string xeploai;
        private string boPhan;

        public NhanVien ()
        {
           
        }
        public NhanVien(string HoTen, int soNgayCong, int soNgayLamThem, string xeploai, string boPhan)
        {
            this.HoTen = HoTen;
            this.soNgayCong = soNgayCong;
            this.SoNgayLamThem = SoNgayLamThem;
            this.xeploai = xeploai;
            this.boPhan = boPhan;
        }
        public string hoten
        {
            get { return HoTen; }
            set { HoTen = value; }
        }
        public int songaycong
        {
            get { return soNgayCong; }
            set { soNgayCong = value; }
        }
        public int songaylamthem
        {
            get { return SoNgayLamThem; }
            set { SoNgayLamThem = value; }
        }
        public string XepLoai
        {
            get { return xeploai; }
           set { xeploai = value; }
        }
        public string bophan
        {
            get { return boPhan; }
            set { boPhan = value; }
        }
        public double tinhLuong()
        {
            int soNgayLamThemTang = 0;
            if (bophan.Equals("Truc Tiep:"))
            {
                soNgayLamThemTang = songaylamthem * 3;

            }
            else if (bophan.Equals("GianTiep:"))
            {
                soNgayLamThemTang = songaylamthem * 2;
            }
            return (soNgayCong + soNgayLamThemTang) * 100000;
        }
        public double tinhThuNhap()
        {
            double thunhap = tinhLuong();
                switch (xeploai)
            {
                case "A":
                    thunhap = thunhap * 1.5;
                    break;
                case "B":
                    thunhap = thunhap * 1.2;
                    break;
                default:
                    break;
            }
            return thunhap;
        }
        public void inThongTin()
        {
            Console.WriteLine("Ho ten: " + hoten);
            Console.WriteLine("Bo phan: " + bophan);
            Console.WriteLine("Thu Nhap: " + tinhThuNhap());
        }
        static void Main(string[] args)
        {
            NhanVien nhanvien1 = new NhanVien();

            Console.Write("Nhap Ho Ten Nhan Vien :");
            nhanvien1.HoTen = Console.ReadLine();

            Console.Write("Nhap So Ngay Cong: ");
            nhanvien1.songaycong = int.Parse(Console.ReadLine());

            Console.Write("Nhap So Ngay Lam them: ");
            nhanvien1.SoNgayLamThem = int.Parse(Console.ReadLine());

            Console.Write("Nhap Xep Loai (A/B/C): ");
            nhanvien1.xeploai = Console.ReadLine();

            Console.Write("Nhap Bo Phan (Truc tiep hay Gian tiep): ");
            nhanvien1.boPhan = Console.ReadLine();

            Console.WriteLine("\nIn thong tin nhan vien vua nhap:");
            nhanvien1.inThongTin();

            NhanVien nhanVien2 = new NhanVien("Le The Nguyen", 18, 3, "A", "Truc Tiep");
            Console.WriteLine("\nThong Tinh Nhan Vien 2");
            nhanVien2.inThongTin();
            Console.ReadLine();
            
        }
    }
}

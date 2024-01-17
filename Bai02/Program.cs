using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai02
{
    class ChuNhat
    {
        private double rong;
        private double dai;

        public ChuNhat (double rong, double dai)
        {
            this.dai = dai;
            this.rong = rong;
        }
        public double TinhChuvi()
        {
            return 2 * (dai + rong);
        }
        public double Tinhdientich()
        {
            return dai * rong;
        }
        public virtual void Xuat()
        {
            Console.WriteLine("Chieu dai hinh chu nhat: " + dai);
            Console.WriteLine("Chieu rong hinh chu nhat: " + rong);
            Console.WriteLine("Dien tich hinh chu nhat: " + Tinhdientich());
            Console.WriteLine("Chu Vi hinh chu nhat: " + TinhChuvi());
        }
        class Vuong : ChuNhat
        {
            public Vuong(double canh) : base(canh, canh) { }
            public override void Xuat()
            {
                Console.WriteLine("Canh Hinh Vuong" + dai);
                Console.WriteLine("Dien tich: " + Tinhdientich());
                Console.WriteLine("ChuVi " + TinhChuvi());
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Nhap Chieu Dai Hinh Chu Nhat: ");
            double daiCN = double.Parse(Console.ReadLine());

            Console.Write("Nhap Chieu Rong Hinh Chu Nhat: ");
            double rongCN = double.Parse(Console.ReadLine());

            Console.Write("Nhap Canh Hinh Vuong: ");
            double CanhVuong = double.Parse(Console.ReadLine());

            ChuNhat cn = new ChuNhat(daiCN, rongCN );
            Vuong vuong = new Vuong(CanhVuong);

            Console.WriteLine("\n Thong Tin Hinh Chu Nhat: ");
            cn.Xuat();

            Console.WriteLine("\n Thong Tin Hinh Vuong:");
            vuong.Xuat();
            Console.ReadLine();
        }
    }
}

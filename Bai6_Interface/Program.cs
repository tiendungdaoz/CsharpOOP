namespace Interface
{
    interface IHinhHoc
    {
        public double TinhChuVi();
        public double TinhDienTich();
    }

    class HinhChuNhat : IHinhHoc
    {

        public double a;
        public double b;
        public HinhChuNhat(double _a, double _b)
        {
            a = _a;
            b = _b;
        }
        public double TinhChuVi()
        {
            return 2 * (a + b);
        }
        public double TinhDienTich()
        {
            return a * b;
        }
    }

    interface IDongVatTrenCan
    {
        void Jump();
    }

    interface IDongVatDuoiNuoc
    {
        void Swim();
    }

    class Ech : IDongVatTrenCan, IDongVatDuoiNuoc
    {
        public void Jump()
        {
            Console.WriteLine("Ech nhay cao 20 cm");
        }
        public void Swim()
        {
            Console.WriteLine("Ech boi rat xa");
        }
    }

    //Xu ly khi 2 interface co ten phuong thuc giong nhau
    interface ILandAnimal
    {
        void Move();
    }
    interface IWaterAnimal
    {
        void Move();
    }

    class Frog : ILandAnimal, IWaterAnimal
    {
        void ILandAnimal.Move()
        {
            Console.WriteLine("Ech nhay rat xa");
        }
        void IWaterAnimal.Move()
        {
            Console.WriteLine("Ech boi rat xa");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            #region Bai6: Interface
            HinhChuNhat hcn1 = new HinhChuNhat(4, 5);
            Console.WriteLine("Dien tich: {0}, chu vi: {1}", hcn1.TinhDienTich(), hcn1.TinhChuVi());

            Console.WriteLine();

            Ech echCon = new Ech();
            echCon.Jump();
            echCon.Swim();

            Console.WriteLine();
            IDongVatTrenCan echMe = new Ech();
            echMe.Jump();

            Console.WriteLine();
            //Xy ly trung ten ham khi thuc thi interface

            Frog echBo = new Frog();

            (echBo as ILandAnimal).Move();
            (echBo as IWaterAnimal).Move();
            #endregion
        }
    }
}

namespace Class
{
    //Bai 1
    class Animal
    {
        public double height;
        public double weight;

        public void Infor()
        {
            Console.WriteLine("Height: {0} cm, Weight: {1} kg", height, weight);
        }
    }

    class Cat
    {
        public double height;
        public double weight;

        //Constructor (khong co kieu tra ve)

        //Constructor khong tham so
        public Cat() 
        {
            //Gia tri mac dinh khi khoi tao doi tuong
            height= 30;
            weight= 9;
        }

        //Constructor co tham so
        public Cat(double hei, double wei)
        {
            height= hei;
            weight= wei;
        }

        //Destructor
        ~Cat()
        {
            Console.WriteLine("Huy");
        }
        public void Infor()
        {
            Console.WriteLine("Height: {0} cm, Weight: {1} kg", height, weight);
        }
    }

    //Bai 2
    class SinhVien
    {
        private string hoVaTen;
        private int maSV;
        private float diemToan;
        private float diemLy;
        private float diemHoa;

        //Property cho thuoc tinh private hovaten
        public string HoVaTen { get => hoVaTen; set => hoVaTen = value; }

        //Property cho thuoc tinh maSV
        public int MaSV
        {
            get { return maSV; }
            set
            {
                if (value <= 2020000 && value >= 2019000)
                {
                    maSV = value;
                }
            }
        }

        //Ham khoi tao (constructor)
        public SinhVien(string hoVaTen, int maSV, float diemToan, float diemLy, float diemHoa)
        {
            this.HoVaTen = hoVaTen;
            this.maSV = maSV;
            this.diemToan = diemToan;
            this.diemLy = diemLy;
            this.diemHoa = diemHoa;
        }

        public SinhVien() 
        {
            HoVaTen = "Duy";
            maSV = 20194959;
            diemToan = 8;
            diemLy = 7;
            diemHoa = 10;
        }

        public void InThongTinDiemTB()
        {
            float diemTB = (diemToan + diemLy + diemHoa) / 3;
            Console.WriteLine("Sinh vien {0} co diem trung binh la: {1}", HoVaTen, diemTB);
        }
    }

    //Bai 3
    class Fish
    {
        private double height;
        private double weight;

        //Bien static diem so luong con ca
        public static int count = 0;

        //Constructor (khong co kieu tra ve)

        //Constructor khong tham so
        public Fish()
        {
            //Gia tri mac dinh khi khoi tao doi tuong
            Height = 30;
            Weight = 9;
            count++;
        }

        //Constructor co tham so
        public Fish(double hei, double wei)
        {
            Height = hei;
            Weight = wei;
            count++;
        }

        //Destructor
        ~Fish()
        {
            Console.WriteLine("Huy");
        }

        //Property cho thuoc tinh private height, weight
        public double Height { get => height; set => height = value; }
        public double Weight { get => weight; set => weight = value; }


        public void Infor()
        {
            Console.WriteLine("Height: {0} cm, Weight: {1} kg", Height, Weight);
        }
    }

    //Bai 4: va Bai 5:
     
    //Lop truu tuong
    abstract class DongVat
    {
        protected int chieuCao;
        protected int canNang;
        protected int soChan;

        public DongVat()
        {

        }
        public DongVat(int cao, int nang, int chan)
        { 
            chieuCao= cao;
            canNang= nang;
            soChan= chan;
        }
        public void thongTin()
        {
            Console.WriteLine("Chieu cao: {0} cm, can nang: {1} kg, so chan: {2} chan", chieuCao, canNang, soChan);
        }

        //Phuong thuc ao de co the ghi de (the hien tinh da hinh)
        //Phuong thuc thuan ao voi tu khoa abstract (khong co dinh nghia gi ben trong)
        public abstract void Speak();

        //Hoan toan co the dung virtual de ghi de
        //public virtual void Speak()
        //{
        //    Console.WriteLine("Animal is speaking ...");
        //}

    }

    class Dog : DongVat
    {
        public Dog(int cao, int nang, int chan) : base(cao, nang, chan)
        {
           
        }
        public Dog()
        {
            chieuCao = 50;
            canNang= 20;
            soChan = 4;
        }
        
        //Tu khoa new chi dinh day la ham thongTin moi cua lop Dog
        public new void thongTin()
        {
            Console.WriteLine("Day la phuong thuc thongTin cua lop Dog");

            //Lay phuong thuc thongTin cua lop cha DongVat thong qua tu khoa base
            base.thongTin();
        }

        public override void Speak()
        {
            Console.WriteLine("Dog is speaking ...");
        }
    }
       
    class Chicken : DongVat
    {
        public override void Speak()
        {
            Console.WriteLine("Chicken is speaking ...");
        }
    }
    static class TienIch
    {
        public static double TinhLuyThua(int coSo, int soMu)
        {
            double kq = 1;
            for (int i = 0; i < soMu; i++)
            {
                kq = coSo * kq;
            }
            return kq;
        }
    }

    //Bai 6:Interface
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
            #region Bai1: Class
            //Animal cat = new Animal();
            //cat.height = 10;
            //cat.weight = 5;
            //cat.Infor();

            ////Ham khoi tao (constructor)
            //Cat BlackCat = new Cat(); //Constructor khong doi so
            //BlackCat.Infor();

            //Cat WhiteCat = new Cat(36, 15); //Constructor co doi so
            //WhiteCat.Infor();
            #endregion

            #region Bai2: Cac loai pham vi truy cap (Tinh dong goi du lieu)
            SinhVien Sv1 = new SinhVien("Dao Tien Dung", 20194969,10,9,9.5f);
            //Sv1.InThongTinDiemTB();

            //SinhVien Sv2 = new SinhVien();

            ////Su dung phuong thuc truy van thong qua property
            //Console.WriteLine("Ho va ten: {0}", Sv2.HoVaTen);

            //Sv2.InThongTinDiemTB();

            ////Su dung phuong thuc cap nhat thong qua property
            //Sv2.HoVaTen = "Phat";

            //Sv2.InThongTinDiemTB();

            #endregion

            #region Bai3: Tu khoa static

            //Bien static
            //Console.WriteLine("So luong con ca hien tai: {0}", Fish.count);

            //Fish fish1= new Fish();
            //Console.WriteLine("So luong con ca hien tai: {0}", Fish.count);

            //Fish fish2 = new Fish(20,30);
            //Console.WriteLine("So luong con ca hien tai: {0}", Fish.count);

            ////Phuong thuc static
            //Console.WriteLine("3 luy thua 9: {0}", TienIch.TinhLuyThua(3, 3));
            #endregion

            #region Bai4: Tinh ke thua
            //Dog blackDog = new Dog();
            //blackDog.thongTin();
            #endregion

            #region Bai5: Tinh da hinh
            //DongVat conCho = new Dog();
            //DongVat conGa = new Chicken();

            //conCho.Speak();
            //conGa.Speak();
            //conCho.thongTin();
            #endregion

            #region Bai6: Interface
            HinhChuNhat hcn1 = new HinhChuNhat(4,5);
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
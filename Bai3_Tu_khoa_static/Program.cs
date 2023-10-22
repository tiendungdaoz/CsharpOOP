namespace TuKhoaStatic
{
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

    class Program
    {
        static void Main(string[] args)
        {
            //Bien static
            Console.WriteLine("So luong con ca hien tai: {0}", Fish.count);

            Fish fish1 = new Fish();
            Console.WriteLine("So luong con ca hien tai: {0}", Fish.count);

            Fish fish2 = new Fish(20, 30);
            Console.WriteLine("So luong con ca hien tai: {0}", Fish.count);

            //Phuong thuc static
            Console.WriteLine("3 luy thua 9: {0}", TienIch.TinhLuyThua(3, 3));
        }
    }
}

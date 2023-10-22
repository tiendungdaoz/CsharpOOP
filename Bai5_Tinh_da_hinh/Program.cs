namespace TinhDaHinh
{
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
            chieuCao = cao;
            canNang = nang;
            soChan = chan;
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
            canNang = 20;
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

    class Program
    {
        static void Main(string[] args)
        {
            DongVat conCho = new Dog();
            DongVat conGa = new Chicken();

            conCho.Speak();
            conGa.Speak();
            conCho.thongTin();
        }
    }
}

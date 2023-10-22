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
            height = 30;
            weight = 9;
        }

        //Constructor co tham so
        public Cat(double hei, double wei)
        {
            height = hei;
            weight = wei;
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
    class Program
    {
        static void Main(string[] args)
        {
            #region Bai1: Class
            Animal cat = new Animal();
            cat.height = 10;
            cat.weight = 5;
            cat.Infor();

            //Ham khoi tao (constructor)
            Cat BlackCat = new Cat(); //Constructor khong doi so
            BlackCat.Infor();

            Cat WhiteCat = new Cat(36, 15); //Constructor co doi so
            WhiteCat.Infor();
            #endregion
        }
    }
}
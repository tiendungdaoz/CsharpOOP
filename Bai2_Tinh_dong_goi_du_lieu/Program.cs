namespace TinhDongGoiDuLieu
{
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

    class Program
    {
        static void Main(string[] args)
        {
            #region Bai2: Cac loai pham vi truy cap (Tinh dong goi du lieu)
            SinhVien Sv1 = new SinhVien("Dao Tien Dung", 20194969, 10, 9, 9.5f);
            Sv1.InThongTinDiemTB();

            SinhVien Sv2 = new SinhVien();

            //Su dung phuong thuc truy van thong qua property
            Console.WriteLine("Ho va ten: {0}", Sv2.HoVaTen);

            Sv2.InThongTinDiemTB();

            //Su dung phuong thuc cap nhat thong qua property
            Sv2.HoVaTen = "Phat";

            Sv2.InThongTinDiemTB();

            #endregion
        }
    }
}

namespace QuanLyThienNguyen.DTO
{
    public class ThongKe
    {
        private int _MaDVUH;
        private int _MaHTUH;
        private double _TongSoLuongUH;
        private double _SoDuUH;
        public int MaDVUH { get => _MaDVUH; set => _MaDVUH = value; }
        public int MaHTUH { get => _MaHTUH; set => _MaHTUH = value; }
        public double TongSoLuongUH { get => _TongSoLuongUH; set => _TongSoLuongUH = value; }
        public double SoDuUH { get => _SoDuUH; set => _SoDuUH = value; }

        public ThongKe() { }
        public ThongKe(int madvuh, int mahtuh, string tendvuh, string tenhtuh, double tongsoluong, double sodu, string donvitinh)
        {
            this.MaDVUH = madvuh;
            this.MaHTUH = mahtuh;
            this.TongSoLuongUH = tongsoluong;
            this.SoDuUH = sodu;
        }
    }
}

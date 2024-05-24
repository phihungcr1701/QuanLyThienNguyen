namespace QuanLyThienNguyen.DTO
{
    public class ThongKe
    {
        private string _MaDVUH;
        private string _MaHTUH;
        private double _TongSoLuongUH;
        private double _SoDuUH;
        public string MaDVUH { get => _MaDVUH; set => _MaDVUH = value; }
        public string MaHTUH { get => _MaHTUH; set => _MaHTUH = value; }
        public double TongSoLuongUH { get => _TongSoLuongUH; set => _TongSoLuongUH = value; }
        public double SoDuUH { get => _SoDuUH; set => _SoDuUH = value; }

        public ThongKe() { }
        public ThongKe(string madvuh, string mahtuh, double tongsoluong, double sodu)
        {
            this.MaDVUH = madvuh;
            this.MaHTUH = mahtuh;
            this.TongSoLuongUH = tongsoluong;
            this.SoDuUH = sodu;
        }
    }
}

namespace Guitar {
    public class Guitar
    {
        public int SerialNumber { get; set; }
        public double Price { get; set; }
        public string Builder { get; set; }
        public string Model { get; set; }
        public override string ToString()
        {
            return $"SerialNumber={SerialNumber}, Price={Price}, Builder={Builder}, Model={Model}";
        }
        public Guitar(int slno, double price, string builder, string model) {
            SerialNumber = slno;
            Price = price;
            Builder = builder;
            Model = model;
        }
    }
}

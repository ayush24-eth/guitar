namespace Guitar {
    public class ElectricGuitar : Guitar
    {
        public int NumOfPickups { get; set; }

        public ElectricGuitar(int slno, double price, string builder, string model, int numOfPickups)
            : base(slno, price, builder, model)
        {
            NumOfPickups = numOfPickups;
        }
        public override string ToString()
        {
            return base.ToString() + $", NumOfPickups={NumOfPickups}";
        }
    }
}
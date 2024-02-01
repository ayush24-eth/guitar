namespace Guitar {
    public interface IGuitarRepository {
        void AddGuitars(Guitar guitar);
        Guitar GetGuitar(int serialNumber);
        List<Guitar> GetAllGuitars();
    }
}
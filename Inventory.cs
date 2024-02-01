namespace Guitar {
    public class Inventory : IGuitarRepository {
        private List<Guitar> guitars = new List<Guitar>();
        public void AddGuitars(Guitar guitar) {
            guitars.Add(guitar);
            Console.WriteLine("Guitar inserted in the inventory: " + guitar.ToString());
        }
        public Guitar GetGuitar(int serialNumber) {
            Guitar? tempGuitar = null;
            foreach (Guitar g in guitars) {
                if (g.SerialNumber == serialNumber) {
                    tempGuitar = g;
                    break;
                }
            }
            return tempGuitar;
        }
        public List<Guitar> GetAllGuitars() {
            return guitars;
        }
    }
}
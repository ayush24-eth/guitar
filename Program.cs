namespace Guitar {
    class Program
    {
        static void Main(string[] args)
        {
            Inventory guitarRepository = new Inventory();
            int choice = 0;
            do
            {
                Console.WriteLine("1. Add A New Guitar.");
                Console.WriteLine("2. Add Electric Guitars.");
                Console.WriteLine("3. Search A Guitar.");
                Console.WriteLine("4. Display All Available Guitars.");
                Console.WriteLine("0. Exit.");
                Console.Write("Enter your choice: ");
                
                choice  = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        int slno;
                        Console.Write("Enter Sl No: ");
                        slno = Convert.ToInt32(Console.ReadLine());

                        double price;
                        Console.Write("Enter Guitar Price: ");
                        price = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Enter Builder Name: ");
                        string? builder = Console.ReadLine();

                        Console.Write("Enter Model: ");
                        string? model = Console.ReadLine();

                        guitarRepository.AddGuitars(new Guitar(slno, price, builder, model));
                        break;

                    case 2:
                        Console.Write("Enter Sl No: ");
                        slno = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter Guitar Price: ");
                        price = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Enter Builder Name: ");
                        builder = Console.ReadLine();

                        Console.Write("Enter Model: ");
                        model = Console.ReadLine();

                        int pickups;
                        Console.Write("No of pickups ");
                        pickups = Convert.ToInt32(Console.ReadLine());

                        guitarRepository.AddGuitars(new ElectricGuitar(slno, price, builder, model, pickups));
                        break;
                    case 3:
                        int tslno;
                        Console.Write("Enter Sl No: ");
                        tslno = Convert.ToInt32(Console.ReadLine());
                        Guitar foundGuitar = guitarRepository.GetGuitar(tslno);
                        
                        if (foundGuitar != null)
                        {
                            Console.WriteLine("Found: " + foundGuitar.ToString( ));
                        }
                        else
                        {
                            Console.WriteLine("Guitar not found");
                        }
                        break;
                    case 4:
                        List<Guitar> allGuitars = guitarRepository.GetAllGuitars();
                        foreach (Guitar g in allGuitars)
                        {
                            Console.WriteLine(g);
                        }
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }

            } while (choice != 0);
        }
    }
}

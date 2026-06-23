namespace DirectionsReduction;

class Program
{
    static void Main(string[] args)
    {
        string[] directions = ["NORTH", "SOUTH", "SOUTH", "EAST", "WEST", "NORTH", "WEST"];

        int longitude = 0;
        int latitude = 0;

        for (int i = 0; i < directions.Length; i++)
        {
            switch (directions[i])
            {
                case "NORTH":
                    if (latitude != 0)
                    {
                        latitude = 0;
                    }
                    longitude += 1;
                    break;
                case "SOUTH":
                    if (latitude != 0)
                    {
                        latitude = 0;
                    }
                    longitude -= 1;
                    break;
                case "EAST":
                    if (longitude != 0)
                    {
                        longitude = 0;
                    }
                    latitude += 1;
                    break;
                case "WEST":
                    if (longitude != 0)
                    {
                        longitude = 0;
                    }
                    latitude -= 1;
                    break;
            }
        }

        if (longitude != 0 && longitude == 1)
        {
            Console.WriteLine("NORTH");
        }
        if (longitude != 0 && longitude == -1)
        {
            Console.WriteLine("SOUTH");
        }
        if (latitude != 0 && latitude == 1)
        {
            Console.WriteLine("EAST");
        }
        if (latitude != 0 && latitude == -1)
        {
            Console.WriteLine("WEST");
        }
    }
}
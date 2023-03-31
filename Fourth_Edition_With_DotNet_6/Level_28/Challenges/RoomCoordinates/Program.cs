namespace RoomCoordinates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Coordinate[] coordinates = new Coordinate[5];
            coordinates[0] = new Coordinate(1,2);
            coordinates[1] = new Coordinate(2, 3);
            coordinates[2] = new Coordinate(3, 4);
            coordinates[3] = new Coordinate(4, 5);
            coordinates[4] = new Coordinate(5, 1);

            for (int i = 0; i < coordinates.Length; i++)
            {
                Console.WriteLine($"Coordinate[{i}] has Row: {coordinates[i].Row} and Column: {coordinates[i].Column}");
            }

            for (int i = 1; i < coordinates.Length; i++)
            {
                Console.WriteLine($"Is Coordinate[{i-1}] and Coordinate[{i}] adjacent? {coordinates[i - 1].IsAdjacent(coordinates[i])}");
            }
        }
    }
}
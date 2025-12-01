namespace ProgAdvI.MB04_02.Equality.Repetition.Exercise {
    public class Program {
        public static void Main() {
            var vectors = new HashSet<Vector>();

            var v1 = new Vector { X = 3, Y = 4 };
            var v2 = new Vector { X = -1, Y = 2 };

            vectors.Add(v1);
            vectors.Add(v2);

            Console.WriteLine("Initial:");
            Console.WriteLine($"  Contains(v1): {vectors.Contains(v1)}");
            Console.WriteLine($"  Count:        {vectors.Count}");

            // Vektor addieren
            var direction = new Vector { X = 10, Y = -3 };
            v1.Add(direction);

            Console.WriteLine();
            Console.WriteLine("Nach v1.Add(direction):");
            Console.WriteLine($"  v1:           {v1}");
            Console.WriteLine($"  Contains(v1): {vectors.Contains(v1)}");
            Console.WriteLine($"  Count:        {vectors.Count}");

            Console.WriteLine();
            Console.WriteLine("Versuche Remove(v1)...");
            bool removed = vectors.Remove(v1);
            Console.WriteLine($"  Remove Rückgabewert: {removed}");
            Console.WriteLine($"  Count nach Remove:    {vectors.Count}");

            Console.WriteLine();
            Console.WriteLine("Inhalt des HashSet:");
            foreach (var v in vectors) {
                Console.WriteLine($"  {v}");
            }
        }
    }
}
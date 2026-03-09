namespace LeakyApp
{

    public static class Program {
        public static void Main() {
            Console.WriteLine("LeakyApp");

            var service = new TickerService(); // lebt die ganze Programmlaufzeit


            for (int i = 0; i < 500_000; i++) {
                var view = new View(i, service);

                // View wird "geschlossen"
                view.Close();

                if (i % 10_000 == 0) {
                    ForceGc();

                    long mem = GC.GetTotalMemory(true);
                    Console.WriteLine(
                        $"i={i}, Memory={mem / 1024 / 1024} MB"
                    );
                }
            }

            Console.WriteLine("Wenn last alive true bleibt: Leak sichtbar.");
            Console.ReadLine();
        }

        private static void ForceGc() {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            Thread.Sleep(50);
        }
    }

}

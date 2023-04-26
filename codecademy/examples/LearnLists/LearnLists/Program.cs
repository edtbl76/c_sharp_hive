namespace LearnLists
{
    internal static class Program
    {
        private static void Main()
        { 
            var runners = new List<string> { "Jemima Sumgong", "Tiki Gelana", "Constantina Tomescu", "Mizuki Noguchi" };
            var rand = new Random();
      
            Console.WriteLine("In reverse chronological order, the gold medalists are...");
      
            // First loop
            for (var i = 0; i < runners.Count; i++)
            {
                Console.WriteLine($"{i+1}: {runners[i]}");
            }
      
            Console.WriteLine("\nPrinting runner bibs...");
      
            // Second loop
            foreach (var runner in runners) {
                var id = rand.Next(100, 1000);
                Console.WriteLine($"{id} - {runner.ToUpper()}");
            }
        }
    }
}
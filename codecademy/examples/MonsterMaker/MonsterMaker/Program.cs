using System;
using System.Reflection;

namespace MonsterMaker
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            
            RandomMode();
        }

        private static void BuildACreature(string head, string body, string feet)
        {
            SwitchCase(TranslateToNumber(head.ToLower()), 
                TranslateToNumber(body.ToLower()),
                TranslateToNumber(feet.ToLower()));
        }
        
        private static void RandomMode()
        {
            var randomNumber = new Random();
            var head = randomNumber.Next(1, 4);
            var body = randomNumber.Next(1, 4);
            var feet = randomNumber.Next(1, 4);
            
            SwitchCase(head, body, feet);
        }

        private static void SwitchCase(int head, int body, int feet)
        {
            switch (head)
            {
                case 1:
                    GhostHead();
                    break;
                case 2:
                    MonsterHead();
                    break;
                case 3:
                    BugHead();
                    break;
            }

            switch (body)
            {
                case 1:
                    GhostBody();
                    break;
                case 2:
                    MonsterBody();
                    break;
                case 3:
                    BugBody();
                    break;
            }


            switch (feet)
            {
                case 1:
                    GhostFeet();
                    break;
                case 2: 
                    MonsterFeet();
                    break;
                case 3:
                    BugFeet();
                    break;
            }
        }

        private static int TranslateToNumber(string creature)
        {
            // This is a switch expression. Pretty Fucking Cool
            return creature switch
            {
                "ghost" => 1,
                "monster" => 2,
                "bug" => 3,
                _ => 1
            };
        }
        private static void GhostHead()
        {
            Console.WriteLine("     ..-..");
            Console.WriteLine("    ( o o )");
            Console.WriteLine("    |  O  |");
        }

        private static void GhostBody()
        {
            Console.WriteLine("    |     |");
            Console.WriteLine("    |     |");
            Console.WriteLine("    |     |");
        }

        private static void GhostFeet()
        {
            Console.WriteLine("    |     |");
            Console.WriteLine("    |     |");
            Console.WriteLine("    '~~~~~'");
        }

        private static void BugHead()
        {
            Console.WriteLine("     /   \\");
            Console.WriteLine("     \\. ./");
            Console.WriteLine("    (o + o)");
        }

        private static void BugBody()
        {
            Console.WriteLine("  --|  |  |--");
            Console.WriteLine("  --|  |  |--");
            Console.WriteLine("  --|  |  |--");
        }

        private static void BugFeet()
        {
            Console.WriteLine("     v   v");
            Console.WriteLine("     *****");
        }

        private static void MonsterHead()
        {
            Console.WriteLine("     _____");
            Console.WriteLine(" .-,;='';_),-.");
            Console.WriteLine("  \\_\\(),()/_/");
            Console.WriteLine("　  (,___,)");
        }

        private static void MonsterBody()
        {
            Console.WriteLine("   ,-/`~`\\-,___");
            Console.WriteLine("  / /).:.('--._)");
            Console.WriteLine(" {_[ (_,_)");
        }

        private static void MonsterFeet()
        {
            Console.WriteLine("    |  Y  |");
            Console.WriteLine("   /   |   \\");
            Console.WriteLine("   \"\"\"\" \"\"\"\"");
        }
    }
}
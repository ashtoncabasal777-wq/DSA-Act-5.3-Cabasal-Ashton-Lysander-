class Program
    {
        static void Main(string[] args)
        {
             //DSA Activity 5.3 - [Cabasal, Ashton Lysander]
            

            Console.WriteLine("WELCOME To My SIMPLE GAME program.\n");

            Random rand = new Random();
            Stack<int> playerA = new Stack<int>();
            Stack<int> playerB = new Stack<int>();

            // Give each player 2 random numbers (0-9)
            for (int i = 0; i < 2; i++)
            {
                playerA.Push(rand.Next(0, 10));
                playerB.Push(rand.Next(0, 10));
            }

            // Show starting lists (Reverse() so they print in original order)
            Console.WriteLine("Player A: " + string.Join(" ", playerA.Reverse()));
            Console.WriteLine("Player B: " + string.Join(" ", playerB.Reverse()));

            int match = 1;

            // Game ends when at least one stack is empty
            while (playerA.Count > 0 && playerB.Count > 0)
            {
                int a = playerA.Peek();   // number at the end of A's list
                int b = playerB.Peek();   // number at the end of B's list

                Console.WriteLine("\nMatch " + match + ":");
                Console.WriteLine(a + " vs " + b);

                if (a > b)
                {
                    playerB.Pop();        // B removes the number
                    Console.WriteLine("Player A Win");
                }
                else if (a < b)
                {
                    playerA.Pop();        // A removes the number
                    Console.WriteLine("Player B Win");
                }
                else
                {
                    playerA.Pop();        // both remove the number
                    playerB.Pop();
                    Console.WriteLine("Rematch");
                }

                match++;
            }

            // Final result
            Console.WriteLine("\nFinal Result:");
            Console.WriteLine("Player A: " + string.Join(" ", playerA.Reverse()));
            Console.WriteLine("Player B: " + string.Join(" ", playerB.Reverse()));

            if (playerA.Count > 0)
                Console.WriteLine("\nPlayer A Win");
            else if (playerB.Count > 0)
                Console.WriteLine("\nPlayer B Win");
            else
                Console.WriteLine("\nIt's a Draw");

            Console.WriteLine("\nThank you for using the program");
            Console.ReadKey();
        }
    }

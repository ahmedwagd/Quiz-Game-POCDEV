namespace Quiz_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int limitation = 3;
            int rightAnswersCounter = 0;
            string[] questions = new string[3]
            {
                "1. What is capital of Egypt?",
                "2. What is the largest animal?",
                "3. What is my name?"
            };
            string[] answers = new string[3]
            {
                "cairo",
                "whale",
                "ahmed"
            };
            Console.WriteLine("\t\t\t\tWellcome to the game\n\n\n\n\n\n");
            Console.WriteLine("Answer the following questions");
            for (int i = 0; i < limitation; i++)
            {
                Console.WriteLine(questions[i]);
                string userAnswer = Console.ReadLine();
                try
                {
                    bool result = IsAnswerIsCorrect(userAnswer, answers[i]);
                    if (result)
                    {
                        Console.WriteLine("Congrats {0}\t✓ Right", answers[i]);
                        rightAnswersCounter++;
                    }
                    else
                    {
                        Console.WriteLine("Sorry the answer is {0}\tX Wrong", answers[i]);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);

                }
            }
            Console.WriteLine("Your score is {0}/{1}",rightAnswersCounter,limitation);
            Console.WriteLine("Qize completed, Thank you for effort");

        }

        private static bool IsAnswerIsCorrect(string input, string answer)
        {
            if(string.IsNullOrEmpty(input))
            {
                throw new Exception("Answer can not be empty");
            }
            if (input.ToLower() == answer.ToLower())
            {
                return true;

            }
            
            return false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Depression
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, this program will help you complete the PHQ-9 Depresion Questionnaire.\n\n"
                + "Use the following responses to answer ALL 9 questions:\n"
                + "0 = Not at all, 1 = Several days, 2 = More than half the days, 3 = Nearly every day.\n\n"
                + "Over the past 2 weeks, how often have you been bothered by the following problems:\n");
            int Item1 = GetValue("Little interest or pleasure in doing things? ");
            int Item2 = GetValue("Feeling down, depressed, or hopeless? ");
            int Item3 = GetValue("Trouble falling or staying asleep, or sleeping too much? ");
            int Item4 = GetValue("Feeling tired or having little energy? ");
            int Item5 = GetValue("Poor appetite or overeating? ");
            int Item6 = GetValue("Feeling bad about yourself — or that you are a failure or\n"
                + "have let yourself or your family down? ");
            int Item7 = GetValue("Trouble concentrating on things, such as reading the\n"
                + "newspaper or watching television? ");
            int Item8 = GetValue("Moving or speaking so slowly that other people could have\n"
                + "noticed? Or the opposite — being so fidgety or restless\n"
                + "that you have been moving around a lot more than usual? ");
            int Item9 = GetValue("Thoughts that you would be better off dead or of hurting\n"
                + "yourself in some way? ");

            int totalScore = (Item1 + Item2 + Item3 + Item4 + Item5 + Item6 + Item7 + Item8 + Item9);
            Console.ForegroundColor = System.ConsoleColor.Red;

            switch (totalScore)
            {

                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                    {
                        Console.WriteLine("The PHQ-9 severity score was " + totalScore + ".");
                        Console.WriteLine("\nNone to minimal depression. No further action recommended.");
                        break;
                    }
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                    {
                        Console.WriteLine("The PHQ-9 severity score was " + totalScore + ".");
                        Console.WriteLine("\nMild depression. Watchful waiting; repeat PHQ-9 at follow-up is recommended.");
                        break;
                    }
                case 10:
                case 11:
                case 12:
                case 13:
                case 14:
                    {
                        Console.WriteLine("The PHQ-9 severity score was " + totalScore + ".");
                        Console.WriteLine("\nModerate depression. Treatment plan, considering counseling, follow-up and/or\n"
                            + "pharmacotherapy is recommended.");
                        break;
                    }
                case 15:
                case 16:
                case 17:
                case 18:
                case 19:
                    {
                        Console.WriteLine("The PHQ-9 severity score was " + totalScore + ".");
                        Console.WriteLine("\nModerately severe depression. Active treatment with pharmacotherapy and/or\n"
                            + "psychotherapy is recommended.");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("The PHQ-9 severity score was " + totalScore + ".");
                        Console.WriteLine("\nSevere depression. Immediate initiation of pharmacotherapy and, if severe\n"
                            + "impairment or poor responser to therapy, expeditied referral to a mental health specialist\n"
                            + " for psychotherapy and/or collaborative management.");
                        break;

                    }
            }
            DateTime now = DateTime.Now;
            Console.WriteLine(now);
            Console.ReadLine();

        }

        private static int GetValue(string label)
        {
            int value;
            while (true)
            {
                Console.Write(label);
                string input = Console.ReadLine();
                if ((int.TryParse(input, out value)) && value >= 0 && value <= 3)
                {
                    return value;
                }
                else
                {
                    Console.ForegroundColor = System.ConsoleColor.Red;
                    Console.WriteLine("Input error, try again!)");
                    Console.ForegroundColor = System.ConsoleColor.White;
                }
            }
        }
    }
}

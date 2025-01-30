// Written by Kelvin Maher
// 1/27/25

namespace QuizCalculatorEdabit
{
    public class Program
    {
        public static void Main(string[] args)
        {
            QuizCalculatorClass aQuizCalculator = new QuizCalculatorClass();

            aQuizCalculator.AddQuiz(80.00);
            aQuizCalculator.AddQuiz(80.00);
            aQuizCalculator.AddQuiz(80.00);
            aQuizCalculator.AddQuiz(80.00);

            Console.WriteLine(aQuizCalculator.ToString());

        }
    }
}

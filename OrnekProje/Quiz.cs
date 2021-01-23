using System;

namespace OrnekProje
{
    class Quiz
    {
        string quizIndex;
        string[] choices;
        string answer;
        

        static void Main(string[] args)
        {
            Quiz quiz1 = new Quiz();
            quiz1.quizIndex = "En iyi programlama dili hangisidir?";
            quiz1.choices = new string[] { "Python", "C#", "C++", "Java" };
            quiz1.answer = "Python";

            //Console.WriteLine(quiz1.quizIndex + "\n" + quiz1.choices[0]);

            foreach (var choice in quiz1.choices)
            {
                Console.WriteLine(choice);
            }
        }
    }
}
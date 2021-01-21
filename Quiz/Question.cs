using System;

namespace Quiz
{
    class Question
    {
        string questionIndex;
        string[] choices;
        string answer;
        string myAnswer;


        static void Main(string[] args)
        {
            Question question1 = new Question();
            question1.questionIndex = "En iyi programlama dili hangisidir?";
            question1.choices = new string[4] { "python", "java", "c#", "javascript" };
            question1.answer = "python";
            Console.WriteLine(question1.questionIndex+ "\n");
            
            foreach (var choice in question1.choices)
            {
                Console.WriteLine(choice + "\n");
            }

            Console.WriteLine("Cevap: ");
            question1.myAnswer = Console.ReadLine();


            if (question1.answer == question1.myAnswer)
            {
                Console.WriteLine("Cevabınız doğru.");
            }
            else
            {
                Console.WriteLine("Cevabınız yanlış.");
            }
        }
    }
}

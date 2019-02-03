using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Lesson_7_Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lesson.SortNumbersExample();
            //Lesson.SortVectorsExample();
            //Lesson.SortVectorsGenericExample();
            //Lesson.SortWithDelegatesExample();
            //Lesson.SingleAndMulticastExample();
            //Lesson.SortWithAnonymousFunction();
            //Lesson.SortWithLambdaFunction();
            //Lesson.CarDelegateExample();
            //Lesson.ExamExample();
            //Practice.L7P1_Calculator();
            //Lesson.SortWithDelegatesExample();
            //Lesson.CarDelegateExample();
            
            Func<string, string> stringMutation = (a) => a.ToUpper();
            //stringMutation += b=>b.Replace(' ','_');

            Practice.L7P2_StringFormater(stringMutation);

            Console.ReadLine();
        }
    }
}

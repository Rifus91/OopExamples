using System;
using OopExamples.ObjectExamples;

namespace OopExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            //Encapsulation.PersonProblemExample.Run();
            //Encapsulation.PersonSolutionExampl.Run();

            //Console.WriteLine(StringUtils.FirstLetterToUpper("привет"));
            //ShapeClass.TestShapeExample.Area();
            //ShapeClass.TestShapeExample.Draw();

            ObjectExamples.AutoProp.Point point = new AutoProp.Point();
            point.SetX(5);
            int x = point.GetX();

        }
    }
}

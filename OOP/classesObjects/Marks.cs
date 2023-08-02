using System;

namespace classesObjects
{
    internal class Marks: Student
    {
        float objectiveMarks;
        float subjectiveMarks;

        public void EnterDetails()
        {
            base.EnterDetails();
            Console.WriteLine("Enter Objective Marks: ");
            objectiveMarks = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Subjective Marks: ");
            subjectiveMarks = float.Parse(Console.ReadLine());
        }

        public new void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine(objectiveMarks);
            Console.WriteLine(subjectiveMarks);
        }
    }
}
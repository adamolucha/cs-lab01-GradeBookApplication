using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GradeBook.Enums;
namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name, bool isWeight) : base(name, isWeight)

        {
            Type = GradeBookType.Ranked;
        }

        public override void CalculateStatistics()
        {
            if (Students.Count < 5)
            {
                Console.WriteLine("Ranked grading requires at least 5 students.");
            }
            else
                base.CalculateStatistics();
        }

        public override void CalculateStudentStatistics(string name)
        {
            if (Students.Count < 5)
            {
                Console.WriteLine("Ranked grading requires at least 5 students.");
            }
            else
                 base.CalculateStudentStatistics(name);
        }

        public override char GetLetterGrade(double averageGrade)
        {
            if ( Students.Count < 5)
            {
                throw new InvalidOperationException("There needs to be at least 5 students.");
            }
            else
            {
                if (averageGrade >= 80)
                {
                    return 'A';
                }
                else if (averageGrade >= 60)
                {
                    return 'B';
                }
                else if (averageGrade >= 40)
                {
                    return 'C';
                }
                else if (averageGrade >= 20)
                {
                    return 'D';
                }
                else
                {
                    return 'F';
                }
                
            }

        }
    }
}

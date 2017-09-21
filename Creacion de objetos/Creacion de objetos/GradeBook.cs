using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creacion_de_objetos
{
    class GradeBook
    {
        public GradeBook()
        {
            grades = new List<float>();
        }

        public GradeStatistics ComputeStatistics()
        {
            GradeStatistics stats = new GradeStatistics();
            float sum = 0;
            foreach(float grade in grades)
            {
                if(grade > stats.HighestGrade) //Tambien se podria lanzar de la siguiente manera Math.Max(grade, stats.HighestGrade); mostraria el mas alto de las 2 variables
                {
                    stats.HighestGrade = grade;
                }
                stats.lowerstGrade = Math.Min(grade, stats.lowerstGrade);
                sum += grade;
            }
            stats.AverageGrade = sum / grades.Count;
            return stats;
        }

        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }
        List<float> grades;
    }
}

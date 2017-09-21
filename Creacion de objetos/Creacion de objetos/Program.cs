using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creacion_de_objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Speech.Synthesis.SpeechSynthesizer SYNTH = new System.Speech.Synthesis.SpeechSynthesizer(); //permite la lectura del comentario por voz
            //SYNTH.Speak("Hello! This is the grade book program Rocky");
                
            GradeBook book = new GradeBook();
            book.AddGrade(91);
            book.AddGrade(89.5f);

            GradeBook book2 = book;
            book2.AddGrade(75);
            GradeStatistics stats = book.ComputeStatistics();
            Console.WriteLine("Promedio Medio " + stats.AverageGrade);
            Console.WriteLine("Grade Mas Alto " + stats.HighestGrade);
            Console.WriteLine("Grade mas pequeño " + stats.lowerstGrade);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creacion_de_objetos
{
    class GradeStatistics
    {
        public GradeStatistics()
        {
            HighestGrade = 0;
            lowerstGrade = float.MaxValue;
        }
        public float HighestGrade;
        public float lowerstGrade;
        public float AverageGrade;

    }
}

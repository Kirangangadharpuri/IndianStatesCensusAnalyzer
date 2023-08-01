using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStatesCensusAnalyzer_Problem
{
    public class StateCensusException:Exception
    {
        public enum StateCensus_ExceptionType
        {
            FILE_NOTFOUND,
            CSVFILE_NOTFOUND,
            DELIMETER_INCORRECT
        }
        public StateCensus_ExceptionType Type;
        public StateCensusException(StateCensus_ExceptionType type, string message) :base(message)
        {
            this.Type = type;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStatesCensusAnalyzer_Problem
{
    public class Program
    {
        public static string path = @"C:\Users\HP\Desktop\RFP-288\CesusAnalyzer\IndianStatesCensusAnalyzer\IndianStatesCensusAnalyzer_Problem\IndianStatesCensusAnalyzer_Problem\Files\Files\StateCensusData.csv";
        public static string path_two = @"C:\Users\HP\Desktop\RFP-288\CesusAnalyzer\IndianStatesCensusAnalyzer\IndianStatesCensusAnalyzer_Problem\IndianStatesCensusAnalyzer_Problem\Files\Files\StateCodeData.csv";
        static void Main(string[] args)
        {
            //StateCensusAnalyser stateCensusAnalyser = new StateCensusAnalyser();
            //stateCensusAnalyser.ReadStateCensusData(path);
            CSVStates cSVStates = new CSVStates();
            cSVStates.ReadStatesCode(path_two);
        }
    }
}

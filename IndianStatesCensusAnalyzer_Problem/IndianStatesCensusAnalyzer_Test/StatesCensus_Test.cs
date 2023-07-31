using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndianStatesCensusAnalyzer_Problem;
using IndianStatesCensusAnalyzer_Test;

namespace IndianStatesCensusAnalyzer_Test
{
    public class StatesCensus_Test
    {
        public static string stateCensusFilePath = @"C:\Users\HP\Desktop\RFP-288\CesusAnalyzer\IndianStatesCensusAnalyzer\IndianStatesCensusAnalyzer_Problem\IndianStatesCensusAnalyzer_Problem\Files\Files\StateCensusData.csv";
        [Test]
        public void MatchCounts()
        {
            StateCensusAnalyser stateCensusAnalyser = new StateCensusAnalyser();
            CSVCensus cSVCensus= new CSVCensus();
            Assert.AreEqual(cSVCensus.ReadStateCensusData(stateCensusFilePath), stateCensusAnalyser.ReadStateCensusData(stateCensusFilePath));
        }
    }
}

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
        StateCensusAnalyser stateCensusAnalyse = new StateCensusAnalyser();
        public static string stateCensusFilePaths = @"C:\Users\HP\Desktop\RFP-288\CesusAnalyzer\IndianStatesCensusAnalyzer\IndianStatesCensusAnalyzer_Problem\IndianStatesCensusAnalyzer_Problem\Files\Files\StateCensusDat.csv";
        public static string stateCensusFilePath = @"C:\Users\HP\Desktop\RFP-288\CesusAnalyzer\IndianStatesCensusAnalyzer\IndianStatesCensusAnalyzer_Problem\IndianStatesCensusAnalyzer_Problem\Files\Files\StateCensusData.csv";
        [Test]
        public void MatchCounts()
        {
            StateCensusAnalyser stateCensusAnalyser = new StateCensusAnalyser();
            CSVCensus cSVCensus= new CSVCensus();
            Assert.AreEqual(cSVCensus.ReadStateCensusData(stateCensusFilePath), stateCensusAnalyser.ReadStateCensusData(stateCensusFilePath));
        }
        [Test]
        public void GivenCSVFile_But_IcorrectPath()
        {
            try
            {
                int record = stateCensusAnalyse.ReadStateCensusData(stateCensusFilePaths);
            }
            catch(StateCensusException ex)
            {
                Assert.AreEqual(ex.Message, "File not found");
            }
        }              
    }
}

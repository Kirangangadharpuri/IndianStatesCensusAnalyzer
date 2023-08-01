using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndianStatesCensusAnalyzer_Problem;
using IndianStatesCensusAnalyzer_Test;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.Serialization;

namespace IndianStatesCensusAnalyzer_Test
{
    public class StatesCensus_Test
    {
        StateCensusAnalyser stateCensusAnalyser = new StateCensusAnalyser();
        CSVCensus cSVCensus = new CSVCensus();
        CSVStates cSVtates = new CSVStates();
        CSVStatesAnalyser cSVStatesAnalyser = new CSVStatesAnalyser();
        public static string stateCensusFilePaths = @"C:\Users\HP\Desktop\RFP-288\CesusAnalyzer\IndianStatesCensusAnalyzer\IndianStatesCensusAnalyzer_Problem\IndianStatesCensusAnalyzer_Problem\Files\Files\StateCensusDat.csv";
        public static string notCSVPath = @"C:\Users\HP\Desktop\RFP-288\CesusAnalyzer\IndianStatesCensusAnalyzer\IndianStatesCensusAnalyzer_Problem\IndianStatesCensusAnalyzer_Problem\Files\Files\StateCensusData.txt";
        public static string delimeterPath = @"C:\Users\HP\Desktop\RFP-288\CesusAnalyzer\IndianStatesCensusAnalyzer\IndianStatesCensusAnalyzer_Problem\IndianStatesCensusAnalyzer_Problem\Files\Files\StateCensusDataDelimeter.csv";
        public static string stateCensusFilePath = @"C:\Users\HP\Desktop\RFP-288\CesusAnalyzer\IndianStatesCensusAnalyzer\IndianStatesCensusAnalyzer_Problem\IndianStatesCensusAnalyzer_Problem\Files\Files\StateCensusData.csv";
        public static string stateCodePath = @"C:\Users\HP\Desktop\RFP-288\CesusAnalyzer\IndianStatesCensusAnalyzer\IndianStatesCensusAnalyzer_Problem\IndianStatesCensusAnalyzer_Problem\Files\Files\StateCodeData.csv";
        public static string stateCodeNotCSVFile = @"C:\Users\HP\Desktop\RFP-288\CesusAnalyzer\IndianStatesCensusAnalyzer\IndianStatesCensusAnalyzer_Problem\IndianStatesCensusAnalyzer_Problem\Files\Files\StateCode.csv";
        public static string stateCodeNotCSVFiles = @"C:\Users\HP\Desktop\RFP-288\CesusAnalyzer\IndianStatesCensusAnalyzer\IndianStatesCensusAnalyzer_Problem\IndianStatesCensusAnalyzer_Problem\Files\Files\StateCode.txt";
        public static string stateCodeNotDelimeter = @"C:\Users\HP\Desktop\RFP-288\CesusAnalyzer\IndianStatesCensusAnalyzer\IndianStatesCensusAnalyzer_Problem\IndianStatesCensusAnalyzer_Problem\Files\Files\StateCodeData.csv";

        //TC1.1
        [Test]
        public void MatchCounts()
        {
            Assert.AreEqual(cSVCensus.ReadStateCensusData(stateCensusFilePath), stateCensusAnalyser.ReadStateCensusData(stateCensusFilePath));
        }
        //TC1.2
        [Test]
        public void GivenCSVFile_But_IcorrectPath()
        {
            try
            {
                int record = stateCensusAnalyser.ReadStateCensusData(stateCensusFilePaths);
            }
            catch (StateCensusException ex)
            {
                Assert.AreEqual(ex.Message, "File not found");
            }
        }
        //TC1.3
        [Test]
        public void GIvenCSVFileButIncorrectFileType()
        {
            try
            {
                int record = cSVCensus.ReadStateCensusData(notCSVPath);
            }
            catch (StateCensusException ex)
            {
                Assert.AreEqual(ex.Message, "CSV file not found");
            }
        }
        //TC1.4
        [Test]
        public void GivenCSVFileWithIncorrectDelimeter()
        {
            try
            {
                int record = stateCensusAnalyser.ReadStateCensusData(delimeterPath);
            }
            catch (StateCensusException ex)
            {
                Assert.AreEqual(ex.Message, "Delimeter is incorrect");
            }
        }
        [Test]
        //TC2.1
        public void StateCOdeMatchCounts()
        {

            Assert.AreEqual(cSVtates.ReadStatesCode(stateCodePath), cSVStatesAnalyser.ReadStatesCode(stateCodePath));
        }
       
        [Test]
        //TC2.2
        public void GivenCSVFile_IcorrectPath()
        {
            try
            {
                int record = cSVtates.ReadStatesCode(stateCodePath);
            }
            catch (StateCensusException ex)
            {
                Assert.AreEqual(ex.Message, "File not found");
            }
        }
        [Test]
        //TC2.3
        public void StateCode_NotCSVFile()
        {
            try
            {
                int record = cSVCensus.ReadStateCensusData(stateCodeNotCSVFiles);
            }
            catch(StateCensusException ex)
            {
                Assert.AreEqual(ex.Message, "CSV file not found");
            }
        }
        [Test]
        public void StateCodeIncorrectDelimeter()
        {
            try
            {
                int record = cSVtates.ReadStatesCode(stateCodeNotDelimeter);
            }
            catch (StateCensusException ex)
            {
                Assert.AreEqual(ex.Message, "Delimeter is incorrect");
            }
        }
    }
}

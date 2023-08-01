using CsvHelper;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStatesCensusAnalyzer_Problem
{
    public class CSVStates
    {
        public int ReadStatesCode(string path_two)
        {
            //if (!File.Exists(path_two))
            //{ 
            //    throw new StateCensusException(StateCensusException.StateCensus_ExceptionType.FILE_NOTFOUND,"File note found");
            //}
            //if(!path_two.StartsWith(".csv"))
            //{
            //    throw new StateCensusException(StateCensusException.StateCensus_ExceptionType.CSVFILE_NOTFOUND, "CSV file not found");
            //}
            var read = File.ReadAllLines(path_two);
            string header = read[0];
            if (path_two.Contains("/"))
            {
                throw new StateCensusException(StateCensusException.StateCensus_ExceptionType.DELIMETER_INCORRECT, "Delimeter is incorrect");
            }
            using (var reader = new StreamReader(path_two))
            {
                using (var csv = new CsvReader(reader, CultureInfo.InstalledUICulture))
                {                  
                    var record = csv.GetRecords<StateCodeData>().ToList();
                    foreach (var data in record)
                    {
                        Console.WriteLine(data.SrNo + " " + data.StateName + " " + data.TIN + " " + data.StateCode);
                    }
                }
            }
            return 0;
        }
    }
}

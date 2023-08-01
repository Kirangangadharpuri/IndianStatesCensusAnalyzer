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
            if (!File.Exists(path_two))
            { 
                throw new StateCensusException(StateCensusException.StateCensus_ExceptionType.FILE_NOTFOUND,"File note found");
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

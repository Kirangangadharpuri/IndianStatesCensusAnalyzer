using CsvHelper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStatesCensusAnalyzer_Problem
{
    public class CSVCensus
    {
        public int ReadStateCensusData(string path)
        {
            if (!path.StartsWith(".csv"))
                throw new StateCensusException(StateCensusException.StateCensus_ExceptionType.CSVFILE_NOTFOUND,"CSV file not found");
            using (var reader = new StreamReader(path))
            {
                using (var csv = new CsvReader(reader, CultureInfo.InstalledUICulture))
                {
                    var record = csv.GetRecords<StateCensusData>().ToList();
                    foreach (var data in record)
                    {
                        Console.WriteLine(data.State + " " + data.DensityPerSqKm + " " + data.Population + " " + data.AreaInSqKm);
                    }
                   
                }
            }
            return 0;
        }
    }
}

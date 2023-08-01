using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStatesCensusAnalyzer_Problem
{
    public class StateCensusAnalyser
    {
        public int ReadStateCensusData(string path)
        {
            if (!File.Exists(path))
            {
                throw new StateCensusException(StateCensusException.StateCensus_ExceptionType.FILE_NOTFOUND, "File not found");
            }
            var read = File.ReadAllLines(path);
            string header = read[0];
            if (header.Contains("/"))
                throw new StateCensusException(StateCensusException.StateCensus_ExceptionType.DELIMETER_INCORRECT, "Delimeter is incorrect");
            using (var reader = new StreamReader(path))
            {
                using (var csv = new CsvReader(reader,CultureInfo.InstalledUICulture))
                {
                    var record = csv.GetRecords<StateCensusData>().ToList();
                    foreach(var data in record)
                    {
                        Console.WriteLine(data.State + " " + data.DensityPerSqKm + " " + data.Population + " " + data.AreaInSqKm) ;
                    }
                }
            }
            return 0;
        }
    }
}

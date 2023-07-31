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
    public class CSVCensus
    {
        public int ReadStateCensusData(string path)
        {
            using (var reader = new StreamReader(path))
            {
                using (var csv = new CsvReader(reader, CultureInfo.InstalledUICulture))
                {
                    var record = csv.GetRecords<StateCensusData>().ToList();
                    foreach (var data in record)
                    {
                        Console.WriteLine(data.State + " " + data.DensityPerSqKm + " " + data.Population + " " + data.AreaInSqKm);
                    }
                    return record.Count() - 1;
                }
            }
        }
    }
}

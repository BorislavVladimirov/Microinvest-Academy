using MicroinvestFilesAndStreams.Interfaces;
using MicroinvestFilesAndStreams.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MicroinvestFilesAndStreams
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<IDriver> drivers = new List<IDriver>();
            List<ITrack> tracks = new List<ITrack>();

            try
            {
                for (int i = 15; i < 75; i+=7)
                {
                    IDriver driver = new Driver("Ivan", i);
                    ITrack track = new RaceTrack(i * 1.23, i - 4, "tarmac", i % 2 == 0 ? true : false);

                    drivers.Add(driver);
                    tracks.Add(track);
                }

                IDriver bmwDriver = drivers.FirstOrDefault(d => d.Age > 25 && d.Age < 45);
                IEnumerable<ITrack> openTracks = tracks.Where(t => t.IsOpenAllYear == true);

                ITrack currentTrack = openTracks.FirstOrDefault(t => t.CornersCount > 25);

                ICar bmw = new BMW(2005, "M5", 507, bmwDriver, currentTrack);

                string resultReport = GetInfo(currentTrack, bmw);

                string path = @"D:\RacetrackReport.txt";

                if (!File.Exists(path))
                {
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.WriteLine(resultReport);
                    }
                }
                else
                {
                    using (StreamWriter sw = File.AppendText(path))
                    {
                        sw.WriteLine(resultReport);
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static string GetInfo(ITrack currentTrack, ICar bmw)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(DateTime.Now.ToString());

            sb.AppendLine("Car info:");
            sb.AppendLine($"Molel: {bmw.Model}");
            sb.AppendLine($"Production year: {bmw.YearOfProduction}");
            sb.AppendLine($"Horsepower: {bmw.HorsePower}");
            sb.AppendLine();

            sb.AppendLine("Racetrack info:");
            sb.AppendLine($"Corners count: {currentTrack.CornersCount}");
            sb.AppendLine($"Track length: {currentTrack.Legnth}");
            sb.AppendLine($"Surface type: {currentTrack.SurfaceType}");
            sb.AppendLine($"Is open all seasons: {currentTrack.IsOpenAllYear}");
            sb.AppendLine();

            return sb.ToString();
        }
    }
}

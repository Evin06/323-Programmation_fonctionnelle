using Aspose.Gis;
using Aspose.Gis.Geometries;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Rando
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Trackpoint> trackpoints = new List<Trackpoint>();

            var layer = Drivers.Gpx.OpenLayer(@"../../../../loechegemmi.gpx");

            foreach (var feature in layer)
            {
                if (feature.Geometry.GeometryType == GeometryType.MultiLineString)
                {
                    var lines = (MultiLineString)feature.Geometry;
                    for (int i = 0; i < lines.Count; i++)
                    {
                        var segment = (LineString)lines[i];
                        for (int j = 0; j < segment.Count; j++)
                        {
                            var point = segment[j];
                            double elevation = point.HasZ ? point.Z : 0.0;
                            Trackpoint trackpoint = new Trackpoint
                            {
                                Latitude = point.Y,
                                Longitude = point.X,
                                Elevation = elevation
                            };
                            trackpoints.Add(trackpoint);
                        }
                    }
                }
            }

            //Réduire la définition: on ne garde qu'un point sur cinq
            var reducedTrackpoints = trackpoints
                .Where((trackpoint, index) => index % 5 == 0)
                .ToList();

            foreach (var trackpoint in reducedTrackpoints)
            {
                Console.WriteLine($"Latitude: {trackpoint.Latitude}, Longitude: {trackpoint.Longitude}, Elevation: {trackpoint.Elevation}");
            }
        }

        class Trackpoint
        {
            public double Latitude { get; set; }
            public double Longitude { get; set; }
            public double Elevation { get; set; }
        }
    }
}

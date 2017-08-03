using System;
namespace GeofenceSample.Models
{
	public class Place
	{
		public Place()
		{
		}

		public string Name { get; set; }
		public double Latitude { get; set; }
		public double Longitude { get; set; }
		public double Radius { get; set; }
	}
}

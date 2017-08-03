using System;
using System.Diagnostics;
using Geofence.Plugin;
using Geofence.Plugin.Abstractions;
using GeofenceSample.Models;

namespace GeofenceSample.Helpers
{
	//Class to handle geofence events such as start/stop monitoring, region state changes and errors.
	public class CrossGeofenceListener : IGeofenceListener
	{
        
		public void OnMonitoringStarted(string region)
		{
			Debug.WriteLine(string.Format("{0} - {1}: {2}", CrossGeofence.Id, "Monitoring in region", region));
		}

		public void OnMonitoringStopped()
		{
			Debug.WriteLine(string.Format("{0} - {1}", CrossGeofence.Id, "Monitoring stopped for all regions"));
			App.Events.Clear();
			Settings.ClearAllEvents();
		}

		public void OnMonitoringStopped(string identifier)
		{
			Debug.WriteLine(string.Format("{0} - {1}: {2}", CrossGeofence.Id, "Monitoring stopped in region", identifier));
			foreach (Event e in App.Events)
			{
				if (e.Description.Contains(identifier))
				{
					App.Events.Remove(e);
				}
			}
		}

		public void OnError(string error)
		{
			Debug.WriteLine(string.Format("{0} - {1}: {2}", CrossGeofence.Id, "Error", error));
		}


		public void OnRegionStateChanged(GeofenceResult result)
		{
			var e = new Event()
			{
				Date = (result.Transition != GeofenceTransition.Exited) ? result.LastEnterTime.ToString() : result.LastExitTime.ToString(),
				Id = App.Events.Count + 1,
				Description = result.ToString()
			};
			App.Events.Add(e);
			Settings.SaveResult(e);
			Debug.WriteLine(string.Format("{0} - {1}", CrossGeofence.Id, result.ToString()));
		}

        public void OnAppStarted()
        {
            
        }

        public void OnLocationChanged(GeofenceLocation location)
        {
            
        }
    }
}

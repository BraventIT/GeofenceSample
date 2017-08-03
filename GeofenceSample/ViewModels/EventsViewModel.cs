using System;
using System.Collections.ObjectModel;
using GeofenceSample.Models;
using PropertyChanged;

namespace GeofenceSample.ViewModels
{
	[ImplementPropertyChanged]
	public class EventsViewModel
	{
		public EventsViewModel()
		{

		}

		public ObservableCollection<Event> Data { get { return App.Events; } }

	}
}

using System;
using System.Collections.Generic;
using GeofenceSample.Helpers;
using GeofenceSample.Models;
using Xamarin.Forms;

namespace GeofenceSample.Views
{
	public partial class EventViewCell : ViewCell
	{
		public EventViewCell()
		{
			InitializeComponent();
		}

		void OnDelete(object sender, EventArgs args)
		{
			var e = (Event)this.BindingContext;

			App.Events.Remove(e);
			Settings.RemoveEvent(e);
		}
	}
}

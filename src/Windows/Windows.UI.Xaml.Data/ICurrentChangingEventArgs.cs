using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Data
{
	[ExclusiveTo(typeof(CurrentChangingEventArgs)), Guid(4186512937u, 20940, 18397, 165, 185, 53, 220, 73, 20, 175, 105), Version(100794368u), WebHostHidden]
	internal interface ICurrentChangingEventArgs
	{
		bool Cancel
		{
			get;
			set;
		}
		bool IsCancelable
		{
			get;
		}
	}
}

using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(ContextMenuEventArgs)), Guid(528347747u, 49483, 17704, 182, 240, 99, 121, 153, 216, 60, 198), Version(100794368u), WebHostHidden]
	internal interface IContextMenuEventArgs
	{
		double CursorLeft
		{
			get;
		}
		double CursorTop
		{
			get;
		}
		bool Handled
		{
			get;
			set;
		}
	}
}

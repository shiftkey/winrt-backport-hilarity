using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(Viewbox)), Guid(1557260077u, 59603, 18533, 143, 8, 182, 178, 214, 137, 173, 241), Version(100794368u), WebHostHidden]
	internal interface IViewboxStatics
	{
		DependencyProperty StretchDirectionProperty
		{
			get;
		}
		DependencyProperty StretchProperty
		{
			get;
		}
	}
}

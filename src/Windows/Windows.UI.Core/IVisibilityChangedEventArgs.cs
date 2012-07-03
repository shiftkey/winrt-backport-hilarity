using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Core
{
	[ExclusiveTo(typeof(VisibilityChangedEventArgs)), Guid(3214481642u, 55297, 17764, 164, 149, 177, 232, 79, 138, 208, 133), Version(100794368u), WebHostHidden]
	internal interface IVisibilityChangedEventArgs : ICoreWindowEventArgs
	{
		bool Visible
		{
			get;
		}
	}
}

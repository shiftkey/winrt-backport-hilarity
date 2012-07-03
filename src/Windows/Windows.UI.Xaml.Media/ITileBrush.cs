using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media
{
	[ExclusiveTo(typeof(TileBrush)), Guid(3254898438u, 52612, 18597, 150, 7, 102, 77, 115, 97, 205, 97), Version(100794368u), WebHostHidden]
	internal interface ITileBrush
	{
		AlignmentX AlignmentX
		{
			get;
			set;
		}
		AlignmentY AlignmentY
		{
			get;
			set;
		}
		Stretch Stretch
		{
			get;
			set;
		}
	}
}

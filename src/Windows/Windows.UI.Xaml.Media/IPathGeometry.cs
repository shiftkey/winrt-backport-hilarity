using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media
{
	[ExclusiveTo(typeof(PathGeometry)), Guid(136027640u, 47846, 19403, 129, 60, 189, 224, 228, 109, 200, 183), Version(100794368u), WebHostHidden]
	internal interface IPathGeometry
	{
		PathFigureCollection Figures
		{
			get;
			set;
		}
		FillRule FillRule
		{
			get;
			set;
		}
	}
}

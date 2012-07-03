using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;
namespace Windows.UI.Xaml.Shapes
{
	[ExclusiveTo(typeof(Path)), Guid(2022192649u, 15703, 20284, 184, 165, 108, 171, 202, 201, 113, 31), Version(100794368u), WebHostHidden]
	internal interface IPath
	{
		Geometry Data
		{
			get;
			set;
		}
	}
}

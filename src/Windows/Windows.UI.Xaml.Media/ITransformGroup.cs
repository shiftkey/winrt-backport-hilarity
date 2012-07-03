using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media
{
	[ExclusiveTo(typeof(TransformGroup)), Guid(1665240268u, 36141, 18231, 185, 81, 42, 252, 225, 221, 196, 196), Version(100794368u), WebHostHidden]
	internal interface ITransformGroup
	{
		TransformCollection Children
		{
			get;
			set;
		}
		Matrix Value
		{
			get;
		}
	}
}

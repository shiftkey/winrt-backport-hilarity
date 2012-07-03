using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media.Animation
{
	[ExclusiveTo(typeof(ObjectKeyFrame)), Guid(2555553873u, 34195, 18670, 166, 164, 213, 212, 114, 15, 2, 154), Version(100794368u), WebHostHidden]
	internal interface IObjectKeyFrame
	{
		KeyTime KeyTime
		{
			get;
			set;
		}
		object Value
		{
			get;
			set;
		}
	}
}

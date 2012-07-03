using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(RichTextBlockOverflow)), Guid(68862711u, 20267, 17347, 161, 34, 63, 234, 156, 169, 220, 135), Version(100794368u), WebHostHidden]
	internal interface IRichTextBlockOverflowStatics
	{
		DependencyProperty HasOverflowContentProperty
		{
			get;
		}
		DependencyProperty OverflowContentTargetProperty
		{
			get;
		}
		DependencyProperty PaddingProperty
		{
			get;
		}
	}
}

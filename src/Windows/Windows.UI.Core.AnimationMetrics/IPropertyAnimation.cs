using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Core.AnimationMetrics
{
	[Guid(973190362u, 19852, 16670, 182, 21, 26, 222, 104, 58, 153, 3), Version(100794368u)]
	public interface IPropertyAnimation
	{
		Point Control1
		{
			get;
		}
		Point Control2
		{
			get;
		}
		TimeSpan Delay
		{
			get;
		}
		TimeSpan Duration
		{
			get;
		}
		PropertyAnimationType Type
		{
			get;
		}
	}
}

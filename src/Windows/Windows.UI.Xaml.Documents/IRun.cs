using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Documents
{
	[ExclusiveTo(typeof(Run)), Guid(1498758275u, 3604, 18877, 184, 75, 197, 38, 243, 3, 67, 73), Version(100794368u), WebHostHidden]
	internal interface IRun
	{
		FlowDirection FlowDirection
		{
			get;
			set;
		}
		string Text
		{
			get;
			set;
		}
	}
}

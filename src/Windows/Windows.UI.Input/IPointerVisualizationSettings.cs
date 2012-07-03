using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Input
{
	[ExclusiveTo(typeof(PointerVisualizationSettings)), Guid(1293837409u, 34039, 18845, 189, 145, 42, 54, 226, 183, 170, 162), Version(100794368u)]
	internal interface IPointerVisualizationSettings
	{
		bool IsBarrelButtonFeedbackEnabled
		{
			get;
			set;
		}
		bool IsContactFeedbackEnabled
		{
			get;
			set;
		}
	}
}

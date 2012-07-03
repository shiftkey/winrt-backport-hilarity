using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Input.Inking
{
	[ExclusiveTo(typeof(InkRecognizer)), Guid(125619875u, 36941, 17450, 177, 81, 170, 202, 54, 49, 196, 59), Version(100794368u)]
	internal interface IInkRecognizer
	{
		string Name
		{
			get;
		}
	}
}

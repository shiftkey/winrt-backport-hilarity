using System;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Activation
{
	[Guid(2360568145u, 22728, 17379, 148, 188, 65, 211, 63, 139, 99, 14), Version(100794368u)]
	public interface ISearchActivatedEventArgs : IActivatedEventArgs
	{
		string Language
		{
			get;
		}
		string QueryText
		{
			get;
		}
	}
}

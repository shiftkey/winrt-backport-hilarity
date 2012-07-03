using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Popups
{
	[Guid(1341733493u, 16709, 18431, 172, 127, 223, 241, 193, 250, 91, 15), Version(100794368u)]
	public interface IUICommand
	{
		object Id
		{
			[return: Variant]
			get;
			[param: Variant]
			set;
		}
		UICommandInvokedHandler Invoked
		{
			get;
			set;
		}
		string Label
		{
			get;
			set;
		}
	}
}

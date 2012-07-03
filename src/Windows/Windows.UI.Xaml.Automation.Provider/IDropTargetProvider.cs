using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Automation.Provider
{
	[Guid(2049203165u, 46168, 20448, 152, 200, 170, 200, 157, 245, 109, 97), Version(100794368u), WebHostHidden]
	public interface IDropTargetProvider
	{
		string DropEffect
		{
			get;
		}
		string[] DropEffects
		{
			get;
		}
	}
}

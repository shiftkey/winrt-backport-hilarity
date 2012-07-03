using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Automation.Provider
{
	[Guid(2056180633u, 26660, 17813, 186, 179, 70, 75, 201, 160, 68, 23), Version(100794368u), WebHostHidden]
	public interface ITableProvider
	{
		RowOrColumnMajor RowOrColumnMajor
		{
			get;
		}
		IRawElementProviderSimple[] GetColumnHeaders();
		IRawElementProviderSimple[] GetRowHeaders();
	}
}

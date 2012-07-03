using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Automation.Provider
{
	[Guid(2338502560u, 37676, 17552, 154, 19, 2, 253, 179, 154, 143, 91), Version(100794368u), WebHostHidden]
	public interface IGridProvider
	{
		int ColumnCount
		{
			get;
		}
		int RowCount
		{
			get;
		}
		IRawElementProviderSimple GetItem([In] int row, [In] int column);
	}
}

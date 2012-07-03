using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Automation.Provider
{
	[Guid(4294142012u, 29703, 17851, 169, 54, 223, 62, 214, 211, 131, 125), Version(100794368u), WebHostHidden]
	public interface IGridItemProvider
	{
		int Column
		{
			get;
		}
		int ColumnSpan
		{
			get;
		}
		IRawElementProviderSimple ContainingGrid
		{
			get;
		}
		int Row
		{
			get;
		}
		int RowSpan
		{
			get;
		}
	}
}

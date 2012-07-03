using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Automation.Provider
{
	[Guid(2512000023u, 17463, 17691, 148, 97, 5, 10, 73, 181, 157, 6), Version(100794368u), WebHostHidden]
	public interface IAnnotationProvider
	{
		int AnnotationTypeId
		{
			get;
		}
		string AnnotationTypeName
		{
			get;
		}
		string Author
		{
			get;
		}
		string DateTime
		{
			get;
		}
		IRawElementProviderSimple Target
		{
			get;
		}
	}
}

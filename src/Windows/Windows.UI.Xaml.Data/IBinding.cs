using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Data
{
	[ExclusiveTo(typeof(Binding)), Guid(1064963179u, 53263, 18224, 140, 29, 72, 225, 108, 70, 249, 202), Version(100794368u), WebHostHidden]
	internal interface IBinding
	{
		IValueConverter Converter
		{
			get;
			set;
		}
		string ConverterLanguage
		{
			get;
			set;
		}
		object ConverterParameter
		{
			get;
			set;
		}
		string ElementName
		{
			get;
			set;
		}
		BindingMode Mode
		{
			get;
			set;
		}
		PropertyPath Path
		{
			get;
			set;
		}
		RelativeSource RelativeSource
		{
			get;
			set;
		}
		object Source
		{
			get;
			set;
		}
	}
}

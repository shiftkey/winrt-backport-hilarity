using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Data
{
	[Composable(typeof(IBindingFactory), CompositionType.Public, 100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public class Binding : BindingBase, IBinding
	{
		public extern IValueConverter Converter
		{
			get;
			set;
		}
		public extern string ConverterLanguage
		{
			get;
			set;
		}
		public extern object ConverterParameter
		{
			get;
			set;
		}
		public extern string ElementName
		{
			get;
			set;
		}
		public extern BindingMode Mode
		{
			get;
			set;
		}
		public extern PropertyPath Path
		{
			get;
			set;
		}
		public extern RelativeSource RelativeSource
		{
			get;
			set;
		}
		public extern object Source
		{
			get;
			set;
		}
		public extern Binding();
	}
}

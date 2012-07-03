using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml
{
	[Composable(typeof(IDataTemplateKeyFactory), CompositionType.Public, 100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public class DataTemplateKey : IDataTemplateKey
	{
		public extern object DataType
		{
			get;
			set;
		}
		public extern DataTemplateKey();
		public extern DataTemplateKey([In] object dataType);
	}
}

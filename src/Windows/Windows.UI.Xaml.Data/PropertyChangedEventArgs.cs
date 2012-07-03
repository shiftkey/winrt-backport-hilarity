using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Data
{
	[Composable(typeof(IPropertyChangedEventArgsFactory), CompositionType.Public, 100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public class PropertyChangedEventArgs : IPropertyChangedEventArgs
	{
		public extern string PropertyName
		{
			get;
		}
		public extern PropertyChangedEventArgs([In] string name);
	}
}

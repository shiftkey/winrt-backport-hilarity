using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Data
{
	[Composable(typeof(ICurrentChangingEventArgsFactory), CompositionType.Public, 100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public class CurrentChangingEventArgs : ICurrentChangingEventArgs
	{
		public extern bool Cancel
		{
			get;
			set;
		}
		public extern bool IsCancelable
		{
			get;
		}
		public extern CurrentChangingEventArgs();
		public extern CurrentChangingEventArgs([In] bool isCancelable);
	}
}

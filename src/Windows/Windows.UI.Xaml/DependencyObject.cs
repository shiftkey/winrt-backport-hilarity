using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Core;
namespace Windows.UI.Xaml
{
	[Composable(typeof(IDependencyObjectFactory), CompositionType.Protected, 100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public class DependencyObject : IDependencyObject
	{
		public extern CoreDispatcher Dispatcher
		{
			get;
		}
		protected extern DependencyObject();
		public extern object GetValue([In] DependencyProperty dp);
		public extern void SetValue([In] DependencyProperty dp, [In] object value);
		public extern void ClearValue([In] DependencyProperty dp);
		public extern object ReadLocalValue([In] DependencyProperty dp);
		public extern object GetAnimationBaseValue([In] DependencyProperty dp);
	}
}

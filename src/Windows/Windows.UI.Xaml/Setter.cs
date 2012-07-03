using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml
{
	[Activatable(100794368u), Activatable(typeof(ISetterFactory), 100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class Setter : SetterBase, ISetter
	{
		public extern DependencyProperty Property
		{
			get;
			set;
		}
		public extern object Value
		{
			get;
			set;
		}
		public extern Setter();
		public extern Setter([In] DependencyProperty targetProperty, [In] object value);
	}
}

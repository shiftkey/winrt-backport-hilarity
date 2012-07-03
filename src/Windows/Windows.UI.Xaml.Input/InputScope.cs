using System;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Input
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class InputScope : DependencyObject, IInputScope
	{
		public extern IVector<InputScopeName> Names
		{
			get;
		}
		public extern InputScope();
	}
}

using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls.Primitives
{
	[MarshalingBehavior(MarshalingType.Agile), Static(typeof(IGeneratorPositionHelperStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class GeneratorPositionHelper : IGeneratorPositionHelper
	{
		public static extern GeneratorPosition FromIndexAndOffset([In] int index, [In] int offset);
	}
}

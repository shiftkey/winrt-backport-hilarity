using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Graphics.Imaging
{
	[Activatable(typeof(IBitmapTypedValueFactory), 100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u)]
	public sealed class BitmapTypedValue : IBitmapTypedValue
	{
		public extern PropertyType Type
		{
			get;
		}
		public extern object Value
		{
			get;
		}
		public extern BitmapTypedValue([In] object value, [In] PropertyType type);
	}
}

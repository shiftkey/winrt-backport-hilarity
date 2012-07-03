using System;
using Windows.Foundation.Metadata;
namespace Windows.Graphics.Imaging
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class BitmapTransform : IBitmapTransform
	{
		public extern BitmapBounds Bounds
		{
			get;
			set;
		}
		public extern BitmapFlip Flip
		{
			get;
			set;
		}
		public extern BitmapInterpolationMode InterpolationMode
		{
			get;
			set;
		}
		public extern BitmapRotation Rotation
		{
			get;
			set;
		}
		public extern uint ScaledHeight
		{
			get;
			set;
		}
		public extern uint ScaledWidth
		{
			get;
			set;
		}
		public extern BitmapTransform();
	}
}

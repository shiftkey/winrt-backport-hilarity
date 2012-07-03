using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml
{
	[Composable(typeof(IPropertyMetadataFactory), CompositionType.Public, 100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IPropertyMetadataStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public class PropertyMetadata : IPropertyMetadata
	{
		public extern CreateDefaultValueCallback CreateDefaultValueCallback
		{
			get;
		}
		public extern object DefaultValue
		{
			get;
		}
		public extern PropertyMetadata([In] object defaultValue);
		public extern PropertyMetadata([In] object defaultValue, [In] PropertyChangedCallback propertyChangedCallback);
		[DefaultOverload, Overload("CreateWithDefaultValue")]
		public static extern PropertyMetadata Create([In] object defaultValue);
		[DefaultOverload, Overload("CreateWithDefaultValueAndCallback")]
		public static extern PropertyMetadata Create([In] object defaultValue, [In] PropertyChangedCallback propertyChangedCallback);
		[Overload("CreateWithFactory")]
		public static extern PropertyMetadata Create([In] CreateDefaultValueCallback createDefaultValueCallback);
		[Overload("CreateWithFactoryAndCallback")]
		public static extern PropertyMetadata Create([In] CreateDefaultValueCallback createDefaultValueCallback, [In] PropertyChangedCallback propertyChangedCallback);
	}
}

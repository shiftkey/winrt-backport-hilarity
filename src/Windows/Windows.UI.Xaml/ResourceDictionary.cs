using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml
{
	[Composable(typeof(IResourceDictionaryFactory), CompositionType.Public, 100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public class ResourceDictionary : DependencyObject, IResourceDictionary, IMap<object, object>, IIterable<IKeyValuePair<object, object>>
	{
		public extern IVector<ResourceDictionary> MergedDictionaries
		{
			get;
		}
		public extern Uri Source
		{
			get;
			set;
		}
		public extern IMap<object, object> ThemeDictionaries
		{
			get;
		}
		public extern uint Size
		{
			get;
		}
		public extern ResourceDictionary();
		public extern object Lookup([In] object key);
		public extern bool HasKey([In] object key);
		public extern IMapView<object, object> GetView();
		public extern bool Insert([In] object key, [In] object value);
		public extern void Remove([In] object key);
		public extern void Clear();
		public extern IIterator<IKeyValuePair<object, object>> First();
	}
}

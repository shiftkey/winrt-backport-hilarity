using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;
namespace Windows.UI.Xaml.Controls
{
	[MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class ItemContainerGenerator : IItemContainerGenerator
	{
		public extern event ItemsChangedEventHandler ItemsChanged
		{
			add;
			remove;
		}
		public extern object ItemFromContainer([In] DependencyObject container);
		public extern DependencyObject ContainerFromItem([In] object item);
		public extern int IndexFromContainer([In] DependencyObject container);
		public extern DependencyObject ContainerFromIndex([In] int index);
		public extern ItemContainerGenerator GetItemContainerGeneratorForPanel([In] Panel panel);
		public extern void StartAt([In] GeneratorPosition position, [In] GeneratorDirection direction, [In] bool allowStartAtRealizedItem);
		public extern void Stop();
		public extern DependencyObject GenerateNext(out bool isNewlyRealized);
		public extern void PrepareItemContainer([In] DependencyObject container);
		public extern void RemoveAll();
		public extern void Remove([In] GeneratorPosition position, [In] int count);
		public extern GeneratorPosition GeneratorPositionFromIndex([In] int itemIndex);
		public extern int IndexFromGeneratorPosition([In] GeneratorPosition position);
		public extern void Recycle([In] GeneratorPosition position, [In] int count);
	}
}

using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(ItemContainerGenerator)), Guid(1081499392u, 33776, 19839, 177, 184, 241, 157, 228, 241, 213, 218), Version(100794368u), WebHostHidden]
	internal interface IItemContainerGenerator
	{
		event ItemsChangedEventHandler ItemsChanged;
		object ItemFromContainer([In] DependencyObject container);
		DependencyObject ContainerFromItem([In] object item);
		int IndexFromContainer([In] DependencyObject container);
		DependencyObject ContainerFromIndex([In] int index);
		ItemContainerGenerator GetItemContainerGeneratorForPanel([In] Panel panel);
		void StartAt([In] GeneratorPosition position, [In] GeneratorDirection direction, [In] bool allowStartAtRealizedItem);
		void Stop();
		DependencyObject GenerateNext(out bool isNewlyRealized);
		void PrepareItemContainer([In] DependencyObject container);
		void RemoveAll();
		void Remove([In] GeneratorPosition position, [In] int count);
		GeneratorPosition GeneratorPositionFromIndex([In] int itemIndex);
		int IndexFromGeneratorPosition([In] GeneratorPosition position);
		void Recycle([In] GeneratorPosition position, [In] int count);
	}
}

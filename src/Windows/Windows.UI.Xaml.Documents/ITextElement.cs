using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Text;
using Windows.UI.Xaml.Media;
namespace Windows.UI.Xaml.Documents
{
	[ExclusiveTo(typeof(TextElement)), Guid(3896180834u, 55158, 20370, 186, 234, 64, 231, 125, 71, 145, 213), Version(100794368u), WebHostHidden]
	internal interface ITextElement
	{
		int CharacterSpacing
		{
			get;
			set;
		}
		TextPointer ContentEnd
		{
			get;
		}
		TextPointer ContentStart
		{
			get;
		}
		TextPointer ElementEnd
		{
			get;
		}
		TextPointer ElementStart
		{
			get;
		}
		FontFamily FontFamily
		{
			get;
			set;
		}
		double FontSize
		{
			get;
			set;
		}
		FontStretch FontStretch
		{
			get;
			set;
		}
		FontStyle FontStyle
		{
			get;
			set;
		}
		FontWeight FontWeight
		{
			get;
			set;
		}
		Brush Foreground
		{
			get;
			set;
		}
		string Language
		{
			get;
			set;
		}
		string Name
		{
			get;
		}
		object FindName([In] string name);
	}
}

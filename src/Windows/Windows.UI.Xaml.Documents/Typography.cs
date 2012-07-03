using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Documents
{
	[MarshalingBehavior(MarshalingType.Agile), Static(typeof(ITypographyStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class Typography : ITypography
	{
		public static extern DependencyProperty AnnotationAlternatesProperty
		{
			get;
		}
		public static extern DependencyProperty CapitalSpacingProperty
		{
			get;
		}
		public static extern DependencyProperty CapitalsProperty
		{
			get;
		}
		public static extern DependencyProperty CaseSensitiveFormsProperty
		{
			get;
		}
		public static extern DependencyProperty ContextualAlternatesProperty
		{
			get;
		}
		public static extern DependencyProperty ContextualLigaturesProperty
		{
			get;
		}
		public static extern DependencyProperty ContextualSwashesProperty
		{
			get;
		}
		public static extern DependencyProperty DiscretionaryLigaturesProperty
		{
			get;
		}
		public static extern DependencyProperty EastAsianExpertFormsProperty
		{
			get;
		}
		public static extern DependencyProperty EastAsianLanguageProperty
		{
			get;
		}
		public static extern DependencyProperty EastAsianWidthsProperty
		{
			get;
		}
		public static extern DependencyProperty FractionProperty
		{
			get;
		}
		public static extern DependencyProperty HistoricalFormsProperty
		{
			get;
		}
		public static extern DependencyProperty HistoricalLigaturesProperty
		{
			get;
		}
		public static extern DependencyProperty KerningProperty
		{
			get;
		}
		public static extern DependencyProperty MathematicalGreekProperty
		{
			get;
		}
		public static extern DependencyProperty NumeralAlignmentProperty
		{
			get;
		}
		public static extern DependencyProperty NumeralStyleProperty
		{
			get;
		}
		public static extern DependencyProperty SlashedZeroProperty
		{
			get;
		}
		public static extern DependencyProperty StandardLigaturesProperty
		{
			get;
		}
		public static extern DependencyProperty StandardSwashesProperty
		{
			get;
		}
		public static extern DependencyProperty StylisticAlternatesProperty
		{
			get;
		}
		public static extern DependencyProperty StylisticSet10Property
		{
			get;
		}
		public static extern DependencyProperty StylisticSet11Property
		{
			get;
		}
		public static extern DependencyProperty StylisticSet12Property
		{
			get;
		}
		public static extern DependencyProperty StylisticSet13Property
		{
			get;
		}
		public static extern DependencyProperty StylisticSet14Property
		{
			get;
		}
		public static extern DependencyProperty StylisticSet15Property
		{
			get;
		}
		public static extern DependencyProperty StylisticSet16Property
		{
			get;
		}
		public static extern DependencyProperty StylisticSet17Property
		{
			get;
		}
		public static extern DependencyProperty StylisticSet18Property
		{
			get;
		}
		public static extern DependencyProperty StylisticSet19Property
		{
			get;
		}
		public static extern DependencyProperty StylisticSet1Property
		{
			get;
		}
		public static extern DependencyProperty StylisticSet20Property
		{
			get;
		}
		public static extern DependencyProperty StylisticSet2Property
		{
			get;
		}
		public static extern DependencyProperty StylisticSet3Property
		{
			get;
		}
		public static extern DependencyProperty StylisticSet4Property
		{
			get;
		}
		public static extern DependencyProperty StylisticSet5Property
		{
			get;
		}
		public static extern DependencyProperty StylisticSet6Property
		{
			get;
		}
		public static extern DependencyProperty StylisticSet7Property
		{
			get;
		}
		public static extern DependencyProperty StylisticSet8Property
		{
			get;
		}
		public static extern DependencyProperty StylisticSet9Property
		{
			get;
		}
		public static extern DependencyProperty VariantsProperty
		{
			get;
		}
		public static extern int GetAnnotationAlternates([In] DependencyObject element);
		public static extern void SetAnnotationAlternates([In] DependencyObject element, [In] int value);
		public static extern bool GetEastAsianExpertForms([In] DependencyObject element);
		public static extern void SetEastAsianExpertForms([In] DependencyObject element, [In] bool value);
		public static extern FontEastAsianLanguage GetEastAsianLanguage([In] DependencyObject element);
		public static extern void SetEastAsianLanguage([In] DependencyObject element, [In] FontEastAsianLanguage value);
		public static extern FontEastAsianWidths GetEastAsianWidths([In] DependencyObject element);
		public static extern void SetEastAsianWidths([In] DependencyObject element, [In] FontEastAsianWidths value);
		public static extern bool GetStandardLigatures([In] DependencyObject element);
		public static extern void SetStandardLigatures([In] DependencyObject element, [In] bool value);
		public static extern bool GetContextualLigatures([In] DependencyObject element);
		public static extern void SetContextualLigatures([In] DependencyObject element, [In] bool value);
		public static extern bool GetDiscretionaryLigatures([In] DependencyObject element);
		public static extern void SetDiscretionaryLigatures([In] DependencyObject element, [In] bool value);
		public static extern bool GetHistoricalLigatures([In] DependencyObject element);
		public static extern void SetHistoricalLigatures([In] DependencyObject element, [In] bool value);
		public static extern int GetStandardSwashes([In] DependencyObject element);
		public static extern void SetStandardSwashes([In] DependencyObject element, [In] int value);
		public static extern int GetContextualSwashes([In] DependencyObject element);
		public static extern void SetContextualSwashes([In] DependencyObject element, [In] int value);
		public static extern bool GetContextualAlternates([In] DependencyObject element);
		public static extern void SetContextualAlternates([In] DependencyObject element, [In] bool value);
		public static extern int GetStylisticAlternates([In] DependencyObject element);
		public static extern void SetStylisticAlternates([In] DependencyObject element, [In] int value);
		public static extern bool GetStylisticSet1([In] DependencyObject element);
		public static extern void SetStylisticSet1([In] DependencyObject element, [In] bool value);
		public static extern bool GetStylisticSet2([In] DependencyObject element);
		public static extern void SetStylisticSet2([In] DependencyObject element, [In] bool value);
		public static extern bool GetStylisticSet3([In] DependencyObject element);
		public static extern void SetStylisticSet3([In] DependencyObject element, [In] bool value);
		public static extern bool GetStylisticSet4([In] DependencyObject element);
		public static extern void SetStylisticSet4([In] DependencyObject element, [In] bool value);
		public static extern bool GetStylisticSet5([In] DependencyObject element);
		public static extern void SetStylisticSet5([In] DependencyObject element, [In] bool value);
		public static extern bool GetStylisticSet6([In] DependencyObject element);
		public static extern void SetStylisticSet6([In] DependencyObject element, [In] bool value);
		public static extern bool GetStylisticSet7([In] DependencyObject element);
		public static extern void SetStylisticSet7([In] DependencyObject element, [In] bool value);
		public static extern bool GetStylisticSet8([In] DependencyObject element);
		public static extern void SetStylisticSet8([In] DependencyObject element, [In] bool value);
		public static extern bool GetStylisticSet9([In] DependencyObject element);
		public static extern void SetStylisticSet9([In] DependencyObject element, [In] bool value);
		public static extern bool GetStylisticSet10([In] DependencyObject element);
		public static extern void SetStylisticSet10([In] DependencyObject element, [In] bool value);
		public static extern bool GetStylisticSet11([In] DependencyObject element);
		public static extern void SetStylisticSet11([In] DependencyObject element, [In] bool value);
		public static extern bool GetStylisticSet12([In] DependencyObject element);
		public static extern void SetStylisticSet12([In] DependencyObject element, [In] bool value);
		public static extern bool GetStylisticSet13([In] DependencyObject element);
		public static extern void SetStylisticSet13([In] DependencyObject element, [In] bool value);
		public static extern bool GetStylisticSet14([In] DependencyObject element);
		public static extern void SetStylisticSet14([In] DependencyObject element, [In] bool value);
		public static extern bool GetStylisticSet15([In] DependencyObject element);
		public static extern void SetStylisticSet15([In] DependencyObject element, [In] bool value);
		public static extern bool GetStylisticSet16([In] DependencyObject element);
		public static extern void SetStylisticSet16([In] DependencyObject element, [In] bool value);
		public static extern bool GetStylisticSet17([In] DependencyObject element);
		public static extern void SetStylisticSet17([In] DependencyObject element, [In] bool value);
		public static extern bool GetStylisticSet18([In] DependencyObject element);
		public static extern void SetStylisticSet18([In] DependencyObject element, [In] bool value);
		public static extern bool GetStylisticSet19([In] DependencyObject element);
		public static extern void SetStylisticSet19([In] DependencyObject element, [In] bool value);
		public static extern bool GetStylisticSet20([In] DependencyObject element);
		public static extern void SetStylisticSet20([In] DependencyObject element, [In] bool value);
		public static extern FontCapitals GetCapitals([In] DependencyObject element);
		public static extern void SetCapitals([In] DependencyObject element, [In] FontCapitals value);
		public static extern bool GetCapitalSpacing([In] DependencyObject element);
		public static extern void SetCapitalSpacing([In] DependencyObject element, [In] bool value);
		public static extern bool GetKerning([In] DependencyObject element);
		public static extern void SetKerning([In] DependencyObject element, [In] bool value);
		public static extern bool GetCaseSensitiveForms([In] DependencyObject element);
		public static extern void SetCaseSensitiveForms([In] DependencyObject element, [In] bool value);
		public static extern bool GetHistoricalForms([In] DependencyObject element);
		public static extern void SetHistoricalForms([In] DependencyObject element, [In] bool value);
		public static extern FontFraction GetFraction([In] DependencyObject element);
		public static extern void SetFraction([In] DependencyObject element, [In] FontFraction value);
		public static extern FontNumeralStyle GetNumeralStyle([In] DependencyObject element);
		public static extern void SetNumeralStyle([In] DependencyObject element, [In] FontNumeralStyle value);
		public static extern FontNumeralAlignment GetNumeralAlignment([In] DependencyObject element);
		public static extern void SetNumeralAlignment([In] DependencyObject element, [In] FontNumeralAlignment value);
		public static extern bool GetSlashedZero([In] DependencyObject element);
		public static extern void SetSlashedZero([In] DependencyObject element, [In] bool value);
		public static extern bool GetMathematicalGreek([In] DependencyObject element);
		public static extern void SetMathematicalGreek([In] DependencyObject element, [In] bool value);
		public static extern FontVariants GetVariants([In] DependencyObject element);
		public static extern void SetVariants([In] DependencyObject element, [In] FontVariants value);
	}
}

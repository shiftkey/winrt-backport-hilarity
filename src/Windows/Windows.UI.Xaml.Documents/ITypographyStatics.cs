using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Documents
{
	[ExclusiveTo(typeof(Typography)), Guid(1740237960u, 27735, 19680, 149, 241, 212, 185, 237, 99, 47, 180), Version(100794368u), WebHostHidden]
	internal interface ITypographyStatics
	{
		DependencyProperty AnnotationAlternatesProperty
		{
			get;
		}
		DependencyProperty CapitalSpacingProperty
		{
			get;
		}
		DependencyProperty CapitalsProperty
		{
			get;
		}
		DependencyProperty CaseSensitiveFormsProperty
		{
			get;
		}
		DependencyProperty ContextualAlternatesProperty
		{
			get;
		}
		DependencyProperty ContextualLigaturesProperty
		{
			get;
		}
		DependencyProperty ContextualSwashesProperty
		{
			get;
		}
		DependencyProperty DiscretionaryLigaturesProperty
		{
			get;
		}
		DependencyProperty EastAsianExpertFormsProperty
		{
			get;
		}
		DependencyProperty EastAsianLanguageProperty
		{
			get;
		}
		DependencyProperty EastAsianWidthsProperty
		{
			get;
		}
		DependencyProperty FractionProperty
		{
			get;
		}
		DependencyProperty HistoricalFormsProperty
		{
			get;
		}
		DependencyProperty HistoricalLigaturesProperty
		{
			get;
		}
		DependencyProperty KerningProperty
		{
			get;
		}
		DependencyProperty MathematicalGreekProperty
		{
			get;
		}
		DependencyProperty NumeralAlignmentProperty
		{
			get;
		}
		DependencyProperty NumeralStyleProperty
		{
			get;
		}
		DependencyProperty SlashedZeroProperty
		{
			get;
		}
		DependencyProperty StandardLigaturesProperty
		{
			get;
		}
		DependencyProperty StandardSwashesProperty
		{
			get;
		}
		DependencyProperty StylisticAlternatesProperty
		{
			get;
		}
		DependencyProperty StylisticSet10Property
		{
			get;
		}
		DependencyProperty StylisticSet11Property
		{
			get;
		}
		DependencyProperty StylisticSet12Property
		{
			get;
		}
		DependencyProperty StylisticSet13Property
		{
			get;
		}
		DependencyProperty StylisticSet14Property
		{
			get;
		}
		DependencyProperty StylisticSet15Property
		{
			get;
		}
		DependencyProperty StylisticSet16Property
		{
			get;
		}
		DependencyProperty StylisticSet17Property
		{
			get;
		}
		DependencyProperty StylisticSet18Property
		{
			get;
		}
		DependencyProperty StylisticSet19Property
		{
			get;
		}
		DependencyProperty StylisticSet1Property
		{
			get;
		}
		DependencyProperty StylisticSet20Property
		{
			get;
		}
		DependencyProperty StylisticSet2Property
		{
			get;
		}
		DependencyProperty StylisticSet3Property
		{
			get;
		}
		DependencyProperty StylisticSet4Property
		{
			get;
		}
		DependencyProperty StylisticSet5Property
		{
			get;
		}
		DependencyProperty StylisticSet6Property
		{
			get;
		}
		DependencyProperty StylisticSet7Property
		{
			get;
		}
		DependencyProperty StylisticSet8Property
		{
			get;
		}
		DependencyProperty StylisticSet9Property
		{
			get;
		}
		DependencyProperty VariantsProperty
		{
			get;
		}
		int GetAnnotationAlternates([In] DependencyObject element);
		void SetAnnotationAlternates([In] DependencyObject element, [In] int value);
		bool GetEastAsianExpertForms([In] DependencyObject element);
		void SetEastAsianExpertForms([In] DependencyObject element, [In] bool value);
		FontEastAsianLanguage GetEastAsianLanguage([In] DependencyObject element);
		void SetEastAsianLanguage([In] DependencyObject element, [In] FontEastAsianLanguage value);
		FontEastAsianWidths GetEastAsianWidths([In] DependencyObject element);
		void SetEastAsianWidths([In] DependencyObject element, [In] FontEastAsianWidths value);
		bool GetStandardLigatures([In] DependencyObject element);
		void SetStandardLigatures([In] DependencyObject element, [In] bool value);
		bool GetContextualLigatures([In] DependencyObject element);
		void SetContextualLigatures([In] DependencyObject element, [In] bool value);
		bool GetDiscretionaryLigatures([In] DependencyObject element);
		void SetDiscretionaryLigatures([In] DependencyObject element, [In] bool value);
		bool GetHistoricalLigatures([In] DependencyObject element);
		void SetHistoricalLigatures([In] DependencyObject element, [In] bool value);
		int GetStandardSwashes([In] DependencyObject element);
		void SetStandardSwashes([In] DependencyObject element, [In] int value);
		int GetContextualSwashes([In] DependencyObject element);
		void SetContextualSwashes([In] DependencyObject element, [In] int value);
		bool GetContextualAlternates([In] DependencyObject element);
		void SetContextualAlternates([In] DependencyObject element, [In] bool value);
		int GetStylisticAlternates([In] DependencyObject element);
		void SetStylisticAlternates([In] DependencyObject element, [In] int value);
		bool GetStylisticSet1([In] DependencyObject element);
		void SetStylisticSet1([In] DependencyObject element, [In] bool value);
		bool GetStylisticSet2([In] DependencyObject element);
		void SetStylisticSet2([In] DependencyObject element, [In] bool value);
		bool GetStylisticSet3([In] DependencyObject element);
		void SetStylisticSet3([In] DependencyObject element, [In] bool value);
		bool GetStylisticSet4([In] DependencyObject element);
		void SetStylisticSet4([In] DependencyObject element, [In] bool value);
		bool GetStylisticSet5([In] DependencyObject element);
		void SetStylisticSet5([In] DependencyObject element, [In] bool value);
		bool GetStylisticSet6([In] DependencyObject element);
		void SetStylisticSet6([In] DependencyObject element, [In] bool value);
		bool GetStylisticSet7([In] DependencyObject element);
		void SetStylisticSet7([In] DependencyObject element, [In] bool value);
		bool GetStylisticSet8([In] DependencyObject element);
		void SetStylisticSet8([In] DependencyObject element, [In] bool value);
		bool GetStylisticSet9([In] DependencyObject element);
		void SetStylisticSet9([In] DependencyObject element, [In] bool value);
		bool GetStylisticSet10([In] DependencyObject element);
		void SetStylisticSet10([In] DependencyObject element, [In] bool value);
		bool GetStylisticSet11([In] DependencyObject element);
		void SetStylisticSet11([In] DependencyObject element, [In] bool value);
		bool GetStylisticSet12([In] DependencyObject element);
		void SetStylisticSet12([In] DependencyObject element, [In] bool value);
		bool GetStylisticSet13([In] DependencyObject element);
		void SetStylisticSet13([In] DependencyObject element, [In] bool value);
		bool GetStylisticSet14([In] DependencyObject element);
		void SetStylisticSet14([In] DependencyObject element, [In] bool value);
		bool GetStylisticSet15([In] DependencyObject element);
		void SetStylisticSet15([In] DependencyObject element, [In] bool value);
		bool GetStylisticSet16([In] DependencyObject element);
		void SetStylisticSet16([In] DependencyObject element, [In] bool value);
		bool GetStylisticSet17([In] DependencyObject element);
		void SetStylisticSet17([In] DependencyObject element, [In] bool value);
		bool GetStylisticSet18([In] DependencyObject element);
		void SetStylisticSet18([In] DependencyObject element, [In] bool value);
		bool GetStylisticSet19([In] DependencyObject element);
		void SetStylisticSet19([In] DependencyObject element, [In] bool value);
		bool GetStylisticSet20([In] DependencyObject element);
		void SetStylisticSet20([In] DependencyObject element, [In] bool value);
		FontCapitals GetCapitals([In] DependencyObject element);
		void SetCapitals([In] DependencyObject element, [In] FontCapitals value);
		bool GetCapitalSpacing([In] DependencyObject element);
		void SetCapitalSpacing([In] DependencyObject element, [In] bool value);
		bool GetKerning([In] DependencyObject element);
		void SetKerning([In] DependencyObject element, [In] bool value);
		bool GetCaseSensitiveForms([In] DependencyObject element);
		void SetCaseSensitiveForms([In] DependencyObject element, [In] bool value);
		bool GetHistoricalForms([In] DependencyObject element);
		void SetHistoricalForms([In] DependencyObject element, [In] bool value);
		FontFraction GetFraction([In] DependencyObject element);
		void SetFraction([In] DependencyObject element, [In] FontFraction value);
		FontNumeralStyle GetNumeralStyle([In] DependencyObject element);
		void SetNumeralStyle([In] DependencyObject element, [In] FontNumeralStyle value);
		FontNumeralAlignment GetNumeralAlignment([In] DependencyObject element);
		void SetNumeralAlignment([In] DependencyObject element, [In] FontNumeralAlignment value);
		bool GetSlashedZero([In] DependencyObject element);
		void SetSlashedZero([In] DependencyObject element, [In] bool value);
		bool GetMathematicalGreek([In] DependencyObject element);
		void SetMathematicalGreek([In] DependencyObject element, [In] bool value);
		FontVariants GetVariants([In] DependencyObject element);
		void SetVariants([In] DependencyObject element, [In] FontVariants value);
	}
}

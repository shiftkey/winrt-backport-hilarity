using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media.Animation
{
	[AttributeUsage(AttributeTargets.Property), Version(100794368u), WebHostHidden]
	public sealed class IndependentlyAnimatableAttribute : Attribute
	{
		public extern IndependentlyAnimatableAttribute();
	}
}

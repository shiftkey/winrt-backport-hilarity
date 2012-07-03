using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Core.AnimationMetrics
{
	[Version(100794368u)]
	public enum AnimationEffect
	{
		Expand,
		Collapse,
		Reposition,
		FadeIn,
		FadeOut,
		AddToList,
		DeleteFromList,
		AddToGrid,
		DeleteFromGrid,
		AddToSearchGrid,
		DeleteFromSearchGrid,
		AddToSearchList,
		DeleteFromSearchList,
		ShowEdgeUI,
		ShowPanel,
		HideEdgeUI,
		HidePanel,
		ShowPopup,
		HidePopup,
		PointerDown,
		PointerUp,
		DragSourceStart,
		DragSourceEnd,
		TransitionContent,
		Reveal,
		Hide,
		DragBetweenEnter,
		DragBetweenLeave,
		SwipeSelect,
		SwipeDeselect,
		SwipeReveal,
		EnterPage,
		TransitionPage,
		CrossFade,
		Peek,
		UpdateBadge
	}
}

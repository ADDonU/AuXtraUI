using UnityEngine;
using UnityEngine.UI;

public static class auXtraUiExtensions
{

	public static void setTextFieldColors(InputField mInputField, 
	  Color normalColor, Color highlightColor, Color pressedColor){
		ColorBlock theColors = mInputField.colors;
		theColors.normalColor = normalColor;
		theColors.highlightedColor = highlightColor;
		theColors.pressedColor = pressedColor;
		mInputField.colors = theColors;

	}

	public static void setButtonColors(Button mButton, 
	  Color normalColor, Color highlightColor, Color pressedColor){
		ColorBlock theColors = mButton.colors;
		theColors.normalColor = normalColor;
		theColors.highlightedColor = highlightColor;
		theColors.pressedColor = pressedColor;
		mButton.colors = theColors;

	}

	public static void setToggleColors(Toggle mToggle, 
	  Color normalColor, Color highlightColor, Color pressedColor){
		ColorBlock theColors = mToggle.colors;
		theColors.normalColor = normalColor;
		theColors.highlightedColor = highlightColor;
		theColors.pressedColor = pressedColor;
		mToggle.colors = theColors;

	}

	public static void setScrollbarColors(Scrollbar mScrollbar, 
	  Color normalColor, Color highlightColor, Color pressedColor){
		ColorBlock theColors = mScrollbar.colors;
		theColors.normalColor = normalColor;
		theColors.highlightedColor = highlightColor;
		theColors.pressedColor = pressedColor;
		mScrollbar.colors = theColors;

	}

	public static void setDropdownColors(Dropdown mDropdown, 
		Color normalColor, Color highlightColor, Color pressedColor, Color bgColor){

		setUiImageColor (mDropdown.template.GetComponent<Image> (), bgColor);
		setToggleColors(mDropdown.template.GetComponentInChildren<Toggle>(),normalColor, highlightColor, pressedColor);
		setScrollbarColors(mDropdown.template.GetComponentInChildren<Scrollbar>(),normalColor, highlightColor, pressedColor);
		ColorBlock theColors = mDropdown.colors;
		theColors.normalColor = normalColor;
		theColors.highlightedColor = highlightColor;
		theColors.pressedColor = pressedColor;
		mDropdown.colors = theColors;

	}

	public static void setUiImageColor(Image mImage, Color bgColor){
		mImage.color = bgColor;
	}

    // Thanks to --> https://forum.unity.com/threads/changing-a-new-ui-images-alpha-value.289755/#post-2699525
	public static void SetTransparency(UnityEngine.UI.Image p_image, float p_transparency)
	{
		if (p_image != null)
		{
			UnityEngine.Color __alpha = p_image.color;
			__alpha.a = p_transparency;
			p_image.color = __alpha;
		}
	}
}

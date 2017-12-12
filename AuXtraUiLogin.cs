using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public partial class UILogin {
	[Header("AuXtraUI Login Panel")]


	public Color auXtraUiLoginNormalColor = new Color(0.9F, 0.8F, 0.7F, 1F);
	public Color auXtraUiLoginHighlightedColor = new Color(0.8F, 0.7F, 0.6F, 1F);
	public Color auXtraUiLoginPressedColor = new Color(0.8F, 0.7F, 0.6F, 1F);
	public Color auXtraUiLoginBackgroundColor = new Color(0F, 0F, 0F, 0.65F);

	//	public Sprite loginBgImage;

	public void setBaseColors(Color AuXtraUiLoginNormalColor, Color  AuXtraUiLoginHighlightedColor, Color  AuXtraUiLoginPressedColor, Color  AuXtraUiLoginBackgroundColor){
		auXtraUiLoginNormalColor = AuXtraUiLoginNormalColor;
		auXtraUiLoginHighlightedColor = AuXtraUiLoginHighlightedColor;
		auXtraUiLoginPressedColor = AuXtraUiLoginPressedColor;
		auXtraUiLoginBackgroundColor = AuXtraUiLoginBackgroundColor;
	}

	void Update_AuXtraUiLogin() {
		Image myImageComponent = panel.GetComponent<Image> ();
		myImageComponent.color = auXtraUiLoginBackgroundColor;
		auXtraUiExtensions.setTextFieldColors (accountInput, auXtraUiLoginNormalColor, auXtraUiLoginHighlightedColor, auXtraUiLoginPressedColor);
		auXtraUiExtensions.setTextFieldColors (passwordInput, auXtraUiLoginNormalColor, auXtraUiLoginHighlightedColor, auXtraUiLoginPressedColor);
		auXtraUiExtensions.setDropdownColors (serverDropdown, auXtraUiLoginNormalColor, auXtraUiLoginHighlightedColor, auXtraUiLoginPressedColor, auXtraUiLoginBackgroundColor);
		auXtraUiExtensions.setButtonColors (loginButton, auXtraUiLoginNormalColor, auXtraUiLoginHighlightedColor, auXtraUiLoginPressedColor);
		auXtraUiExtensions.setButtonColors (registerButton, auXtraUiLoginNormalColor, auXtraUiLoginHighlightedColor, auXtraUiLoginPressedColor);
		auXtraUiExtensions.setButtonColors (hostButton, auXtraUiLoginNormalColor, auXtraUiLoginHighlightedColor, auXtraUiLoginPressedColor);
		auXtraUiExtensions.setButtonColors (dedicatedButton, auXtraUiLoginNormalColor, auXtraUiLoginHighlightedColor, auXtraUiLoginPressedColor);
		auXtraUiExtensions.setButtonColors (cancelButton, auXtraUiLoginNormalColor, auXtraUiLoginHighlightedColor, auXtraUiLoginPressedColor);
		auXtraUiExtensions.setButtonColors (quitButton, auXtraUiLoginNormalColor, auXtraUiLoginHighlightedColor, auXtraUiLoginPressedColor);

		//		if (loginBgImage == null) {
		//			loginBgImage = Resources.Load ("panelBgBasic1", typeof(Sprite)) as Sprite;
		//		}
		//			myImageComponent.sprite = loginBgImage;
	}
}



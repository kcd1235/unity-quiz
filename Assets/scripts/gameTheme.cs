using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class gameTheme : MonoBehaviour {

	public Button playButton;
	public Text themeNameText;
	public GameObject themeInfo;
	public Text themeInfoText;
	public GameObject[] estrelas;

	public string[] themeNames;

	private int themeId;

	// Use this for initialization
	void Start () {
		themeId = 0;
		themeNameText.text = themeNames [themeId];

		themeInfo.SetActive (false);
		themeInfoText.text = "";
		foreach (GameObject estrela in estrelas) {
			estrela.SetActive (false);
		}

		playButton.interactable = false;
	}
	
	// Update is called once per frame
	void Update () {
		playButton.interactable = themeId != 0;
	}
}

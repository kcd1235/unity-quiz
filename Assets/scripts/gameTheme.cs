using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
		themeInfoText.text = "Você acertou X de X questões.";
		foreach (GameObject estrela in estrelas) {
			estrela.SetActive (false);
		}

		playButton.interactable = false;
	}
	
	// Update is called once per frame
	void Update () {
		playButton.interactable = themeId != 0;
	}

	public void themeSelect(int _themeId)
	{
		themeId = _themeId;
		themeNameText.text = themeNames [themeId];
		themeInfo.SetActive (true);
		playButton.interactable = true;

		int finalScore = 0;
		int corrects = 0;
		themeInfoText.text = "Você acertou " + corrects.ToString() + " de 20 questões.";
	}

	public void play()
	{
		SceneManager.LoadScene ("T" + themeId.ToString ());
	}
}

using UnityEngine;
using System.Collections;

public class themeInfo : MonoBehaviour {

	public int themeId;

	public GameObject star1;
	public GameObject star2;
	public GameObject star3;

	private int finalScore;

	// Use this for initialization
	void Start () {
		star1.SetActive (false);
		star2.SetActive (false);
		star3.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

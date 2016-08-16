using UnityEngine;
using System.Collections;

public class MoveOffset : MonoBehaviour {

	[SerializeField]
	public float horizontalSpeed;
	[SerializeField]
	public float verticalSpeed;

	private Material material;
	private float horizontalOffset = 1;
	private float verticalOffset = 1;


	// Use this for initialization
	void Start () {
		material = GetComponent<Renderer>().material;
	}
	
	// Update is called once per frame
	void FixedUpdate(){
		horizontalOffset += 1;
		verticalOffset += 1;

		Vector2 vector = new Vector2 (horizontalOffset * horizontalSpeed, verticalOffset * verticalSpeed);
		material.SetTextureOffset ("_MainTex", vector);
	}

	void Update () {
	}
}

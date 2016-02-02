using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class movieBackground : MonoBehaviour {

	MovieTexture m;

	// Use this for initialization
	void Start () {
		m = (MovieTexture)GetComponent<RawImage> ().texture;
		m.Play ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

using UnityEngine;
using System.Collections;

public class Container : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void Open()
    {
        PlayMakerFSM mainFSM = GetComponent<PlayMakerFSM>();

        mainFSM.SendEvent("Open");
    }
}

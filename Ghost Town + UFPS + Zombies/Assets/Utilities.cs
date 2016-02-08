using UnityEngine;
using System.Collections;

public class Utilities : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public bool canISeeGameObject(GameObject targetObject) {
		RaycastHit r;

		Vector3 angleToPlayer = transform.position = targetObject.transform.position;

		Physics.Raycast (transform.position, angleToPlayer, out r);

		Collider hitCollider = r.collider;
		GameObject hitGameObject = hitCollider.gameObject;

		return (hitGameObject == targetObject);
	}
}

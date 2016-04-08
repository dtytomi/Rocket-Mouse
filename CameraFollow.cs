	using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	public GameObject targetObjet;

	private float distanceToTarget;

	// Use this for initialization
	void Start () {
		distanceToTarget = transform.position.x - targetObjet.transform.position.x;
	}
	
	// Update is called once per frame
	void Update () {

		float targetObjetX = targetObjet.transform.position.x;

		Vector3 newCameraPosition = transform.position;
		newCameraPosition.x = targetObjetX + distanceToTarget;
		transform.position = newCameraPosition;
	}
}

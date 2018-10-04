using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public Transform perso;
	public Vector3 offset;
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (perso.position.x + 0, 0, -10);
	}
}

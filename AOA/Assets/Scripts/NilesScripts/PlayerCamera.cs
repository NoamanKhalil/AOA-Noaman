﻿using System.Collections;
using UnityEngine;

public class PlayerCamera : MonoBehaviour {

	// Use this for initialization
	public float xMin;
	public float xMax;
	public float zMin;
	public float zMax;

	Transform Player;

	void LateUpdate () {
		Player = GameObject.Find ("soldier(Clone)").GetComponent<Transform> ();
		transform.position = new Vector3(Mathf.Clamp(Player.position.x, xMin, xMax), transform.position.y, Mathf.Clamp(Player.position.z, zMin, zMax));
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {


	private GameObject player;
	public float scale = 3.0f;
	public float cameraSpeed = 100.0f;
	Vector3 cameraPosOffset = new Vector3 (0.0f,2.0f,0.0f);
	Vector3 lookAtOffset = new Vector3 (0.0f,1.0f,0.0f);

	void Start () {
			player = GameObject.FindGameObjectWithTag("Player");
	}

	void Update () {

			Vector3 cameraPosNext = player.transform.position + scale * (-player.transform.forward) + cameraPosOffset;
			this.transform.position = cameraPosNext;
			/*
			this.transform.position = Vector3.Lerp (
					this.transform.position,
					cameraPosNext,
					cameraSpeed * Time.deltaTime
			);
			*/

			Vector3 lookAt = player.transform.position + lookAtOffset;
			this.transform.LookAt (lookAt);
	}
}

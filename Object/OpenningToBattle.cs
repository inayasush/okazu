﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenningToBattle : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey("c")) {
			SceneManager.LoadScene ("Battle");
		}
	}


	public void toBattle(){
		SceneManager.LoadScene ("Battle");
	}
}

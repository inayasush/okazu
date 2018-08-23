using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class House : MonoBehaviour {

 	private float hitPoint = 100.0f;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if(hitPoint <= 0.0f){
			Destroy(this.gameObject);
      SceneManager.LoadScene ("Openning");
		}
	}

	public float GetHitPoint(){return hitPoint;}
	public void SetHitPoint(float _hitPoint){hitPoint = _hitPoint;}

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}


	void OnCollisionEnter(Collision collisionObject){
		if(collisionObject.gameObject.name == "EnemyPrefab(Clone)"){
			Enemy enemy = collisionObject.gameObject.GetComponent("Enemy") as Enemy;
			if (enemy != null) {
				enemy.SetHitPoint(enemy.GetHitPoint()-45f);
			}
		}
	}
	void OnCollisionExit(Collision collisionObject) {}
	void OnCollisionStay(Collision collisionObject) {
		/*
		if(collisionObject.gameObject.name == "EnemyPrefab(Clone)"){
			Enemy enemy = collisionObject.gameObject.GetComponent("Enemy") as Enemy;
			if (enemy != null) {
				enemy.Rebound();
			}
		}
		*/
	}
}

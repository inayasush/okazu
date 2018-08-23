using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	Vector3 nextPos;
	Vector3 forward;
	Vector3 targetPos = new Vector3(0,0,0);
	bool isWalking = true;
	private float hitPoint = 100.0f;

	void Start () {

	}

	void Update () {
		if(isWalking == true){
			nextPos = targetPos - transform.position;
			nextPos = transform.position + 0.1f*nextPos.normalized;
			float height = Terrain.activeTerrain.terrainData.GetInterpolatedHeight((nextPos.x+50)/Terrain.activeTerrain.terrainData.size.x, (nextPos.z+50)/Terrain.activeTerrain.terrainData.size.z);
			nextPos.y = height+0.5f;
			transform.position = nextPos;
		}else{}



		//hitPoint -= 0.1f;
		if(hitPoint <= 0.0f){
			Destroy(this.gameObject);
		}
		this.gameObject.GetComponent<Renderer>().material.color = new Color((hitPoint+40)/140, hitPoint/100, hitPoint/100, 1f);
	}

	public float GetHitPoint(){return hitPoint;}
	public void SetHitPoint(float _hitPoint){hitPoint = _hitPoint;}

	public void Rebound(){
		forward = targetPos - transform.position;
		this.gameObject.GetComponent<Rigidbody>().AddForce(-200*forward.normalized);
		//this.gameObject.GetComponent<Rigidbody>().detectCollisions = false;
		//this.gameObject.GetComponent<SphereCollider>().enabled = false;
		//this.gameObject.GetComponent<Rigidbody>().isKinematic = true;
	}

	void OnCollisionEnter(Collision collisionObject){}
	void OnCollisionExit(Collision collisionObject) {}
	void OnCollisionStay(Collision collisionObject) {
		if(collisionObject.gameObject.name == "House"){
			House house = collisionObject.gameObject.GetComponent("House") as House;
			if (house != null){
					house.SetHitPoint(house.GetHitPoint()-0.3f);
					Rebound();
			}
		}
		else if(collisionObject.gameObject.name == "Sword"){
			Sword sword = collisionObject.gameObject.GetComponent("Sword") as Sword;
			if (sword != null){
					Rebound();
			}
		}
	}
}

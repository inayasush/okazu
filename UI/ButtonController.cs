using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : ButtonBaseController {

	Player player;
	OpenningToBattle openningToBattle;
	bool leftButton = false;
	bool rightButton = false;
	bool attackButton = false;
	bool dashButton = false;

	void Start () {
		if(GameObject.Find("OpenningToBattle") != null){
			openningToBattle = GameObject.Find("OpenningToBattle").GetComponent("OpenningToBattle") as OpenningToBattle;
		}

		if(GameObject.Find("Player") != null){
			player = GameObject.Find("Player").GetComponent("Player") as Player;
		}
	}


	void Update () {

		if (leftButton == true){
				this.LeftButtonClick();
		}else if (rightButton == true){
				this.RightButtonClick();
		}else if (attackButton == true){
				this.AttackButtonClick();
		}else if (dashButton == true){
				this.DashButtonClick();
		}


	}



	protected override void PushDown(string objectName){

			if ("LeftButton".Equals(objectName)){
				leftButton = true;
			}else if ("RightButton".Equals(objectName)){
				rightButton = true;
			}else if ("AttackButton".Equals(objectName)){
				attackButton = true;
			}else if ("DashButton".Equals(objectName)){
				dashButton = true;
				player.DashOn();
			}


			else{

					throw new System.Exception("Not implemented!!");
			}
	}



	protected override void PushUp(string objectName){

			if ("LeftButton".Equals(objectName)){
				leftButton = false;
			}else if ("RightButton".Equals(objectName)){
				rightButton = false;
			}else if ("AttackButton".Equals(objectName)){
				attackButton = false;
			}else if ("DashButton".Equals(objectName)){
				dashButton = false;
				player.DashOff();
			}else if ("StartButton".Equals(objectName)){
				Debug.Log("StartButton Click");
				openningToBattle.toBattle();
			}



			else{

					throw new System.Exception("Not implemented!!");
			}
	}







	private void LeftButtonClick(){

			player.LeftButton();
			Debug.Log("LeftButton Click");
	}

	private void RightButtonClick(){

			player.RightButton();
			Debug.Log("RightButton Click");
	}

	private void AttackButtonClick(){

			player.AttackButton();
			Debug.Log("AttackButton Click");
	}

	private void DashButtonClick(){

			player.DashButton();
			Debug.Log("DashButton Click");
	}


}

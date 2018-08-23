using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonBaseController : MonoBehaviour {

	public ButtonBaseController button;

    public void PushDown(){
        if (button == null){
            throw new System.Exception("Button instance is null!!");
        }
        // 自身のオブジェクト名を渡す
        button.PushDown(this.gameObject.name);
    }


		public void PushUp(){
        if (button == null){
            throw new System.Exception("Button instance is null!!");
        }
        // 自身のオブジェクト名を渡す
        button.PushUp(this.gameObject.name);
    }


    protected virtual void PushDown(string objectName){

        // 呼ばれることはない
        Debug.Log("Base Button");
    }

		protected virtual void PushUp(string objectName){

        // 呼ばれることはない
        Debug.Log("Base Button");
    }

}

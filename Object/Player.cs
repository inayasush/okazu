using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

  private Animator animator;
  Vector3 nextPos;
  bool isWalking = false;


  void Start () {
      animator = GetComponent<Animator>();
  }


  void Update () {
      if (Input.GetKey("w")) {
        nextPos = transform.position;
        //transform.position += transform.forward * 0.1f;
        float height = Terrain.activeTerrain.terrainData.GetInterpolatedHeight((transform.position.x+50)/Terrain.activeTerrain.terrainData.size.x, (transform.position.z+50)/Terrain.activeTerrain.terrainData.size.z);
        nextPos.y = height;
        //transform.position = nextPos;
        transform.position = nextPos;
        if(isWalking == false){
          isWalking = true;
          animator.SetBool("isRunning", true);
        }
      } else {
        if(isWalking == true){
          isWalking = false;
          animator.SetBool("isRunning", false);
        }
      }

      if (Input.GetKey("k") && !animator.GetCurrentAnimatorStateInfo(0).IsName("Attack1")) {
        //animator.SetBool("isAttack", true);
        animator.SetTrigger("isattack");
      }

      if (Input.GetKey("d")) {
        transform.Rotate(0, 1.5f, 0);
      }
      if (Input.GetKey ("a")) {
        transform.Rotate(0, -1.5f, 0);
      }


  }


  public void LeftButton(){
    transform.Rotate(0, -1.5f, 0);
  }

  public void RightButton(){
    transform.Rotate(0, 1.5f, 0);
  }

  public void AttackButton(){
    if (!animator.GetCurrentAnimatorStateInfo(0).IsName("Attack1")) {
      animator.SetTrigger("isattack");
    }
  }


  public void DashOn(){animator.SetBool("isRunning", true);}
  public void DashOff(){animator.SetBool("isRunning", false);}

  public void DashButton(){
    nextPos = transform.position;
    //transform.position += transform.forward * 0.1f;
    float height = Terrain.activeTerrain.terrainData.GetInterpolatedHeight((transform.position.x+50)/Terrain.activeTerrain.terrainData.size.x, (transform.position.z+50)/Terrain.activeTerrain.terrainData.size.z);
    nextPos.y = height;
    //transform.position = nextPos;
    transform.position = nextPos;
    //if(isWalking == false){
    //  isWalking = true;

    //}
  }

}

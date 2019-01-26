using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSun : MonoBehaviour {

  Vector3 objectPos;
  float distance;


  public bool canHold = true;
  public GameObject sun;
  public GameObject tempParent;
  public bool isHolding = false;

  private Orbita orbita;

  void Awake(){
      orbita= sun.GetComponent<Orbita>();
  }


  void Update () {

    if (isHolding){
      orbita.angulo=0;
    }

  }


}

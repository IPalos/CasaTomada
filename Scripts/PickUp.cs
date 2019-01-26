using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour {

  float throwForce = 0;
  Vector3 objectPos;
  float distance;

  public bool canHold = true;
  public GameObject item;
  public GameObject tempParent;
  public bool isHolding = false;


  void Update () {

    distance = Vector3.Distance(item.transform.position, tempParent.transform.position);
    // Debug.Log(distance);
    // if (distance <= 5f && Input.GetAxis("Fire1")==1){
    if (Input.GetAxis("Fire1")==1){
      grab();
    }

    // if (distance > 5f){
    //   letGo();
    // }

    setDistance();

    if (isHolding== true){
      item.GetComponent<Rigidbody>().velocity = Vector3.zero;
      item.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
      item.transform.SetParent(tempParent.transform);

      if (Input.GetAxis("Fire2")==1){
        // throw();
        item.GetComponent<Rigidbody>().AddForce(tempParent.transform.forward * throwForce);
        isHolding = false;

      }
    }

    else{
      objectPos = item.transform.position;
      item.transform.SetParent(null);
      // item.GetComponent<Rigidbody>().useGravity = true;
      item.transform.position = objectPos;
    }



  }

  void grab(){
    isHolding = true;
    item.GetComponent<Rigidbody>().useGravity = false;
    item.GetComponent<Rigidbody>().detectCollisions = true;
  }

  // void throw(){
  //   item.GetComponent<Rigidbody>().AddForce(tempParent.transform.forward * throwForce);
  //   isHolding = false;
  // }

  void letGo(){
    isHolding = false;
  }


  void setDistance(){
    if (distance != 100){
      item.transform.position = (item.transform.position - tempParent.transform.position).normalized * distance + tempParent.transform.position;

    }
  }
  // void OnMouseDown(){
  //
  //   if (distance <= 5f and isHolding=false){
  //
  //
  //     isHolding = true;
  //     item.GetComponent<Rigidbody>().useGravity = false;
  //     item.GetComponent<Rigidbody>(). detectCollisions = true;
  //   }
  // }
  //
  // void OnMouseUp(){
  //   isHolding = false;
  //
  //
  // }

}

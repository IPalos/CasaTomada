using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectAstro : MonoBehaviour {

  float throwForce = 0;
  Vector3 objectPos;
  float distance;

  public bool canHold = false;
  public GameObject item;
  GameObject Astros;
  public GameObject tempParent;
  public bool isHolding = false;

  Camera cam;
  RaycastHit hit;
  int layerMask = ~(1<<8);

  void Start(){
      cam = GetComponent<Camera>();
      Astros=GameObject.Find("Astros");
      canHold = false;
  }

  void Update () {

    //click izq, toma. si no estas tomando  nada
    if (Input.GetAxis("Fire1")==1 && isHolding==false){
      canHold=pointRay();
    }

    if (canHold== true){
      Debug.Log(item.name);
      grab();

      if (Input.GetAxis("Fire2")==1){
        isHolding=false;
        canHold=false;
      }
      hold();
    }

  }

  void grab(){
    isHolding = true;
    item.GetComponent<Rigidbody>().useGravity = false;
    item.GetComponent<Rigidbody>().detectCollisions = true;
  }

  void letGo(){
    isHolding = false;
    item.GetComponent<Rigidbody>().useGravity = true;
  }

  float getDistance(){
    {
      distance = Vector3.Distance(item.transform.position, tempParent.transform.position);
      return distance;


    }
  }

  bool pointRay(){


      if (Physics.Raycast(transform.position + new Vector3(0f,.3f, 0f), transform.TransformDirection(Vector3.forward)*2, out hit, Mathf.Infinity, layerMask)){
        Debug.DrawRay(transform.position+ new Vector3(0f,.3f,0f), transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
        item =hit.collider.gameObject;
        Debug.Log(item.tag);
        if (item.tag=="Carriable" && getDistance()<=3){
          return true;
        }
        else if (item.tag =="Astro"){
          return true;
        }
        else{
          return false;
        }
      }

    else{
      Debug.DrawRay(transform.position+new Vector3(0f,.3f,0f), transform.TransformDirection(Vector3.forward) * 1000, Color.white);
      return false;
    }
  }

  void hold(){


    if (isHolding== true){
      item.GetComponent<Rigidbody>().velocity = Vector3.zero;
      item.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
      item.transform.SetParent(tempParent.transform);
      if (item.tag=="Carriable"){
        item.transform.position=tempParent.transform.position+(tempParent.transform.forward);
      }
      else if (item.tag == "Astro"){
        item.transform.position=tempParent.transform.position+(tempParent.transform.forward*getDistance());
      }


      if (Input.GetAxis("Fire2")==1){
        // throw();
        item.GetComponent<Rigidbody>().AddForce(tempParent.transform.forward * throwForce);
        isHolding = false;
        canHold=false;


      }
    }

    else{
      objectPos = item.transform.position;
      if (item.tag=="Carriable"){
        item.transform.SetParent(null);
      }
      else if (item.tag == "Astro"){
        item.transform.SetParent(Astros.transform);
      }
      // item.GetComponent<Rigidbody>().useGravity = true;
      item.transform.position = objectPos;
    }

  }

}

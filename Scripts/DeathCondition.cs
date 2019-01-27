using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathCondition : MonoBehaviour {

public Vector3 startpos;


void Start(){
	startpos = new Vector3 (2,0,-2);
}

void OnTriggerEnter(Collider other){
	if (other.name== "Olvido"){
		transform.position = startpos;
	}
}

}

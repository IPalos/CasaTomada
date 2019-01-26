using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckRay : MonoBehaviour {

	public int brillo = 0;

	// Update is called once per frame
	void Update () {
		if (brillo != 0){
			gameObject.GetComponent<Renderer> ().material.color = Color.red;
		}
		else{
			gameObject.GetComponent<Renderer>().material.color = Color.white;
		}
		brillo=0;

	}


}

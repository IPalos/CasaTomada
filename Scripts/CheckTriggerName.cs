using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckTriggerName : MonoBehaviour {



	public bool isInPosition;

	public GameObject playerCam;
	private SelectAstro astro;

	// Use this for initialization
	void Start () {

		playerCam = GameObject.Find("MainCamera");
		astro = playerCam.GetComponent<SelectAstro>();

		// puerta= GameObject.Find("Puerta");
		// rb=puerta.GetComponent<Rigidbody>();
		isInPosition = false;

	}

	// Update is called once per frame
	void Update () {

	}


	void OnTriggerEnter(Collider other){
		if (other.name.Contains(gameObject.name)){
			Debug.Log("It's In");
		}
	}

	void OnTriggerStay(Collider other){
		if (other.name.Contains(gameObject.name)){
			// rb.isKinematic = false;
			isInPosition = true;
			if (astro.isHolding == false){
				gameObject.transform.position = other.transform.position;
			}



		}
	}

	void OnTriggerExit( Collider other){
		if (other.name.Contains(gameObject.name)){
			// rb.isKinematic = true;
			isInPosition= false;
		}
	}


}

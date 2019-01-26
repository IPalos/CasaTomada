using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class persp : MonoBehaviour {

	private SelectAstro selectAstro;
	public GameObject player;

	private bool wiu;

	// Use this for initialization
	void Start () {
		selectAstro= player.GetComponent<SelectAstro>();
		wiu=false;
	}

	// Update is called once per frame
	void Update () {

		if (selectAstro.isHolding){

			if (selectAstro.item.name=="Sphere"){
				wiu=true;
				Debug.Log("wiu");
			}
		}

		if (wiu && (selectAstro.isHolding)==false){
			wiu=false;
			transform.position=transform.position+player.transform.forward*97f;
			Debug.Log(Vector3.Distance(player.transform.position,transform.position));
			gameObject.GetComponent<Rigidbody>().velocity=Vector3.zero;
			gameObject.GetComponent<Rigidbody>().angularVelocity=Vector3.zero;
			transform.localScale += new Vector3(33.3f,33.3f,33.3f);
		}

	}
}

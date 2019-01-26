using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbita : MonoBehaviour {

	[Range(-90,90)]
	public int angulo;
	float x;
	float y;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		float nangulo=angulo/60f;
		x=Mathf.Sin(nangulo)*100f;
		y=Mathf.Cos(nangulo)*100f;


		transform.position= new Vector3(x,y,0f);
	}


}

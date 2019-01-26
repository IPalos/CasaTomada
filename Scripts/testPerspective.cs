using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testPerspective : MonoBehaviour {

	float move=20f;
	public float sqmove;
	public float distRatio;
	public float originalDistance;
	float distance;
	public GameObject cam;

	// Use this for initialization
	void Start () {
		originalDistance= Vector3.Distance(cam.transform.position, transform.position);


	}

	// Update is called once per frame
	void Update () {

		distance=Vector3.Distance(cam.transform.position, transform.position);
		distRatio=Mathf.Sqrt(distance/originalDistance*move)*Time.deltaTime;
		transform.Translate(new Vector3(0,0,move*Time.deltaTime));
		transform.localScale += new Vector3(distRatio*Time.deltaTime,distRatio*Time.deltaTime,distRatio*Time.deltaTime);

	}
}

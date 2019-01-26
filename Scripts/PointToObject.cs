using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointToObject : MonoBehaviour {
public GameObject item;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		// transform.LookAt(item.transform.position);
		transform.LookAt(item.transform.position);
	}
}

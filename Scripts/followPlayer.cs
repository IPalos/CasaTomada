using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour {

	 public GameObject player;
	 Vector3 playerPos;
	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		playerPos=player.transform.position;
		transform.position= playerPos- new Vector3(0f,-6.2f,0f);

	}
}

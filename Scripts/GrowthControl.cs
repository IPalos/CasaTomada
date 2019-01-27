using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrowthControl : MonoBehaviour {

public float growthRate = 0f;
private float time;
public bool isCorrect = true;

	// Use this for initialization
	void Start () {
		growthRate = 0.3f;
		transform.position = new Vector3(1.32f,0,-9.1f);


	}

	// Update is called once per frame
	void Update () {
		time +=Time.deltaTime;
		transform.localScale = new Vector3(time*growthRate,time*growthRate,time*growthRate);
		if (isCorrect){
			reduceOlvido();
		}
	}

	public void setGrowthRate(float value){
		growthRate = value;
	}

	public void reduceOlvido(){
		time-=1f;
	}

}

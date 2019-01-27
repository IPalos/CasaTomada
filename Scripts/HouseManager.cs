using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseManager : MonoBehaviour {

public GameObject peluche;
public GameObject collar;
public GameObject cajamusical;

private CheckTriggerName Ppeluche;
private CheckTriggerName Pcollar;
private CheckTriggerName Pcajamusical;

public GameObject olvido;

public float growthRate = .3f;
private float time;
public bool isCorrect;

public Vector3 olvidoPos1;
public Vector3 olvidoPos2;
public Vector3 cajaPos;

private bool flag1 = true;
private bool flag2 = true;


	// Use this for initialization
	void Start () {

		Ppeluche =  peluche.GetComponent<CheckTriggerName>();
		Pcollar =  collar.GetComponent<CheckTriggerName>();
		Pcajamusical =  cajamusical.GetComponent<CheckTriggerName>();

		// olvido = this.gameObject.transform.GetChild(0);
	}

	// Update is called once per frame
	void Update () {
		// time +=Time.deltaTime;
		// transform.localScale= new Vector3(time*growthRate,time*growthRate,time*growthRate);
		transform.position=olvidoPos1;

		if (flag1){
			checkPeluche();
		}

		if (flag2){
			checkCollar();
		}

		if (Pcajamusical.isInPosition){
			Debug.Log("Win Condition Met");
		}

	}

	public void reduceOlvido(){
		time-=1f;
	}

	private void checkPeluche(){
		if (Ppeluche.isInPosition){
			Debug.Log("Peluche esta en su lugar");
			flag1=false;
			olvido.transform.position=new Vector3(-6.68f,-0.83f,2.72f);
			collar.transform.position = new Vector3(0,0,0);

		}
	}

	private void checkCollar(){
		if (Pcollar.isInPosition){
			flag2=false;
			cajamusical.transform.position = new Vector3 (2,2,2);
			olvido.transform.position = new Vector3(-10, -1, 4);
		}

	}

}

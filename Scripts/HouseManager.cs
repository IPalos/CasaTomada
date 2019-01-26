using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseManager : MonoBehaviour {


public GameObject puerta1;
public GameObject puerta2;
public GameObject puerta3;
public GameObject puerta4;
public GameObject puerta5;
public GameObject puerta6;
public GameObject puerta7;
public GameObject puerta8;

private Rigidbody rb1;
private Rigidbody rb2;
private Rigidbody rb3;
private Rigidbody rb4;
private Rigidbody rb5;
private Rigidbody rb6;
private Rigidbody rb7;
private Rigidbody rb8;

public GameObject peluche;
public GameObject collar;
public GameObject mandil;
public GameObject sweater;
public GameObject cajamusical;
public GameObject pelota;
public GameObject pescadito;
public GameObject cinturon;
public GameObject dibujo;
public GameObject trofeo;
public GameObject jmesa;
public GameObject flauta;
public GameObject anillo;
public GameObject cama;
public GameObject yeso;
public GameObject plato;
public GameObject portafolio;
public GameObject pastillas;
public GameObject silla;
public GameObject cuadro;

private CheckTriggerName Ppeluche;
private CheckTriggerName Pcollar;
private CheckTriggerName Pmandil;
private CheckTriggerName Psweater;
private CheckTriggerName Pcajamusical;
private CheckTriggerName Ppelota;
private CheckTriggerName Ppescadito;
private CheckTriggerName Pcinturon;
private CheckTriggerName Pdibujo;
private CheckTriggerName Ptrofeo;
private CheckTriggerName Pjmesa;
private CheckTriggerName Pflauta;
private CheckTriggerName Panillo;
private CheckTriggerName Pcama;
private CheckTriggerName Pyeso;
private CheckTriggerName Pplato;
private CheckTriggerName Pportafolio;
private CheckTriggerName Ppastillas;
private CheckTriggerName Psilla;
private CheckTriggerName Pcuadro;


	// Use this for initialization
	void Start () {
		// puerta1 = GameObject.Find("Puerta1")

		

		Ppeluche =  peluche.GetComponent<CheckTriggerName>();
		Pcollar =  collar.GetComponent<CheckTriggerName>();
		Pmandil =  mandil.GetComponent<CheckTriggerName>();
		Psweater =  sweater.GetComponent<CheckTriggerName>();
		Pcajamusical =  cajamusical.GetComponent<CheckTriggerName>();
		Ppelota =  pelota.GetComponent<CheckTriggerName>();
		Ppescadito =  pescadito.GetComponent<CheckTriggerName>();
		Pcinturon =  cinturon.GetComponent<CheckTriggerName>();
		Pdibujo =  dibujo.GetComponent<CheckTriggerName>();
		Ptrofeo =  trofeo.GetComponent<CheckTriggerName>();
		Pjmesa =  jmesa.GetComponent<CheckTriggerName>();
		Pflauta =  flauta.GetComponent<CheckTriggerName>();
		Panillo =  anillo.GetComponent<CheckTriggerName>();
		Pcama =  cama.GetComponent<CheckTriggerName>();
		Pyeso =  yeso.GetComponent<CheckTriggerName>();
		Pplato =  plato.GetComponent<CheckTriggerName>();
		Pportafolio =  portafolio.GetComponent<CheckTriggerName>();
		Ppastillas =  pastillas.GetComponent<CheckTriggerName>();
		Psilla =  silla.GetComponent<CheckTriggerName>();
		Pcuadro =  cuadro.GetComponent<CheckTriggerName>();

		rb1=puerta1.GetComponent<Rigidbody>();
		rb2=puerta2.GetComponent<Rigidbody>();
		rb3=puerta3.GetComponent<Rigidbody>();
		rb4=puerta4.GetComponent<Rigidbody>();
		rb5=puerta5.GetComponent<Rigidbody>();
		rb6=puerta6.GetComponent<Rigidbody>();
		rb7=puerta7.GetComponent<Rigidbody>();
		rb8=puerta8.GetComponent<Rigidbody>();

		rb1.isKinematic= true;
		rb2.isKinematic= true;
		rb3.isKinematic= true;
		rb4.isKinematic= true;
		rb5.isKinematic= true;
		rb6.isKinematic= true;
		rb7.isKinematic= true;
		rb8.isKinematic= true;


	}

	// Update is called once per frame
	void Update () {

		if (Psweater.isInPosition && Pcajamusical.isInPosition){
			rb1.isKinematic= false;
		}


	}

	void SnapObject(){

	}



}

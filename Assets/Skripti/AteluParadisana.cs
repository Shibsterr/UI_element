using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AteluParadisana : MonoBehaviour {
    public GameObject bins;
    public GameObject lacis;
    public GameObject masina;
    public GameObject tante;
    public GameObject paKreisi;
    public GameObject paLabi;
	public GameObject kurRadit;
	public Sprite[] koRadit;
	public GameObject slaideris1;
	public GameObject slaideris2;


    public void binaAttelosana(bool vertiba)
    {
        bins.SetActive(vertiba);
        paKreisi.GetComponent<Toggle>().interactable = vertiba;
        paLabi.GetComponent<Toggle>().interactable = vertiba;
    }

    public void lacaAttelosana(bool vertiba)
    {
        lacis.SetActive(vertiba);
    }

    public void masinaAttelosana(bool vertiba)
    {
        masina.SetActive(vertiba);
    }

    public void tanteAttelosana(bool vertiba)
    {
        tante.SetActive(vertiba);
    }

    public void paKreisiBins()
    {
        bins.transform.localScale = new Vector2 (1, 1);
    }
    public void paLabiBins()
    {
        bins.transform.localScale = new Vector2(-1, 1);
    }

	public void izkritosais(int indekss){
		if (indekss == 0)
			kurRadit.GetComponent<Image> ().sprite = koRadit [0];
		else if(indekss == 1)
			kurRadit.GetComponent<Image> ().sprite = koRadit [1];
		else if(indekss == 2)
			kurRadit.GetComponent<Image> ().sprite = koRadit [2];
	}

	public void mainitielumu(){
		float pasreizejaVertiba = slaideris1.GetComponent<Slider> ().value;
		kurRadit.transform.localScale = new Vector2 (1f*pasreizejaVertiba, 1f*pasreizejaVertiba);
	}

	public void mainitRotaciju(){
		float pasreizejaVertiba = slaideris2.GetComponent<Slider> ().value;
		kurRadit.transform.localRotation = Quaternion.Euler (0, 0, pasreizejaVertiba * 360);

	}
}

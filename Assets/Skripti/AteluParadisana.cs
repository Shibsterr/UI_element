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

}

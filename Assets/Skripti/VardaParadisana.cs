using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//nepiecasams lai stradut ar UI elementiem
using UnityEngine.UI;

public class VardaParadisana : MonoBehaviour {
	/*int kadri = 0;

	// Use this for initialization
	void Start () {
		Debug.Log ("Programma tika starteta!");	
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log ("Kadrs: " + kadri);
		kadri++;

		if (kadri == 10) {
			Debug.Log ("Tu sasniedzi 10. kadru!");
		}
	}*/

	//Mainígais kura uzlgabás tekstu no input field
	private string teksts;
	//Lauks, kura ievada tekstu
	public GameObject ievadesLauks;
	//text objekts, kura attelos tekstu pec pogas nnospiesanas
	public GameObject TekstaLauks1;
	//masivs ar iespejamajiem teksta sakumiem
	private string[] varianti = 
	{"Sveiki ","Labdien ","Prieks tevi redzet ","Uzredzesanos "};
	//mainigais uzglabas random skaiti
	int nejausais;

	public void NolasitTekstu(){
		teksts = ievadesLauks.GetComponent<Text>().text;
		nejausais = Random.Range (0, varianti.Length);
		TekstaLauks1.GetComponent<Text>().text = varianti[nejausais]+teksts.ToUpper()+"!";
	}
}

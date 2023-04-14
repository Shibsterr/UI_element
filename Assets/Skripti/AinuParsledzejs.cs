using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Importé lai varetu veikt ainu ieladi
using UnityEngine.SceneManagement;

public class AinuParsledzejs : MonoBehaviour {
	public void UzSakumu(){
		SceneManager.LoadScene (0, LoadSceneMode.Single);		//vari ari ainas nosaukumu	samainot 0 uz ta vardu	
	}

	public void UzUI(){
		SceneManager.LoadScene(1, LoadSceneMode.Single);
	}

	public void Apturet()
	{
		Application.Quit ();
	}
}

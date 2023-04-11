using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Importé lai varetu veikt ainu ieladi
using UnityEngine.SceneManagement;

public class AinuParsledzejs : MonoBehaviour {
	public void UzSakumu(){
		SceneManager.LoadScene (0, LoadSceneMode.Single);		//vari ari ainas nosaukumu		
	}

}

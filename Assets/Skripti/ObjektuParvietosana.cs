using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ObjektuParvietosana : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IDragHandler, IEndDragHandler {
	private RectTransform transformacijasLogs;
	public Canvas kanva;


	void Start () {
		transformacijasLogs = GetComponent<RectTransform> ();
	}
	public void OnPointerDown(PointerEventData notikums){
		Debug.Log ("No kliskinats objekts!");
	}

	public void OnBeginDrag(PointerEventData notikums){
		Debug.Log ("Uzsakta objekta vilksana!");
	}

	public void OnDrag(PointerEventData notikums){
		Debug.Log ("Notiek objekta vilksana!");
		transformacijasLogs.anchoredPosition += notikums.delta / kanva.scaleFactor;
	}

	public void OnEndDrag(PointerEventData notikums){
		Debug.Log ("Objekta vilksana ir partraukta!");
	}
}

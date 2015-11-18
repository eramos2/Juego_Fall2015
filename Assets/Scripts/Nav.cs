using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Nav : MonoBehaviour {
	
	public string siguiente;
	public bool clickedOn = false;

	// Use this for initialization
	void Start () {
	}
	
	void FixedUpdate () {
		
		if (clickedOn) {
			Application.LoadLevel(siguiente);
		}  
	}

	void OnMouseDown () {  
		clickedOn = true;
	}
	void OnMouseUp () {
		clickedOn = false;
	}
}

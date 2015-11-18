using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
	
	public void ChangeToScene (string changeScene)
	{
		Application.LoadLevel (changeScene);
	}

	public void SetName (string name) {

		PlayerPrefs.SetString("PlayerName", name);
	}
}

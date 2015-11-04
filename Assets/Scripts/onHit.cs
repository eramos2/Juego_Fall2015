using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class onHit : MonoBehaviour {

	public Text clickedText;   //texto del UI
	public AudioSource audio; //Para accesar el audio del source
	public string clicked;  //string que representa si le dieron click o no
	public bool clickedOn = false; //para saber cuando hacen click en el objeto

	// Use this for initialization
	void Start () {
		//rb = GetComponent<Rigidbody> ();
		//audio = GetComponent<AudioSource>();  // inicializando el audio del objeto
		clicked = "Off";  //inicializarlo en off hasta que le den click al objeto
		SetClickedText ();   //Setiar el texto en el UI
		//winText.text = "";
		//letter = word.ToCharArray(); // creates array of char from word
	}

	void FixedUpdate () {

		if (clickedOn) {
			clicked = "On";        //cambiar el string a On
			audio.Play();   //Sonar el audio con delay
		} else 
			clicked = "Off";    //cambiar string a off
		SetClickedText();       // Cambiar el texto del UI
		 
}

	void OnMouseDown () {  
		clickedOn = true;
	}
	void OnMouseUp () {
		clickedOn = false;
	}
	void SetClickedText ()
	{
		clickedText.text = "Clicked: " + clicked.ToString ();
	//	if (count >= 12) 
		//{
		//	winText.text = "You Win!";
		//}
		
	}

}
	/**
	// Update is called once per frame
	void FixedUpdate () {
	
		void OnMouseDown () {
			clickedOn = true;
	}
		void OnMouseUp () {
		clickedOn = false;
	}
		//checks if space was pressed an adds to jump
		if (Input.GetKeyDown (KeyCode.Space) == true && jump<=0.0f) {
			jump += 10.0f;
			//jumpPressed = false;
		}

}

	void SetCountText ()
	{
		countText.text = "Count: " + count.ToString ();
		if (count >= 12) 
		{
			winText.text = "You Win!";
		}
		
	}

	void OnTriggerEnter(Collider other)
	{
		//checks that the current letter is hit and sets to inactive also adds count
		if (other.gameObject.CompareTag (""+letter[count])) 
		{
			other.gameObject.SetActive (false);
			
			count = count + 1;
			SetCountText ();
		}
	}
}*/

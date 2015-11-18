using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class PlayerController : MonoBehaviour
{
    public Text countText, winText, targetText, playerScore, lifes;
    public string temp;
    public int count, tries;
    public AudioSource correct, wrong;

   void Start()
    {
		//playerScore = GetComponent<Text> ();
        count = 0;
		tries = 10;
        temp = "";
        setCountText();
        winText.text = temp; //en Unityel default esta en blanco!
     
    }

    private string randomizer()
    {
        List<string> list = new List<string>();
        list.Add("Mesa");
        list.Add("Silla");
        list.Add("Sofa");

       
        int value = (int)Random.Range(1, 4);
        Debug.Log("Random Value: " + value);
        string target = "";

        if (value == 1)
        {
            target = "Mesa";
        }
        else if (value == 2)
          {
            target = "Silla";
        }
        else if (value == 3)
        {
            target = "Sofa";
        }

        return target;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction);
            RaycastHit hitInfo = new RaycastHit();

            if (hit)
            {
                if (hit.transform.gameObject.tag == "Silla")
                {
                    Debug.Log("Button Activated"); //need a delay or something for only once
                    correct.Play();
                    count += 1;
                    setCountText();
                    //randomizer();
                }
				//if (hit)
				//{
				//	Debug.Log(hit.transform.gameObject.tag); //need a delay or something for only once
					//correct.Play();
				//	count += 1;
				//	setCountText();
					//randomizer();
				//}
				if (hit.transform.gameObject.tag == "Area1")
				{
					Debug.Log("Button Activated"); //need a delay or something for only once
					Application.LoadLevel("insideArea1");
				}
				if (hit.transform.gameObject.tag == "Area2")
				{
					Debug.Log("Button Activated"); //need a delay or something for only once
					Application.LoadLevel("insideArea2");
				}
				if (hit.transform.gameObject.tag == "Area3")
				{
					Debug.Log("Button Activated"); //need a delay or something for only once
					Application.LoadLevel("insideArea3");
				}
				if (hit.transform.gameObject.tag == "Area4")
				{
					Debug.Log("Button Activated"); //need a delay or something for only once
					Application.LoadLevel("insideArea4");
				}
				if (hit.transform.gameObject.tag == "Back")
				{
					Debug.Log("Button Activated"); //need a delay or something for only once
					Application.LoadLevel("stages");
				}
                else
                {

                    wrong.Play();
					tries--;
					setCountText();
					Debug.Log("Tag selected: " + hit.transform.gameObject.tag);
                }
            }
        }
    }


    void setCountText()
    {
		PlayerPrefs.SetInt ("TotalScore", count);
		playerScore.text = "Score: "+ (PlayerPrefs.GetInt ("TotalScore")).ToString ();
		PlayerPrefs.SetInt ("TotalLifes", tries);
		lifes.text = "Lifes: " + (PlayerPrefs.GetInt ("TotalLifes")).ToString ();
        countText.text = "Count: " + count.ToString();
        //temp = randomizer();
        //targetText.text = temp;

        if (count == 12)
        {
            //winText.text = "Win text";

        }
    }
}

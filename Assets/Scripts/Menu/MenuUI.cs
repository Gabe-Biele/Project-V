using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuUI : MonoBehaviour
{

	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    public void ButtonClicked(Button clickedButton)
    {
        if(clickedButton.name == "StartButton")
        {
            SceneManager.LoadScene("DemoScene");
        }

        if(clickedButton.name == "LoadButton")
        {

        }

        if(clickedButton.name == "ExitButton")
        {
            Application.Quit();
        }
    }
}

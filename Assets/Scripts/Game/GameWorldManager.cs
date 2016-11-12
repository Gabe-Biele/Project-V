using UnityEngine;
using System.Collections;

public class GameWorldManager : MonoBehaviour
{
    private PlayerController ourPlayerController; 

	// Use this for initialization
	void Start ()
    {
        ourPlayerController = GameObject.Find("Player").GetComponent<PlayerController>();
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    public PlayerController GetPlayerController()
    {
        return ourPlayerController;
    }
}

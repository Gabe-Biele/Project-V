using UnityEngine;
using System.Collections;

public class InputController : MonoBehaviour
{
    private GameWorldManager ourGWM;

    private KeyCode jumpKey;
    private KeyCode crouchKey;
    private KeyCode forwardKey;
    private KeyCode backwardKey;

	// Use this for initialization
	void Start ()
    {
        ourGWM = GameObject.Find("SceneScriptsObject").GetComponent<GameWorldManager>();

        jumpKey = KeyCode.W;
        crouchKey = KeyCode.S;
        forwardKey = KeyCode.D;
        backwardKey = KeyCode.A;
	}
	
	// Update is called once per frame
	void Update ()
    {
	    if(Input.GetKeyDown(jumpKey))
        {
            ourGWM.GetPlayerController().Jump();
        }
        if(Input.GetKey(crouchKey))
        {

        }
        if(Input.GetKey(forwardKey))
        {
            ourGWM.GetPlayerController().MoveForward();
        }
        if(Input.GetKey(backwardKey))
        {
            ourGWM.GetPlayerController().MoveBackward();
        }
    }
}

using UnityEngine;
using System.Collections;

public class TurnTrigger : MonoBehaviour
{
    private bool firstEntry = true;
    private bool pastTrigger = false;
    private float currXOffset;
    private float currYOffset;
    private float currZOffset;
    private float turnDegrees;

    public bool IsLeftTurn;
    public string DirectionTo;  // North - East - South - West

    void Start()
    {
        if(IsLeftTurn)
        {
            turnDegrees = -90;
        }
        else
        {
            turnDegrees = 90;
        }
    }
    void OnTriggerEnter(Collider objectCollider)
    {
        CameraController cameraController = Camera.main.GetComponent<CameraController>();
        Transform playerTF = GameObject.Find("Player").transform;

        if(firstEntry)
        {
            currXOffset = cameraController.xOffset;
            currYOffset = cameraController.yOffset;
            currZOffset = cameraController.zOffset;
            firstEntry = false;
        }

        if(!pastTrigger)
        {
            playerTF.RotateAround(playerTF.position, Vector3.up, turnDegrees);

            if(DirectionTo == "North")
            {
                cameraController.xOffset = 0;
                cameraController.yOffset = 2.5f;
                cameraController.zOffset = -5;
            }

            if(DirectionTo == "East")
            {
                cameraController.xOffset = -5;
                cameraController.yOffset = 2.5f;
                cameraController.zOffset = 0;
            }

            if(DirectionTo == "South")
            {
                cameraController.xOffset = 0;
                cameraController.yOffset = 2.5f;
                cameraController.zOffset = 5;
            }

            if(DirectionTo == "West")
            {
                cameraController.xOffset = 5;
                cameraController.yOffset = 2.5f;
                cameraController.zOffset = 0;
            }

            pastTrigger = true;
        }


        else if(pastTrigger)
        {
            playerTF.RotateAround(playerTF.position, Vector3.up, -turnDegrees);

            cameraController.xOffset = currXOffset;
            cameraController.yOffset = currYOffset;
            cameraController.zOffset = currZOffset;

            pastTrigger = false;
        }
    }
}

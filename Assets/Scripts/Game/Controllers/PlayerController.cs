using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{ 
    private Rigidbody playerRB;
    private Transform playerMeshTF;

    private int playerSpeed = 8;
    private int playerJump = 10;

    private bool facingRight = true;

    // Use this for initialization
    void Start ()
    {
        playerRB = this.transform.GetComponentInChildren<Rigidbody>();
        playerMeshTF = GameObject.Find("PlayerMesh").transform;
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    public void Jump()
    {
        playerRB.AddForce(Vector3.up * playerJump, ForceMode.Impulse);
    }
    public void MoveForward()
    {
        if(!facingRight)
        {
            this.transform.RotateAround(this.transform.position, Vector3.up, 180);
        }
        facingRight = true;

        this.transform.Translate(Vector3.forward * Time.deltaTime * playerSpeed);

    }
    public void MoveBackward()
    {
        if(facingRight)
        {
            this.transform.RotateAround(this.transform.position, Vector3.up, 180);
        }
        facingRight = false;

        this.transform.Translate(Vector3.forward * Time.deltaTime * playerSpeed);
    }
}

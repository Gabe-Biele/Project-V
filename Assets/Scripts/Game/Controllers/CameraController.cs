using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{
    public Transform cameraTarget;
    private int cameraSpeed = 10;

    public float xOffset;
    public float yOffset;
    public float zOffset;

    // Use this for initialization
    void Start ()
    {
        xOffset = 0;
        yOffset = 2.5f;
        zOffset = -5;
        cameraTarget = GameObject.Find("PlayerMesh").transform;
	}
	
	// Update is called once per frame
	void LateUpdate ()
    {
        this.transform.position = Vector3.Lerp(this.transform.position, new Vector3(cameraTarget.position.x + xOffset, cameraTarget.position.y + yOffset, cameraTarget.position.z + zOffset), 0.125f);
        this.transform.LookAt(cameraTarget);
    }
}

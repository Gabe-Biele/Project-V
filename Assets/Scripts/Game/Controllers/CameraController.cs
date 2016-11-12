using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{
    public Transform cameraTarget;
    public Vector3 currentCameraTarget;

    public float xOffset;
    public float yOffset;
    public float zOffset;

    // Use this for initialization
    void Start ()
    {
        xOffset = 0;
        yOffset = 2f;
        zOffset = -7;
        cameraTarget = GameObject.Find("CameraTarget").transform;
	}
	
	// Update is called once per frame
	void LateUpdate ()
    {
        currentCameraTarget = Vector3.Lerp(currentCameraTarget, cameraTarget.position, 0.05f);
        this.transform.position = Vector3.Lerp(this.transform.position, new Vector3(cameraTarget.position.x + xOffset, cameraTarget.position.y + yOffset, cameraTarget.position.z + zOffset), 0.05F);
        this.transform.LookAt(currentCameraTarget);
    }
}

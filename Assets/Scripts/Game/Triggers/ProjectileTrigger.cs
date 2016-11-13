using UnityEngine;
using System.Collections;

public class ProjectileTrigger : MonoBehaviour
{
    private bool inField = false;
    private float secondsLeft;
    private Transform playerTF;

    public float SecondsPerProjectile;
    public float ProjectileForce;
    public GameObject ProjectileObject;
    public GameObject ProjectileSource;


	// Use this for initialization
	void Start ()
    {
        playerTF = GameObject.Find("Player").transform;
    }

    void OnTriggerEnter(Collider objectCollider)
    {
        if(objectCollider == playerTF.GetComponentInChildren<MeshCollider>())
        {
            inField = true;
        }
    }

    void OnTriggerExit(Collider objectCollider)
    {
        if(objectCollider == playerTF.GetComponentInChildren<MeshCollider>())
        {
            inField = false;
        }
    }


    // Update is called once per frame
    void FixedUpdate ()
    {
	    if(inField)
        {
            secondsLeft = secondsLeft - Time.deltaTime;
            if(secondsLeft <= 0)
            {
                secondsLeft = SecondsPerProjectile;
                GameObject aProjectile = (GameObject)Instantiate(ProjectileObject);
                aProjectile.transform.position = ProjectileSource.transform.position;
                aProjectile.GetComponent<Rigidbody>().AddForce(((Vector3)(playerTF.position - aProjectile.transform.position)).normalized * ProjectileForce);
            }
        }
	}
}

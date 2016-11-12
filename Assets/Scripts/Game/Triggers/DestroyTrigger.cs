using UnityEngine;
using System.Collections;
using System.Timers;

public class DestroyTrigger : MonoBehaviour
{
    private Timer aTimer;

    public GameObject ObjectToDestroy;
    public float Milliseconds;

    void OnTriggerEnter(Collider objectCollider)
    {
        GameObject.Destroy(ObjectToDestroy, Milliseconds);
    }
}

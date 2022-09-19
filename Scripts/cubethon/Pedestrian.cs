using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pedestrian : MonoBehaviour
{
    public Rigidbody rb;

    void OnCollisionEnter (Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Player")
        {
            gameObject.GetComponent<Animator>().enabled = false;
            rb.AddForce(5f, 2f, 0);
        }
    }
}

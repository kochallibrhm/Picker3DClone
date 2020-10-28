using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pCollision : MonoBehaviour
{

    public GameObject picker;
    public GameObject tpOut;

    //Detecting obstacles
    public void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacles")
        {
            FindObjectOfType<GameManager>().restart();

            Debug.Log("ÇALIŞTI");
        }

        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Teleport"))
        {
            Debug.Log("Trigger");
            transform.position = tpOut.transform.position;
        }
    }
}

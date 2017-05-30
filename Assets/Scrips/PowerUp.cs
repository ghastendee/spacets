using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{


    public float tumble;
    public float speed;
    new Vector3 v;
    new Vector3 r;
    

    private void Start()

   

    {

        v = new Vector3(0, 0, -1);
        r = new Vector3(0, 1, 0);
        GetComponent<Rigidbody>().angularVelocity = r * tumble;
        GetComponent<Rigidbody>().velocity = v * speed;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Destroy(gameObject);
            other.GetComponent<WeaponSystem>().MainPowerup();
        }
    }
    private void OnTriggerExit(Collider other2)
    {
        if (other2.tag == "Boundary")
        {
            Destroy(gameObject);

        }
    }
}



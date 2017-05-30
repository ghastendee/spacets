using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRotator : MonoBehaviour {

    public float tumble;
    public float speed;
    new Vector3 v;
    new Vector3 s;
    public float stor;
    public float liten;
    private void Start()
    {
        
        v = new Vector3(Random.Range(-0.5f,0.5f), 0.0f, Random.Range(-3, -6));
        float size = Random.Range(liten, stor);
        s = new Vector3(size, size, size);
        GetComponent<Transform>().localScale = s;
        GetComponent<Rigidbody>().angularVelocity = Random.insideUnitSphere * tumble / ((GetComponent<Transform>().localScale.x)* (GetComponent<Transform>().localScale.x));
        GetComponent<Rigidbody>().velocity = v * speed/ (GetComponent<Transform>().localScale.x);
    }

}

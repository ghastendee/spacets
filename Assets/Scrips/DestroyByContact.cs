using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour {

    public GameObject explosion;
    public GameObject playerExplosion;
    public float lifePerSize;
    private float hp;
    public float R, G, B;
    private float r, g, b;
    

    void Start()
    {

        hp = lifePerSize* (GetComponent<Transform>().localScale.x);


    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Boundary" || other.tag == "Rock")
        {
            return;
        }
        if (other.tag == "Shot1")
        {
            hp=hp-1;
            Destroy(other.gameObject);
            Renderer rend = GetComponent<Renderer>();
            r = R;
            g = G;
            b = B;
            rend.material.SetColor("_EmissionColor", Color.HSVToRGB(r, g, b));
        }
        
        if (other.tag == "Player")
        { Instantiate(playerExplosion, other.transform.position, other.transform.rotation);
            Destroy(other.gameObject);

        }
        
     
        
        
    }

    private void OnTriggerExit(Collider other2)
    {
        if (other2.tag == "Boundary")
        {
            Destroy(gameObject);

        }
    }

    private void FixedUpdate()
    {
        b = b / (1.1f);
        Renderer rend = GetComponent<Renderer>();
        rend.material.SetColor("_EmissionColor", Color.HSVToRGB(r, g, b));

        if (hp <=0)
        {
            Destroy(gameObject);
            GameObject explosions = Instantiate(explosion, transform.position, transform.rotation);


        }
    }

}

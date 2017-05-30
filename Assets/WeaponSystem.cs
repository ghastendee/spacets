using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSystem : MonoBehaviour {

    public GameObject shot;
    public Transform shotSpawn;
    public float fireRate;
    public int startLevelMain;

    private float nextFire;
    private float myTime;
    private int MainLvl;
    private float MainFireRate;

    Vector3 side = new Vector3(0.1f, 0, 0);

    public void Start()
    {
        MainLvl = startLevelMain;
        MainFireRate = fireRate;
    }

    public void MainPowerup()
    {
        MainLvl=MainLvl+1;
    }

    void Update()
    {
        if (MainLvl == 1) //one laser
            {
            if (Input.GetButton("Jump") && Time.time > nextFire)
            {
                GameObject shots1 = Instantiate(shot);
                //shots1.GetComponentsInChildren<Renderer>().material.color = Color.blue;
                nextFire = Time.time + MainFireRate;
                shots1.transform.position = shotSpawn.transform.position;

            }
        }

        if (MainLvl == 2) //two laser
        {
            if (Input.GetButton("Jump") && Time.time > nextFire)
            {
                
                GameObject shots2 = Instantiate(shot);
                GameObject shots3 = Instantiate(shot);
                nextFire = Time.time + MainFireRate;
                MainFireRate = fireRate * (1.5f);
                shots2.transform.position = shotSpawn.transform.position + side;
                shots3.transform.position = shotSpawn.transform.position - side;

            }
        }

        if (MainLvl == 3) //two fast lasers
        {
            if (Input.GetButton("Jump") && Time.time > nextFire)
            {

                GameObject shots2 = Instantiate(shot);
                GameObject shots3 = Instantiate(shot);
                MainFireRate = fireRate * (0.75f);
                nextFire = Time.time + MainFireRate;

                shots2.transform.position = shotSpawn.transform.position + side;
                shots3.transform.position = shotSpawn.transform.position - side;

            }
        }
    }
}

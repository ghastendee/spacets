﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour {

    public GameObject hazard;
    public Vector3 spawnValues;
    public float spawnWait;
    public float startWait;
    public float waveWait;
    public int hazardIncrease;
    public int hazardCount;
    private int p=0;
    void Start()
    {
        StartCoroutine (spawnWaves());
    }
    IEnumerator spawnWaves ()
    {
        yield return new WaitForSeconds (startWait);
        while (true) { 
            for (int i = 0; i < hazardCount+hazardIncrease*p; i++)
            {
                Vector3 spawnPosition = new Vector3 (Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
                Quaternion spawnRotation = Quaternion.identity;
                Instantiate(hazard, spawnPosition, spawnRotation);
                yield return new WaitForSeconds(spawnWait);
            }
            yield return new WaitForSeconds(waveWait);
            p = p + 1;
        }
    }
}
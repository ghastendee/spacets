using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Size : MonoBehaviour {
    private void Awake()
    {
        Vector3 size = new Vector3(1,1,5);
        GetComponent<Transform>().localScale = size;
    }

}

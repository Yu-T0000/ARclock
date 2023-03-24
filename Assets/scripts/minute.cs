using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minute : MonoBehaviour
{
  float z;

    // Start is called before the first frame update
    void Start()
    {
        z = DateTime.Now.Minute*6.0f;
        transform.Rotate(new Vector3(0,0,-z));
    }

    // Update is called once per frame
    void Update()
    {

        transform.Rotate(new Vector3(0,0,-6.0f * Time.deltaTime/60f));
        
    }
}

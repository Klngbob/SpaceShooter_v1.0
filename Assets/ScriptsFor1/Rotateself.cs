using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotateself : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //this.transform.Rotate(Vector3.up * 5f);
        this.transform.Rotate(Vector3.down * 1.1f);
    }
}

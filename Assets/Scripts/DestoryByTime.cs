using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryByTime : MonoBehaviour
{
    public float liftTime = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, liftTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

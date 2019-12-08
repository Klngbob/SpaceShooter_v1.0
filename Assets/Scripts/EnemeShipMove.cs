using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemeShipMove : MonoBehaviour
{
    public float shipSpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody>().velocity = new Vector3(Random.Range(-6f,6f),0f,-shipSpeed);
    }
}

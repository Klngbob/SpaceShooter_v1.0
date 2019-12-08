using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
   // private GameController mygameController;
    public float speed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        //mygameController = GameObject.Find("GameController").GetComponent<GameController>();
        GetComponent<Rigidbody>().velocity = Vector3.forward * speed;
    }


    // Update is called once per frame
    void Update()
    {

    }
}

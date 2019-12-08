using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryBycontactEnemy : MonoBehaviour
{
    public GameObject playerexplosion;
    private GameController myGameController;
    // Start is called before the first frame update
    void Start()
    {
        myGameController = GameObject.Find("GameController").GetComponent<GameController>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "myBoundary")
        {
            return;
        }
        if (other.tag != "asteriod")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
        if (other.tag == "player")
        {
            //print("hahah");
            Instantiate(playerexplosion, transform.position, transform.rotation);
            myGameController.GameOverProc();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

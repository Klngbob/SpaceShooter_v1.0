using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryByContact : MonoBehaviour
{
    public GameObject explosion;
    public GameObject playerexplosion;
    private GameController myGameController;

    private void Start()
    {
        myGameController = GameObject.Find("GameController").GetComponent<GameController>();
    }


    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "myBoundary")
        {
            return;
        }
        //print("我是");
        Destroy(other.gameObject);
        Destroy(gameObject);
        //成绩处理
        myGameController.AddScore(10);
        myGameController.AddLevel();
        //爆炸效果
        Instantiate(explosion, transform.position, transform.rotation);//陨石
        if(other.tag == "player")
        {
            Instantiate(playerexplosion, transform.position, transform.rotation);
            myGameController.GameOverProc();
        }
    }
}

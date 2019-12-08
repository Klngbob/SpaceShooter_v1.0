using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyshipControll : MonoBehaviour
{
    public GameObject bullet;//子弹预设
    public Transform firePosition;//发射子弹位置
    public float firerate = 0.2f;//子弹发射间隔
    private float shottime;//
    // Start is called before the first frame update
    void Start()
    {
        shottime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > shottime)
        {
            GameObject clone = Instantiate(bullet);
            clone.transform.position = firePosition.position;
            shottime = Time.time + firerate;
            GetComponent<AudioSource>().Play();
        }
    }
}

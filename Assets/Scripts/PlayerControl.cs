using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Boundary
{
    public float xMin, xMax, zMin, zMax;
}
public class PlayerControl : MonoBehaviour
{
    private GameController mygameController;
    public GameObject bulletPrefab;//子弹的预设
    public GameObject bombPrefab;//炮弹预设
    public Transform FirePosition;//子弹初始位置
    public Transform FirePosition1;//第一阶段升级的第二个子弹位置
    //public Transform FirePosition2;
    //public Transform FirePosition3;
    //public Transform FirePosition4;
    private Rigidbody rb;
    public float moveSpeed = 10f;
    public Boundary myBoundary;
    public float tilt = 40f;
    public float firerate = 0.2f;//子弹发射间隔
    private float shottime;//
    // Start is called before the first frame update
    void Start()
    {
        mygameController = GameObject.Find("GameController").GetComponent<GameController>();
        rb = GetComponent<Rigidbody>();
        shottime = 0;
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetButton("Fire1") && (Time.time > shottime))
        {
            if (mygameController.myLevel < 3)
            {
                GameObject clone = Instantiate(bulletPrefab);
                clone.transform.position = FirePosition.position;
            }
            else if (mygameController.myLevel < 6)
            {
                //第一颗子弹
                GameObject clone = Instantiate(bulletPrefab);
                clone.transform.position = FirePosition.position;
                //第二颗子弹
                GameObject clone1 = Instantiate(bulletPrefab);
                clone1.transform.position = FirePosition1.position;
            }
            else
            {
                //第一颗子弹
                GameObject clone = Instantiate(bombPrefab);
                clone.transform.position = FirePosition.position;
                ////第二颗子弹
                //GameObject clone1 = Instantiate(bombPrefab);
                //clone1.transform.position = FirePosition1.position;
                ////第一颗子弹
                //GameObject clone2 = Instantiate(bombPrefab);
                //clone2.transform.position = FirePosition2.position;
                ////第二颗子弹
                //GameObject clone3 = Instantiate(bombPrefab);
                //clone3.transform.position = FirePosition3.position;
                //GameObject clone4 = Instantiate(bombPrefab);
                //clone4.transform.position = FirePosition4.position;
            }
            shottime = Time.time + firerate;
            GetComponent<AudioSource>().Play();

        }
    }
    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 moveDirection = new Vector3(moveHorizontal, 0f, moveVertical);//可以同时进行前进和转向

        rb.transform.position = new Vector3(
            Mathf.Clamp(rb.transform.position.x, myBoundary.xMin, myBoundary.xMax),
            0f,
            Mathf.Clamp(rb.transform.position.z, myBoundary.zMin, myBoundary.zMax));

        rb.velocity = moveDirection * moveSpeed;
        rb.transform.rotation = Quaternion.Euler(0f, 0f, moveHorizontal * -tilt);
    }
}

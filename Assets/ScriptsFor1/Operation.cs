using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Operation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnGUI()
    {
        GUI.skin.button.fontSize = 25;
        if (GUI.Button(new Rect(Screen.width *2/ 4, Screen.height * 7 / 9, 170, 60), "返回首页"))
        {
            SceneManager.LoadScene("Start");
            Cursor.visible = true;
        }
    }
}

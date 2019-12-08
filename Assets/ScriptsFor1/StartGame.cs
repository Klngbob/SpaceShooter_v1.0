using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {

    }
    public void OnGUI()
    {
        GUI.skin.button.fontSize = 30;
        if (GUI.Button(new Rect(Screen.width*2/5, Screen.height*6/9, 170, 60), "开始游戏"))
        {
            SceneManager.LoadScene("1_1");
            Cursor.visible = true;
        }

        if (GUI.Button(new Rect(Screen.width*2/5, Screen.height*8/10, 170, 60), "游戏操作"))
        {
            SceneManager.LoadScene("Operation");
            Cursor.visible = true;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
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
        GUI.skin.button.fontSize = 30;
        if (GUI.Button(new Rect(Screen.width *2/ 5, Screen.height * 6 / 9, 170, 60), "返回首页"))
        {
            SceneManager.LoadScene("Start");
            Cursor.visible = true;
        }
        if (GUI.Button(new Rect(Screen.width *2/ 5, Screen.height * 8 / 10, 170, 60), "打赏一下"))
        {
            SceneManager.LoadScene("Money");
            Cursor.visible = true;
        }
    }
}

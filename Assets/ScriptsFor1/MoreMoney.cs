using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoreMoney : MonoBehaviour
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
        if (GUI.Button(new Rect(Screen.width*5/7, Screen.height*11/13, 120, 50), "返回尾页"))
        {
            SceneManager.LoadScene("GameOver");
            Cursor.visible = true;
        }
    }
}

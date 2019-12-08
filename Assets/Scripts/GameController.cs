using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject enemyPrefab;
    //public GameObject enemyshipPrefab;//敌机预设
    public float StartEnemyTime = 1f;//开始产生敌人的时间
    public int number = 10;
    public float SpawnTime = 0.5f;
    public float WaveTime = 2f;//每一波陨石的时间间隔
    public float LevelUpTime = 3f;//升级的间隔时间

    private int myScore;
    public int myLevel;
    private int level_ref;
    public Text Score;
    public Text GameOver;
    public Text Restart;
    public Text Level;
    public Text LevelUp;
    private bool isGameOver;
    private bool isRestart;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("CreatEnemy");
        myScore = 0;
        myLevel = 0;
        level_ref = 0;
        UpdateScore();
        isGameOver = false;
    }
    //动态产生敌人
    
    public void GameOverProc()
    {
        isGameOver = true;
        GameOver.text = "Game Over!";
        isRestart = true;
        Restart.text = "按R重新开始\n" +
            "按T退出游戏";
    }
    //GameOver处理


    public void UpdateScore()//成绩文本
    {
        Score.text = "Score：" + myScore.ToString();
    }
    public void UpdateLevel()//升级文本
    {
        Level.text = "Level: " + myLevel.ToString();
    }
    //成绩修改
    public void AddScore(int value)
    {
        myScore += value;
        UpdateScore();
    }
    public void AddLevel()//升级计算
    {
        if (myScore < 301)
        {
            myLevel = myScore / 100;
        }
        else if (myScore < 901)
        {
            myLevel =3+ (myScore-300) / 200;
        }
        else
        {
            myLevel =6+ (myScore-900) / 500;
        }
        UpdateLevel();
    }
    public bool isLevelUp()//判断是否升级
    {
        if (myLevel > level_ref)
        {
            level_ref = myLevel;
            //print("hello world");
            return true;
        }
        else
        {
            return false;
        }
    }
    
    IEnumerator CreatEnemy()//敌人产生
    {
        yield return new WaitForSeconds(StartEnemyTime) ;
        while (true)
        {
            for(int i = 0;i < number; i++)
            {
                //print(i);
                if (isGameOver)
                {
                    break;
                }
                if (isLevelUp())//如果升级则暂停3s，并显示Level Up文本框
                {
                    //print("yes");
                    LevelUp.text = "Level Up!";
                    yield return new WaitForSeconds(LevelUpTime);
                    LevelUp.text = "";
                }
                isLevelUp();
                //if (myLevel >=0)//产生敌机
                //{
                //    Vector3 pos1 = new Vector3(Random.Range(-5f, 5f), 0f, 12f);
                //    Instantiate(enemyshipPrefab, pos1, Quaternion.identity);
                //    yield return new WaitForSeconds(SpawnTime);
                //}
                Vector3 pos = new Vector3(Random.Range(-6f, 6f), 0f, 12f);
                Instantiate(enemyPrefab, pos, Quaternion.identity);
                //print("move");
                yield return new WaitForSeconds(SpawnTime);
            }
            yield return new WaitForSeconds(WaveTime);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (isRestart)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
                if (Input.GetKeyDown(KeyCode.T))
                {
                    SceneManager.LoadScene("GameOver");
                }
        }
    }
}

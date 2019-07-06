using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GreatTimer : MonoBehaviour
{
    public GameObject timer;
    public GameObject Score1;
    public GameObject Score2;
    public GameObject Score3;
    public GameObject Score4;
    public static float Timeleft;
    private void Start()
    {
        Timeleft = 90;
        timer = GameObject.Find("Timer");
        Score1 = GameObject.Find("Score1");
        Score2 = GameObject.Find("Score2");
        Score3 = GameObject.Find("Score3");
        Score4 = GameObject.Find("Score4");
        StartCoroutine(GameTime());
    }
    // Update is called once per frame
    void Update()
    {
        timer.GetComponent<Text>().text = ((int)Timeleft).ToString();
        Score1.GetComponent<Text>().text = "Score:"+GlobalValues.Player1Score.ToString();
        Score2.GetComponent<Text>().text = "Score:" + GlobalValues.Player2Score.ToString();
        Score3.GetComponent<Text>().text = "Score:" + GlobalValues.Player3Score.ToString();
        Score4.GetComponent<Text>().text = "Score:" + GlobalValues.Player4Score.ToString();
    }
    IEnumerator GameTime() {
        for (; Timeleft >= 0; Timeleft -= Time.deltaTime)
            yield return 0;
        //应有分数计算成绩公布并返回菜单啥的
        Application.Quit();
    }
}

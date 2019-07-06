using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeNumberDown : MonoBehaviour
{
    private int number;
    public Text Button;
    void Start()
    {
        number = 2;
    }

    public void OnClick(int i)
    {
        number =number+i;
        if (number < 2)
        {
            number = 4;
        }
        else if (number > 4)
            number = 2;
    }

    void Update()
    {
        if (number == 2)
        {
            Button.text = "两人游戏";
            GlobalValues.IsPlayer2JoinGame = true;
            GlobalValues.IsPlayer3JoinGame = false;
            GlobalValues.IsPlayer4JoinGame = false;
        }
        if (number == 3)
        {
            Button.text = "三人游戏";
            GlobalValues.IsPlayer3JoinGame = true;
            GlobalValues.IsPlayer4JoinGame = false;
        }
        if (number == 4)
        {
            Button.text = "四人游戏";
            GlobalValues.IsPlayer3JoinGame = true;
            GlobalValues.IsPlayer4JoinGame = true;
        }
    }
}
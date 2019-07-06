﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChooseWeapon3 : MonoBehaviour
{
    private static int PlayerWeaponNumber=1;
    public Text Weapon;
    private bool PlayerIsReady = true;
    public GameObject Ready;
    void Start()
    {
        
    }

    void Update()
    {
        if (GlobalValues.IsPlayer4JoinGame == true)
        {
            if (PlayerIsReady == true)
            {
                if (Input.GetKeyDown(KeyCode.LeftArrow))
                {
                    PlayerWeaponNumber -= 1;
                    if (PlayerWeaponNumber < 1)
                    {
                        PlayerWeaponNumber = 4;
                    }
                }
                if (Input.GetKeyDown(KeyCode.RightArrow))
                {
                    PlayerWeaponNumber += 1;
                    if (PlayerWeaponNumber > 4)
                    {
                        PlayerWeaponNumber = 1;
                    }
                }
                if (PlayerWeaponNumber == 1)
                {
                    Weapon.text = "    突击步枪";
                }
                if (PlayerWeaponNumber == 2)
                {
                    Weapon.text = "    狙击步枪";
                }
                if (PlayerWeaponNumber == 3)
                {
                    Weapon.text = "    霰弹枪";
                }
                if (PlayerWeaponNumber == 4)
                {
                    Weapon.text = "    光束步枪";
                }
            }
            if (Input.GetKeyDown(KeyCode.KeypadEnter))
            {
                PlayerIsReady = false;
                Instantiate(Ready);
            }
        }
        else Weapon.text = "";
    }
}

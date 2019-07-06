using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChooseWeapon : MonoBehaviour
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
        if (PlayerIsReady==true)
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                PlayerWeaponNumber -= 1;
                if (PlayerWeaponNumber < 1)
                {
                    PlayerWeaponNumber = 4;
                }
            }
            if (Input.GetKeyDown(KeyCode.D))
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
        if (Input.GetKeyDown(KeyCode.C))
        {
            PlayerIsReady = false;
            Instantiate(Ready);
        }
    }
}

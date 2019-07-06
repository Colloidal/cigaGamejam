using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponControl : MonoBehaviour
{
    public GameObject player;

    private List<bool> IsPlayerInCD = new List<bool> { false, false, false, false };

    private void Start()
    {
        player = GameObject.Find("player");
        WeaponManager.GetInstance().PlayerChooseWeapon(1,1);
        WeaponManager.GetInstance().PlayerChooseWeapon(2, 1);
        WeaponManager.GetInstance().PlayerChooseWeapon(3, 1);
        WeaponManager.GetInstance().PlayerChooseWeapon(4, 1);
    }

    // Update is called once per frame
    void Update()
    {
        if(!IsPlayerInCD[0]&& Input.GetKey(KeyCode.C))//玩家1按下且不在cd
        {
            if (WeaponManager.GetInstance().PlayerShoot(1))
            {
                WeaponManager.GetInstance().Shoot(1,GameObject.Find("firePos").transform.position);
                StartCoroutine(EnterCD(WeaponManager.GetInstance().GetPlayerWeapon(1).AttackCD, 1));
            }
            else
            {
                Debug.Log("装弹！");
                StartCoroutine(EnterCD(WeaponManager.GetInstance().GetPlayerWeapon(1).ReloadCD, 1));
                WeaponManager.GetInstance().FillBullet(1);
            }
            IsPlayerInCD[0] = true;
        }
        else if (!IsPlayerInCD[1] && Input.GetKey(KeyCode.Return))//玩家2按下且不在cd
        {
            if (WeaponManager.GetInstance().PlayerShoot(1))
            {
                Debug.Log("biubiubiu!2");
                StartCoroutine(EnterCD(WeaponManager.GetInstance().GetPlayerWeapon(2).AttackCD, 2));
            }
            else
            {
                Debug.Log("装弹！2");
                StartCoroutine(EnterCD(WeaponManager.GetInstance().GetPlayerWeapon(2).ReloadCD, 2));
                WeaponManager.GetInstance().FillBullet(2);
            }
            IsPlayerInCD[1] = true;
        }
        else if (!IsPlayerInCD[2] && Input.GetKey(KeyCode.M))//玩家3按下且不在cd
        {
            if (WeaponManager.GetInstance().PlayerShoot(3))
            {
                Debug.Log("biubiubiu!3");
                StartCoroutine(EnterCD(WeaponManager.GetInstance().GetPlayerWeapon(3).AttackCD, 3));
            }
            else
            {
                Debug.Log("装弹！3");
                StartCoroutine(EnterCD(WeaponManager.GetInstance().GetPlayerWeapon(3).ReloadCD, 3));
                WeaponManager.GetInstance().FillBullet(3);
            }
            IsPlayerInCD[2] = true;
        }
        else if (!IsPlayerInCD[3] && Input.GetKey(KeyCode.Slash))//玩家4按下且不在cd
        {
            if (WeaponManager.GetInstance().PlayerShoot(4))
            {
                Debug.Log("biubiubiu!4");
                StartCoroutine(EnterCD(WeaponManager.GetInstance().GetPlayerWeapon(4).AttackCD, 4));
            }
            else
            {
                Debug.Log("装弹！4");
                StartCoroutine(EnterCD(WeaponManager.GetInstance().GetPlayerWeapon(4).ReloadCD, 4));
                WeaponManager.GetInstance().FillBullet(4);
            }
            IsPlayerInCD[3] = true;
        }
    }
    IEnumerator EnterCD(float cd,int playernumber) {
        for (float i = cd; i >= 0; i -= Time.deltaTime) yield return 0;
        IsPlayerInCD[playernumber - 1] = false;
    }
}

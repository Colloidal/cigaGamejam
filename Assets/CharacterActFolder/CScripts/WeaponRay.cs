using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponRay : MonoBehaviour
{
    private void Update()
    {
        if (GlobalValues.Raymark1)
            Invoke("delectit",0.3f);
    }
    //private void delectit() {
    //    WeaponManager.GetInstance().getray().SetActive(false);
    //}
}

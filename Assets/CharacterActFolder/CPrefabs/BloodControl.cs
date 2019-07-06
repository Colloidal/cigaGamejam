using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BloodControl : MonoBehaviour
{
    public void ChangeBlood(int num) {
        gameObject.GetComponent<Slider>().value = num / 100;
    }
}

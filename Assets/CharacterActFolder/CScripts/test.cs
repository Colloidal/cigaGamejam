using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    public GameObject game;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("hhh");
        game = GameObject.Find("1s2");
        game.GetComponent<BloodControl>().ChangeBlood(50);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

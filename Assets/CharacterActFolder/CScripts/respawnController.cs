using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawnController : MonoBehaviour
{
    public bool isAlive;
    public int dyingTime;
    public Transform []respawnPlace; 
    private characterMovement2D CM;
    private SpriteRenderer SP;

    void Start()
    {
        isAlive = true;
        CM = GetComponent< characterMovement2D>();
        SP = GetComponent<SpriteRenderer>();
        respawnPlace[0] = GameObject.Find("respawn1").transform;
        respawnPlace[1] = GameObject.Find("respawn2").transform;
        respawnPlace[2] = GameObject.Find("respawn3").transform;
        respawnPlace[3] = GameObject.Find("respawn4").transform;

    }

    // Update is called once per frame
    void Update()
    {
        if (!isAlive /*&& CM.characterNumber == 1*/)
        {
            Respawn();
        }
    }

    IEnumerator Dying()
    {
        Debug.Log("正在死亡");
        yield return new WaitForSeconds(dyingTime);
    }

    private void Respawn()
    {
        StartCoroutine(Dying());
        isAlive = !isAlive;
        int i = Random.Range(0, 4);
        transform.position = respawnPlace[i].position;
    }

}

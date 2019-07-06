using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawnController : MonoBehaviour
{
    public bool isAlive;
    public bool isRespawning;
    public int dyingTime;
    public Transform []respawnPlace; 
    private characterMovement2D CM;
    private SpriteRenderer SP;

    void Start()
    {
        isAlive = true;
        isRespawning = false;
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
        if (!isAlive && isRespawning == false /*&& CM.characterNumber == 1*/)
        {
            StartCoroutine(Dying());
            isAlive = !isAlive;
            isRespawning = true;
        }
    }

    IEnumerator Dying()
    {
        for (float i = dyingTime; i >= 0; i -= Time.deltaTime) yield return 0;
        Debug.Log("dddd");
        isRespawning = false;
        Respawn();
    }

    private void Respawn()
    {
        int i = Random.Range(0, 4);
        transform.position = respawnPlace[i].position;
    }

}

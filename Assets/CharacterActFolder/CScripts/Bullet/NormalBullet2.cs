using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalBullet2 : MonoBehaviour
{
    public int SourcePlayer;
    public Vector3 speed;

    // Update is called once per frame
    private void Update()
    {
        transform.Translate(speed);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "wall") {
            Debug.Log("哎呀我撞到了墙");
            Destroy(gameObject);
        }
        else if (collision.gameObject.tag == "player") {
            Debug.Log("打到一个人");
            Destroy(gameObject);
        }

    }
}

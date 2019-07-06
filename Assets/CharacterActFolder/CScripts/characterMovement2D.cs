using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterMovement2D : MonoBehaviour
{
    public int characterNumber;
    public float movingSpeed;
    public float angularSpeed;
    public static Vector2 forwardPointer;
    private Rigidbody2D RB;
    private respawnController RC;
    public Transform firePos;

    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
        RC = GetComponent<respawnController>();
    }

    // Update is called once per frame
    void Update()
    {
        forwardPointer = firePos.position - transform.position;
        if (characterNumber == 1)
        {
            characterMoving1();
        }
        if (characterNumber == 2)
        {
            characterMoving2();
        }
        if (characterNumber == 3)
        {
            characterMoving3();
        }
        if (characterNumber == 4)
        {
            characterMoving4();
        }
    }

    private void characterMoving1()
    {
        if (!RC.isAlive || RC.isRespawning)
        {
            RB.angularVelocity = 0;
            RB.velocity = new Vector2(0f, 0f);
            return;
        }
        if (GlobalValues.Player1Stop)
        {
            RB.angularVelocity = 0;
            RB.velocity = new Vector2(0f, 0f);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            RB.angularVelocity = angularSpeed;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            RB.angularVelocity = angularSpeed * -1;
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            RB.angularVelocity = 0;
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            RB.angularVelocity = 0;
        }
        if (Input.GetKey(KeyCode.W))
        {
            RB.velocity = forwardPointer * movingSpeed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            RB.velocity = forwardPointer * movingSpeed * -1;
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            RB.velocity = new Vector2(0f, 0f);
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            RB.velocity = new Vector2(0f, 0f);
        }
    }

    private void characterMoving2()
    {
        if (!RC.isAlive || RC.isRespawning)
        {
            RB.angularVelocity = 0;
            RB.velocity = new Vector2(0f, 0f);
            return;
        }
        if (GlobalValues.Player2Stop)
        {
            RB.angularVelocity = 0;
            RB.velocity = new Vector2(0f, 0f);
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            RB.angularVelocity = angularSpeed;
        }
        if (Input.GetKeyDown(KeyCode.Semicolon))
        {
            RB.angularVelocity = angularSpeed * -1;
        }
        if (Input.GetKeyUp(KeyCode.K))
        {
            RB.angularVelocity = 0;
        }
        if (Input.GetKeyUp(KeyCode.Semicolon))
        {
            RB.angularVelocity = 0;
        }
        if (Input.GetKey(KeyCode.O))
        {
            RB.velocity = forwardPointer * movingSpeed;
        }
        if (Input.GetKey(KeyCode.L))
        {
            RB.velocity = forwardPointer * movingSpeed * -1;
        }
        if (Input.GetKeyUp(KeyCode.O))
        {
            RB.velocity = new Vector2(0f, 0f);
        }
        if (Input.GetKeyUp(KeyCode.L))
        {
            RB.velocity = new Vector2(0f, 0f);
        }
    }

    private void characterMoving3()
    {
        if (!RC.isAlive || RC.isRespawning)
        {
            RB.angularVelocity = 0;
            RB.velocity = new Vector2(0f, 0f);
            return;
        }
        if (GlobalValues.Player3Stop)
        {
            RB.angularVelocity = 0;
            RB.velocity = new Vector2(0f, 0f);
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            RB.angularVelocity = angularSpeed;
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            RB.angularVelocity = angularSpeed * -1;
        }
        if (Input.GetKeyUp(KeyCode.G))
        {
            RB.angularVelocity = 0;
        }
        if (Input.GetKeyUp(KeyCode.J))
        {
            RB.angularVelocity = 0;
        }
        if (Input.GetKey(KeyCode.Y))
        {
            RB.velocity = forwardPointer * movingSpeed;
        }
        if (Input.GetKey(KeyCode.H))
        {
            RB.velocity = forwardPointer * movingSpeed * -1;
        }
        if (Input.GetKeyUp(KeyCode.Y))
        {
            RB.velocity = new Vector2(0f, 0f);
        }
        if (Input.GetKeyUp(KeyCode.H))
        {
            RB.velocity = new Vector2(0f, 0f);
        }
    }

    private void characterMoving4()
    {
        if (!RC.isAlive || RC.isRespawning)
        {
            RB.angularVelocity = 0;
            RB.velocity = new Vector2(0f, 0f);
            return;
        }
        if (GlobalValues.Player4Stop)
        {
            RB.angularVelocity = 0;
            RB.velocity = new Vector2(0f, 0f);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            RB.angularVelocity = angularSpeed;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            RB.angularVelocity = angularSpeed * -1;
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            RB.angularVelocity = 0;
        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            RB.angularVelocity = 0;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            RB.velocity = forwardPointer * movingSpeed;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            RB.velocity = forwardPointer * movingSpeed * -1;
        }
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            RB.velocity = new Vector2(0f, 0f);
        }
        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            RB.velocity = new Vector2(0f, 0f);
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterMovement2D : MonoBehaviour
{
    public int characterNumber;
    public float movingSpeed;
    public float angularSpeed;
    private Transform firePos;
    private Vector2 forwardPointer;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        firePos = transform.Find("firePos");
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
        if (Input.GetKeyDown(KeyCode.A))
        {
            rb.angularVelocity = angularSpeed;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            rb.angularVelocity = angularSpeed * -1;
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            rb.angularVelocity = 0;
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            rb.angularVelocity = 0;
        }
        if (Input.GetKey(KeyCode.W))
        {
            rb.velocity = forwardPointer * movingSpeed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.velocity = forwardPointer * movingSpeed * -1;
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            rb.velocity = new Vector2(0f, 0f);
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            rb.velocity = new Vector2(0f, 0f);
        }
    }

    private void characterMoving2()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            rb.angularVelocity = angularSpeed;
        }
        if (Input.GetKeyDown(KeyCode.Semicolon))
        {
            rb.angularVelocity = angularSpeed * -1;
        }
        if (Input.GetKeyUp(KeyCode.K))
        {
            rb.angularVelocity = 0;
        }
        if (Input.GetKeyUp(KeyCode.Semicolon))
        {
            rb.angularVelocity = 0;
        }
        if (Input.GetKey(KeyCode.O))
        {
            rb.velocity = forwardPointer * movingSpeed;
        }
        if (Input.GetKey(KeyCode.L))
        {
            rb.velocity = forwardPointer * movingSpeed * -1;
        }
        if (Input.GetKeyUp(KeyCode.O))
        {
            rb.velocity = new Vector2(0f, 0f);
        }
        if (Input.GetKeyUp(KeyCode.L))
        {
            rb.velocity = new Vector2(0f, 0f);
        }
    }

    private void characterMoving3()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            rb.angularVelocity = angularSpeed;
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            rb.angularVelocity = angularSpeed * -1;
        }
        if (Input.GetKeyUp(KeyCode.G))
        {
            rb.angularVelocity = 0;
        }
        if (Input.GetKeyUp(KeyCode.J))
        {
            rb.angularVelocity = 0;
        }
        if (Input.GetKey(KeyCode.Y))
        {
            rb.velocity = forwardPointer * movingSpeed;
        }
        if (Input.GetKey(KeyCode.H))
        {
            rb.velocity = forwardPointer * movingSpeed * -1;
        }
        if (Input.GetKeyUp(KeyCode.Y))
        {
            rb.velocity = new Vector2(0f, 0f);
        }
        if (Input.GetKeyUp(KeyCode.H))
        {
            rb.velocity = new Vector2(0f, 0f);
        }
    }

    private void characterMoving4()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            rb.angularVelocity = angularSpeed;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            rb.angularVelocity = angularSpeed * -1;
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            rb.angularVelocity = 0;
        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            rb.angularVelocity = 0;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.velocity = forwardPointer * movingSpeed;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.velocity = forwardPointer * movingSpeed * -1;
        }
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            rb.velocity = new Vector2(0f, 0f);
        }
        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            rb.velocity = new Vector2(0f, 0f);
        }
    }

}

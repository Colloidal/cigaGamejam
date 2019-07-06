using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public int characterNumber;
    public float movingSpeed;
    public float angularSpeed;
    public int fireTime;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        CharacterMoving();
        /*Z
        if (Input.GetKeyDown("fire" + characterNumber))
            CharacterFire();*/
    }

    private void CharacterMoving()
    {/*
        if (Input.GetKey("a"))*/
        /*
        float h = Input.GetAxis("Horizontal" + characterNumber);
        float v = Input.GetAxis("Vertical" + characterNumber);
        rb.velocity = transform.forward * v;
        rb.angularVelocity = transform.up * angularSpeed * h;
        */
    }

    private void CharacterFire()
    {
        Transform firePos = transform.Find("firePos");
    }
    
}

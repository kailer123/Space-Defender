using UnityEngine;
using System.Collections;
using System.IO.Ports;
using TMPro;
using UnityEditor;
using System;

public class Comunicacion : MonoBehaviour
{
    //SerialPort stream = new SerialPort("COM4", 115200);
    
    public float fps;
    public float speed;
    public float rotateSpeed;
    public GameObject objectToSpawn;
    

    public Rigidbody2D rb;
    void Start()
    {
        //stream.Open(); //Open the Serial Stream.
      
        rb = GetComponent<Rigidbody2D>();
        speed = 40f;
        rotateSpeed = 100f;
    }

    void Update()
    {


        fps = 1 / (Time.deltaTime);

        

        Quaternion rotation = transform.rotation;
        Vector2 forward = rotation * Vector2.up;
        Vector2 backwards = rotation * Vector2.down;

        if(transform.position.x > 24)
        {
            transform.position = (new Vector2(-23,transform.position.y));
        }else if (transform.position.x < -24)
        {
            transform.position = (new Vector2(23, transform.position.y));
        }
        else if (transform.position.y > 11.5f)
        {
            transform.position = (new Vector2(transform.position.x, -11f));
        }
        else if (transform.position.y < -11.5f)
        {
            transform.position = (new Vector2(transform.position.x, 11f));
        }

            float rotate = Input.GetAxis("Horizontal");
        rb.rotation += -rotate * Time.deltaTime * rotateSpeed;

        if (Input.GetKey(KeyCode.Space)) //Check if all values are recieved
        {
            rb.velocity += forward * speed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.LeftControl)) //Check if all values are recieved
        {
            rb.drag = 15;
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Instantiate(objectToSpawn, new Vector2(transform.position.x, transform.position.y), new Quaternion(transform.rotation.x, transform.rotation.y, transform.rotation.z, transform.rotation.w));
        }
        else if (Input.GetKey(KeyCode.LeftControl) == false)
        {
            rb.drag = 1;
        }
    }
}
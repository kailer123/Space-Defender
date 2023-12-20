using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class bulletControl : MonoBehaviour
{
    // Start is called before the first frame update
    float speed = 10f;
    public GameObject control;
    int numOfPasses;
    
    void Start()
    {
        numOfPasses = 0;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector2(0,1) * Time.deltaTime * speed);

        if (transform.position.x > 24)
        {
            transform.position = (new Vector2(-23, transform.position.y));
            numOfPasses++;
        }
        else if (transform.position.x < -24)
        {
            transform.position = (new Vector2(23, transform.position.y));
            numOfPasses++;
        }
        else if (transform.position.y > 11.5f)
        {
            transform.position = (new Vector2(transform.position.x, -11f));
            numOfPasses++;
        }
        else if (transform.position.y < -11.5f)
        {
            transform.position = (new Vector2(transform.position.x, 11f));
            numOfPasses++;
        }
        destroy(numOfPasses);
        //spawner.enemeNum = spawner.enemeNum - 1;
        
    }

    private void OnTriggerEnter2D(Collider2D collisio)
    {
        if (collisio.gameObject.tag == "Enemy")
        {
            Destroy(collisio.gameObject);
            Destroy(this.gameObject);
            
        }
        
    }
    private void destroy(int timeToLive)
    {
        if(timeToLive > 2)
        {
            Destroy(this.gameObject);
        }
    }
}


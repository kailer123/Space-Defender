using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class enemeProjectiles : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    float speed = 10f;
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector2(0, -1) * Time.deltaTime * speed);

        if(transform.position.y < -100 || transform.position.y > 100 || transform.position.x < -100 || transform.position.x > 100)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collisio)
    {
        if (collisio.gameObject.tag == "XDD")
        {
            Destroy(collisio.gameObject);
            Destroy(this.gameObject);
            
        }

    }
}
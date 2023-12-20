using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;
using static UnityEngine.GraphicsBuffer;

public class enemyAIControl : MonoBehaviour
{
    public Transform target;
    public GameObject bullet;
    Rigidbody2D rb;
    Vector2 Movement;
    float speed = 5f;
    float time; 
    float beginTime = 10;
    public static enemyTracker tracker;

    // Start is called before the first frame update
    private void Awake()
    {
        
    }
    void Start()
    {   
        rb = this.GetComponent<Rigidbody2D>();
        time = 1;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = target.position - transform.position;   
        float angle = Mathf.Atan2(dir.x, dir.y) * Mathf.Rad2Deg;
        rb.rotation = -angle;
        dir.Normalize();
        Movement = dir;
        time -= Time.deltaTime;
        if (time <= 0)
        {
            Instantiate(bullet, transform.position, Quaternion.Euler(0, 0, -angle + Random.Range(167f,192f)));
            time = 1;
        }

    }
    private void FixedUpdate()
    {
        if(Vector2.Distance(transform.position, target.position) > 5)
        {
            moveCharacter(Movement);
        }
        

        
    }
    void moveCharacter(Vector2 direction)
    {
        rb.MovePosition((Vector2)transform.position + (direction * speed * Time.deltaTime));
    }

    private void OnDestroy()
    {

    }
}



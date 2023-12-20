using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class enemyControl : MonoBehaviour
{
    public GameObject enemyProjectile;
    public GameObject player;

    public float timeRemaining;

    // Start is called before the first frame update
    void Start()
    {
        timeRemaining = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
        }
        else
        {
            Instantiate(enemyProjectile, new Vector2(transform.position.x, transform.position.y), Quaternion.Euler(transform.rotation.x, transform.rotation.y, transform.rotation.z));

            timeRemaining = Random.Range(1f,3f);
        }
    }
}
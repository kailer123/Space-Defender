using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject sp1;
    public GameObject sp2;
    public GameObject sp3;
    public GameObject sp4;
    public GameObject enemy;
    int randspawn;
    float time;
    public int enemyNum = 0;
    // Update is called once per frame

    private void Awake()
    {
        
    }
    private void Start()
    {
        time = 5;
    }
    void Update()
    {
        time -= Time.deltaTime;
        if(time < 1 && enemyNum < 1)
        {
            randspawn = Random.Range(1, 5);
            if(randspawn == 1)
            {
                Instantiate(enemy,new Vector2(sp1.transform.position.x, Random.Range(-11,11)), transform.rotation);
                enemyNum++;
                time = 5;
            }
            else if (randspawn == 2)
            {
                Instantiate(enemy,new Vector2(Random.Range(-24,24), sp2.transform.position.y),transform.rotation);
                enemyNum++;
                time = 5;
            }
            else if (randspawn == 3)
            {
                Instantiate(enemy, new Vector2(sp3.transform.position.x, Random.Range(-11, 11)), transform.rotation);
                enemyNum++;
                time = 5;
            }
            else if (randspawn == 4)
            {
                Instantiate(enemy, new Vector2(Random.Range(-24, 24), sp4.transform.position.y), transform.rotation);
                enemyNum++;
                time = 5;
            }
        }
        
    }
}

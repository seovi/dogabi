using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] EnemyPatterns;

    private float timeBtwSpawn;
    public float startTimeBtwSpawn;
    public float decreaseTime;
    public float minTime = 0.65f;

    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        Vector2 position = new Vector2(-5, 0);
        Instantiate(player, position, Quaternion.Euler(0f, 0f, 270f));
    }

    // Update is called once per frame
    void Update()
    {
        if (timeBtwSpawn <= 0)
        {
            int rand = Random.Range(0, EnemyPatterns.Length);
            Instantiate(EnemyPatterns[rand], transform.position, Quaternion.Euler(0f, 0f, 270f));
            timeBtwSpawn = startTimeBtwSpawn;
            if (startTimeBtwSpawn > minTime)
            {
                startTimeBtwSpawn -= decreaseTime;
            }
        }
        else
        {
            timeBtwSpawn -= Time.deltaTime;
        }
    }
}

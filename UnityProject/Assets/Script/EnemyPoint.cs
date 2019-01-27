using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPoint : MonoBehaviour
{
    public GameObject Enemy;
    // Start is called before the first frame update
    void Start()
    {
        //Instantiate(Enemy, transform.position, Quaternion.identity);
        Instantiate(Enemy, transform.position, Quaternion.Euler(0f, 0f, 270f));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

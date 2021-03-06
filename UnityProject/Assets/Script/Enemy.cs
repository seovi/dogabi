﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int damage = 1;
    public float speed;

    public GameObject effect;
    public GameObject sound;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Instantiate(sound);
            Instantiate(effect, transform.position, Quaternion.identity);
            collision.GetComponent<Player>().health -= 1;
            Debug.Log(collision.GetComponent<Player>().health);
            Destroy(sound);
            Destroy(gameObject);            
        }
    }
}

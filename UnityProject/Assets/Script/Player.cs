using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour {

    private Vector2 targetPos;
    public float Yincrement;
    public float speed;
    public float maxHeight;
    public float minHeight;

    public int health = 3;
    public GameObject effect;
    public GameObject moveSound;

    public Text healthDisplay;

    // Use this for initialization
    void Start () {
        targetPos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {

        if (healthDisplay != null)
        {
            healthDisplay.text = health.ToString();
        }

        if (health <= 0)
        {
            Debug.Log("U Die");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed  * Time.deltaTime);
        Debug.Log(transform.position);

		if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < maxHeight)
        {
            Instantiate(moveSound);
            Instantiate(effect, transform.position, Quaternion.identity);
            targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
            if (targetPos.y > maxHeight)
                targetPos.y = maxHeight;

        } else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minHeight)
        {
            Instantiate(moveSound);
            Instantiate(effect, transform.position, Quaternion.identity);
            targetPos = new Vector2(transform.position.x, transform.position.y - Yincrement);
            if (targetPos.y < minHeight)
                targetPos.y = minHeight;
        }
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Poo : MonoBehaviour
{
    public float moveSpeed = 4f;
    public ScoreManager scoreManager;

    // Start is called before the first frame update
    void Start()
    {   
        // set moveSpeed randomly from 5 to 10
        moveSpeed = Random.Range(1f, 3f);

        scoreManager = GameObject.FindGameObjectWithTag("score").GetComponent<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {
        // Poo goes down
        transform.position += Vector3.down * moveSpeed * Time.deltaTime;

        // if y position is less than -5, destroy this object
        if (transform.position.y < -5)
        {
            scoreManager.AddScore(1);
            Destroy(gameObject);
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            scoreManager.gameOver();
            Destroy(collision.gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 6f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // move left and right

        // if left arrow key is pressed
        if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x > -9.5) 
        {
            transform.position += Vector3.left * moveSpeed * Time.deltaTime;
        }

        // if right arrow key is pressed
        if (Input.GetKey(KeyCode.RightArrow) && transform.position.x < 9.5)
        {
            transform.position += Vector3.right * moveSpeed * Time.deltaTime;
        }
        
    }
}

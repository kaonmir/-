using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PooSpawn : MonoBehaviour
{
    public GameObject pooPrefab;

    private float spawnRate = 0.1f;
    private float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        SpawnPoo();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            SpawnPoo();
            timer = 0;
            spawnRate = Random.Range(0.5f, 0.6f);
        }
    }

    void SpawnPoo()
    {
        float lowestPoint = -8;
        float highestPoint = 8;

        Instantiate(
            pooPrefab, 
            new Vector3(Random.Range(lowestPoint, highestPoint), transform.position.y, 200), 
            transform.rotation
        );
    }
}

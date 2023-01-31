using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject prefab;

    public float spawnTime;
    private float timeCount;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeCount += Time.deltaTime;

        if(timeCount >= spawnTime)
        {
            GameObject go = Instantiate(prefab, transform.position, transform.rotation);
            Destroy(go, 5f);
            timeCount = 0f;
        }
    }
}

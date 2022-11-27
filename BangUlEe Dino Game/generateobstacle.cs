using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generateobstacle : MonoBehaviour
{
    float timer = 0;
    public GameObject obs;
    public float timediff;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer > timediff)
        {
            GameObject newobs = Instantiate(obs);
            newobs.transform.position = new Vector3(Random.Range(10.0f,15.0f), 0, 0);
            timer = 0;
            Destroy(newobs, 20.0f);
        }
    }
}

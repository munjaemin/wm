using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmeryFactory : MonoBehaviour
{
    public float delaytime = 2.0f;
    float currenttime = 0;
    public GameObject enemy;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     if(delaytime <= currenttime)
        {
            Instantiate(enemy, transform.position, Quaternion.identity);
            currenttime = 0;
        }
        else
        {
            currenttime += Time.deltaTime;
        }
    }
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class distance : MonoBehaviour
{ public GameObject blood;
    public float k;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    { float v = (blood.transform.position - Camera.main.transform.position).magnitude;
        if ( v <= k)
        {

        }
    }
}

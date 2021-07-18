using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cleanblood : MonoBehaviour
{
    public RawImage Blood;
    float i = 255.0f;
    int speed = 5;
    void Start()
    {
       

    }
    
    // Update is called once per frame
    void Update()
    {

        if (Input.GetButton("Fire1"))


        {

            Color32 color = Blood.color;

           
         
            i = i - speed;
            color.a = (byte)i;
                Blood.color = color;
                print(i);
            if ( i == 0.0f)
            {
               
                Blood.GetComponent<RawImage>().enabled = false;
            }

            

        }

    }
}

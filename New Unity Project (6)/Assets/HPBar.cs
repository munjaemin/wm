using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HPBar : MonoBehaviour
{
    public Slider hpslider;
    public int timelimit;
    float currenttime = 0;

    void Start()
    {
        hpslider.maxValue = 300;
        hpslider.value = hpslider.maxValue;
    }

    // Update is called once per frame
    void Update()
    {
        currenttime += Time.deltaTime;
        float j = 0;
        if (currenttime <= timelimit)
        {
            float i = currenttime;
            j = 300 - i;
            hpslider.value = j;
            
        }
        else
        {
            print("gameover");
        }
    }
}

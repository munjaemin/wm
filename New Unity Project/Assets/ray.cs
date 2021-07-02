using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ray : MonoBehaviour
{
    public GameObject blood;
    public float k;
    public GameObject press;
    // Start is called before the first frame update
    void Start()
    {
        press.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        new Ray(Camera.main.transform.position, Camera.main.transform.forward);
        RaycastHit hitinfo;

        
        float v = Mathf.Abs((blood.transform.position - Camera.main.transform.position).magnitude);
        //Debug.Log(v);
        if (v <= k)
        {

            if (Physics.Raycast(ray, out hitinfo))
            {
                //큐브인가?

                if (hitinfo.collider.gameObject.name == "blood")
                {
                    //UI 띄운다.
                    press.SetActive(true);
                }
                else
                {
                    press.SetActive(false);
                }
            }
           
        }
        else
        {
            press.SetActive(false);
        }
    }
}

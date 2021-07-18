using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PickUpUI : MonoBehaviour
{
    public GameObject meat1;
    public GameObject meat2;
    public GameObject meat3;
    public GameObject meat4;
    public GameObject meat5;
    
    public float k;
    public GameObject press1;
    public GameObject press2;
    public GameObject press3;
    public GameObject press4;
    public GameObject press5;
  

    
    

    // Start is called before the first frame update
    void Start()
    {
        press1.SetActive(false);
        press2.SetActive(false);
        press3.SetActive(false);
        press4.SetActive(false);
        press5.SetActive(false);
    
        
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        new Ray(Camera.main.transform.position, Camera.main.transform.forward);
        RaycastHit hitinfo;


        float a = Mathf.Abs((meat1.transform.position - Camera.main.transform.position).magnitude);
        
        //Debug.Log(v);
        if (a <= k)
        {

            if (Physics.Raycast(ray, out hitinfo))
            {
                //큐브인가?

                if (hitinfo.collider.gameObject.name == "meat1")
                {
                    //UI 띄운다.
                    press1.SetActive(true);
                    if (Input.GetButtonDown("Fire1"))
                    {
                        meat1.SetActive(false);

                    }
                }
                else
                {
                    press1.SetActive(false);
                }

            

                    
                
            }

        }
        else
        {
            press1.SetActive(false);
        }

        float b = Mathf.Abs((meat2.transform.position - Camera.main.transform.position).magnitude);

        //Debug.Log(v);
        if (b <= k)
        {

            if (Physics.Raycast(ray, out hitinfo))
            {
                //큐브인가?

                if (hitinfo.collider.gameObject.name == "meat2")
                {
                    //UI 띄운다.
                    press2.SetActive(true);
                    if (Input.GetButtonDown("Fire1"))
                    {
                        meat2.SetActive(false);

                    }
                }
                else
                {
                    press2.SetActive(false);
                }





            }

        }
        else
        {
            press2.SetActive(false);
        }

        float c = Mathf.Abs((meat3.transform.position - Camera.main.transform.position).magnitude);

        //Debug.Log(v);
        if (c <= k)
        {

            if (Physics.Raycast(ray, out hitinfo))
            {
                //큐브인가?

                if (hitinfo.collider.gameObject.name == "meat3")
                {
                    //UI 띄운다.
                    press3.SetActive(true);
                    if (Input.GetButtonDown("Fire1"))
                    {
                        meat3.SetActive(false);

                    }
                }
                else
                {
                    press3.SetActive(false);
                }







            }

        }
        else
        {
            press3.SetActive(false);
        }

        float d = Mathf.Abs((meat4.transform.position - Camera.main.transform.position).magnitude);

        //Debug.Log(v);
        if (d <= k)
        {

            if (Physics.Raycast(ray, out hitinfo))
            {
                //큐브인가?

                if (hitinfo.collider.gameObject.name == "meat4")
                {
                    //UI 띄운다.
                    press4.SetActive(true);
                    if (Input.GetButtonDown("Fire1"))
                    {
                        meat4.SetActive(false);

                    }
                }
                else
                {
                    press4.SetActive(false);
                }





            }

        }
        else
        {
            press4.SetActive(false);
        }

        float e = Mathf.Abs((meat5.transform.position - Camera.main.transform.position).magnitude);

        //Debug.Log(v);
        if (e <= k)
        {

            if (Physics.Raycast(ray, out hitinfo))
            {
                //큐브인가?

                if (hitinfo.collider.gameObject.name == "meat5")
                {
                    //UI 띄운다.
                    press5.SetActive(true);
                    if (Input.GetButtonDown("Fire1"))
                    {
                        meat5.SetActive(false);

                    }
                }
                else
                {
                    press5.SetActive(false);
                }





            }

        }
        else
        {
            press5.SetActive(false);
        }

    }
}

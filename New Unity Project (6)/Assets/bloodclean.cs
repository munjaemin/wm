using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class bloodclean : MonoBehaviour
{
   

    public float k;
   
    public GameObject press6;
    public GameObject press7;
    public GameObject press8;
    public GameObject press9;
    public GameObject press10;
    public GameObject press11;


    public GameObject blood1;
    public GameObject blood2;
    public GameObject blood3;
    public GameObject blood4;
    public GameObject blood5;
    public GameObject blood6;

  
    public float speed = 1f;
    float ab = 255.0f;
    float bc = 255.0f;
    float cd = 255.0f;
    float de = 255.0f;
    float ef = 255.0f;
    float fg = 255.0f;



    // Start is called before the first frame update
    void Start()
    {
      
        press6.SetActive(false);
        press7.SetActive(false);
        press8.SetActive(false);
        press9.SetActive(false);
        press10.SetActive(false);
        press11.SetActive(false);


    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        new Ray(Camera.main.transform.position, Camera.main.transform.forward);
        RaycastHit hitinfo;


       

        float A = Mathf.Abs((blood1.transform.position - Camera.main.transform.position).magnitude);

        //Debug.Log(v);
        if (A <= k)
        {

            if (Physics.Raycast(ray, out hitinfo))
            {
                //큐브인가?

                if (hitinfo.collider.gameObject.name == "Blood1")
                {
                    //UI 띄운다.
                    press6.SetActive(true);
                    if (Input.GetButton("Fire1"))
                    {

                        ab = ab - speed;

                        blood1.GetComponent<Renderer>().material.color = new Color32(173, 32, 32, (byte)ab);



                        if (ab <= 0.0f)
                        {
                            blood1.SetActive(false);
                        }




                    }
                }

                else
                {
                    press6.SetActive(false);
                }





            }

        }
        else
        {
            press6.SetActive(false);
        }

        float B = Mathf.Abs((blood2.transform.position - Camera.main.transform.position).magnitude);

        //Debug.Log(v);
        if (B <= k)
        {

            if (Physics.Raycast(ray, out hitinfo))
            {
                //큐브인가?

                if (hitinfo.collider.gameObject.name == "Blood2")
                {
                    //UI 띄운다.
                    press7.SetActive(true);
                    if (Input.GetButton("Fire1"))
                    {

                        bc = bc - speed;

                        blood2.GetComponent<Renderer>().material.color = new Color32(173, 32, 32, (byte)bc);



                        if (bc <= 0.0f)
                        {
                            blood2.SetActive(false);
                        }




                    }
                }

                else
                {
                    press7.SetActive(false);
                }





            }

        }
        else
        {
            press7.SetActive(false);
        }

        float C = Mathf.Abs((blood3.transform.position - Camera.main.transform.position).magnitude);

        //Debug.Log(v);
        if (C <= k)
        {

            if (Physics.Raycast(ray, out hitinfo))
            {
                //큐브인가?

                if (hitinfo.collider.gameObject.name == "Blood3")
                {
                    //UI 띄운다.
                    press8.SetActive(true);
                    if (Input.GetButton("Fire1"))
                    {

                        cd = cd - speed;

                        blood3.GetComponent<Renderer>().material.color = new Color32(173, 32, 32, (byte)cd);



                        if (cd <= 0.0f)
                        {
                            blood3.SetActive(false);
                        }




                    }
                }

                else
                {
                    press8.SetActive(false);
                }





            }

        }
        else
        {
            press8.SetActive(false);
        }

        float D = Mathf.Abs((blood4.transform.position - Camera.main.transform.position).magnitude);

        //Debug.Log(v);
        if (D <= k)
        {

            if (Physics.Raycast(ray, out hitinfo))
            {
                //큐브인가?

                if (hitinfo.collider.gameObject.name == "Blood4")
                {
                    //UI 띄운다.
                    press9.SetActive(true);
                    if (Input.GetButton("Fire1"))
                    {

                        de = de - speed;

                        blood4.GetComponent<Renderer>().material.color = new Color32(173, 32, 32, (byte)de);



                        if (de <= 0.0f)
                        {
                            blood4.SetActive(false);
                        }




                    }
                }

                else
                {
                    press9.SetActive(false);
                }





            }

        }
        else
        {
            press9.SetActive(false);
        }

        float E = Mathf.Abs((blood5.transform.position - Camera.main.transform.position).magnitude);

        //Debug.Log(v);
        if (E <= k)
        {

            if (Physics.Raycast(ray, out hitinfo))
            {
                //큐브인가?

                if (hitinfo.collider.gameObject.name == "Blood5")
                {
                    //UI 띄운다.
                    press10.SetActive(true);
                    if (Input.GetButton("Fire1"))
                    {

                        ef = ef - speed;

                        blood5.GetComponent<Renderer>().material.color = new Color32(173, 32, 32, (byte)ef);



                        if (ef <= 0.0f)
                        {
                            blood5.SetActive(false);
                        }




                    }
                }

                else
                {
                    press10.SetActive(false);
                }





            }

        }
        else
        {
            press10.SetActive(false);
        }

        float F = Mathf.Abs((blood6.transform.position - Camera.main.transform.position).magnitude);

        //Debug.Log(v);
        if (F <= k)
        {

            if (Physics.Raycast(ray, out hitinfo))
            {
                //큐브인가?

                if (hitinfo.collider.gameObject.name == "Blood6")
                {
                    //UI 띄운다.
                    press11.SetActive(true);
                    if (Input.GetButton("Fire1"))
                    {

                        fg = fg - speed;

                        blood5.GetComponent<Renderer>().material.color = new Color32(173, 32, 32, (byte)fg);



                        if (fg <= 0.0f)
                        {
                            blood6.SetActive(false);
                        }




                    }
                }

                else
                {
                    press11.SetActive(false);
                }





            }

        }
        else
        {
            press11.SetActive(false);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Tissue : MonoBehaviour
{

    private Animation anim;
    public float k;

    float a;


    public GameObject blood1;
   






    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animation>();
       

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


                    if (Input.GetButton("Fire1"))
                    {

                        

                        anim.Play("clean");






                    }
                   else anim.Stop("clean");
                   
                }

            }
        }
    }
}



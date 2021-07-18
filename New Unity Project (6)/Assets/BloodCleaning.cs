using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloodCleaning : MonoBehaviour
{
    public GameObject blood;
    public float speed = 1f;
    //// Start is called before the first frame update
    //public class Script1 : MonoBehaviour
    //{
    //    Renderer renderer;
    //    public GameObject target;
    //    void Start()
    //    {
    //        renderer = target.GetComponent<Renderer>();

    //    }

//        IEnumerator FadeOut()
//        {
//            int i = 10;
//            while (i > 0)
//            {
//                i -= 1;
//                float f = i / 10.0f;
//                Color c = renderer.material.color;
//                c.a = f;
//                renderer.material.color = c;
//                yield return new WaitForSeconds(0.02f);
//            }
//        }
//    }
//}


float i = 255.0f;
// Update is called once per frame
void Update()
{

    if (Input.GetButton("Fire1"))
    {

        i = i - speed;

        blood.GetComponent<Renderer>().material.color = new Color32(173, 32, 32, (byte) i);

        print(i);

        if (i == 0.0f)
        {
            blood.SetActive(false);
        }




    }
} }

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    CharacterController cc;
    public float moveSpeed = 0.1f;
    float dashSpeed;
    void Start()
    {
        moveSpeed = dashSpeed;
        cc = GetComponent<CharacterController>();

    }

    
    void FixedUpdate()
    {
        // 사용자의 상하좌우 입력 값을 받아온다.
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        


        float moveSpeed = 5.0f;
        float dashSpeed = 3.0f;
        // 받은 입력값을 방향값으로 만들고 싶다. 
        Vector3 direction = new Vector3(h, 0, v);
        direction.Normalize();

        //만일, 좌측 shift 버튼을 누르면...
        if (Input.GetKey(KeyCode.LeftShift))
        {
            // movespeed 변수의 값을 2배로 증가시킨다. 
            dashSpeed = moveSpeed * 1.2f;
        }
        //그렇지 않고, 좌측 shift 버튼을 떼면...
        else if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            //movespeed 변수의 값을 원래대로 한다.
            dashSpeed = moveSpeed;
        }
       


        direction = Camera.main.transform.TransformDirection(direction);
        direction = new Vector3(direction.x, 0, direction.z);
        transform.position += direction * dashSpeed * Time.deltaTime;
        cc.Move(direction * dashSpeed * Time.deltaTime);
      
    }
}




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
        // ������� �����¿� �Է� ���� �޾ƿ´�.
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        


        float moveSpeed = 5.0f;
        float dashSpeed = 3.0f;
        // ���� �Է°��� ���Ⱚ���� ����� �ʹ�. 
        Vector3 direction = new Vector3(h, 0, v);
        direction.Normalize();

        //����, ���� shift ��ư�� ������...
        if (Input.GetKey(KeyCode.LeftShift))
        {
            // movespeed ������ ���� 2��� ������Ų��. 
            dashSpeed = moveSpeed * 1.2f;
        }
        //�׷��� �ʰ�, ���� shift ��ư�� ����...
        else if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            //movespeed ������ ���� ������� �Ѵ�.
            dashSpeed = moveSpeed;
        }
       


        direction = Camera.main.transform.TransformDirection(direction);
        direction = new Vector3(direction.x, 0, direction.z);
        transform.position += direction * dashSpeed * Time.deltaTime;
        cc.Move(direction * dashSpeed * Time.deltaTime);
      
    }
}




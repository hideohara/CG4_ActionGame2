using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float moveSpeed = 3.0f;

        // �ړ��ʂ��l��
        Vector3 v = rb.velocity;

        // �E�ֈړ�
        if (Input.GetKey(KeyCode.RightArrow))
        {
            v.x = moveSpeed;
        }
        // ���ֈړ�
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            v.x = -moveSpeed;
        }
        // ������Ȃ���Β�~
        else
        {
            v.x = 0;
        }



        // �ړ��ʂ�ݒ�
        rb.velocity = v;



    }

    void Update()
    {
        float jumpSpeed = 8.0f;

        // �ړ��ʂ��l��
        Vector3 v = rb.velocity;

        // �W�����v
        if (Input.GetKeyDown(KeyCode.Space))
        {
            v.y = jumpSpeed;
        }

        // �ړ��ʂ�ݒ�
        rb.velocity = v;
    }



}

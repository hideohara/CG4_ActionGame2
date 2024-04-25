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

        // ˆÚ“®—Ê‚ğŠl“¾
        Vector3 v = rb.velocity;

        // ‰E‚ÖˆÚ“®
        if (Input.GetKey(KeyCode.RightArrow))
        {
            v.x = moveSpeed;
        }
        // ¶‚ÖˆÚ“®
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            v.x = -moveSpeed;
        }
        // ‰Ÿ‚³‚ê‚È‚¯‚ê‚Î’â~
        else
        {
            v.x = 0;
        }



        // ˆÚ“®—Ê‚ğİ’è
        rb.velocity = v;



    }

    void Update()
    {
        float jumpSpeed = 8.0f;

        // ˆÚ“®—Ê‚ğŠl“¾
        Vector3 v = rb.velocity;

        // ƒWƒƒƒ“ƒv
        if (Input.GetKeyDown(KeyCode.Space))
        {
            v.y = jumpSpeed;
        }

        // ˆÚ“®—Ê‚ğİ’è
        rb.velocity = v;
    }



}

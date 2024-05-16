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
        // ゲームクリアで移動しない
        if (GoalScript.isGameClear == true)
        {
            return;
        }


            float moveSpeed = 3.0f;

        // 移動量を獲得
        Vector3 v = rb.velocity;

        // 右へ移動
        if (Input.GetKey(KeyCode.RightArrow))
        {
            v.x = moveSpeed;
        }
        // 左へ移動
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            v.x = -moveSpeed;
        }
        // 押されなければ停止
        else
        {
            v.x = 0;
        }



        // 移動量を設定
        rb.velocity = v;



    }

    void Update()
    {
        // ゲームクリアで移動しない
        if (GoalScript.isGameClear == true)
        {
            return;
        }

        float jumpSpeed = 8.0f;

        // 移動量を獲得
        Vector3 v = rb.velocity;

        // ジャンプ
        if (Input.GetKeyDown(KeyCode.Space))
        {
            v.y = jumpSpeed;
        }

        // 移動量を設定
        rb.velocity = v;
    }



}

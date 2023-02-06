using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestController : MonoBehaviour
{
    public static bool isJump = false;

    public float speed = 10.0f;
    public float jumpForce = 1f;          // 점프하는 힘
    public GameObject checkCollider;
    private Animator ani;

    Rigidbody2D body;                         // 컴포넌트에서 RigidBody를 받아올 변수


    // Start is called before the first frame update
    void Start()
    {
        ani = GetComponent<Animator>();
        body = GetComponent<Rigidbody2D>();   // GetComponent를 활용하여 body에 해당 오브젝트의 Rigidbody를 넣어준다.
    }

    // Update is called once per frame
    void Update()
    {
        // 스페이스바를 누르면(또는 누르고 있으면)
        if (Input.GetKeyDown(KeyCode.Space))
        {
        ani.SetBool("isJump", true);
        // body에 힘을 가한다(AddForce)
        //AddForce(방향, 힘을 어떻게 가할 것인가)

        body.AddForce(Vector3.up * jumpForce, ForceMode2D.Impulse);
        }
    }
    public void BtnClicker()
    {
        if(DataManager.CanJump == true)
        {
            body.AddForce(Vector3.up * jumpForce, ForceMode2D.Impulse);
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Ground"))
            DataManager.CanJump = false;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Ground"))
            DataManager.CanJump = true;

        ani.SetBool("isJump", false);
    }
}

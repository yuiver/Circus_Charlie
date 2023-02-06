using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LionBoolCheck : MonoBehaviour
{

    private Animator ani;

    // Start is called before the first frame update
    void Start()
    {
        ani = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Ground"))
        ani.SetBool("ColliderCheck", false);
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Ground"))
            ani.SetBool("ColliderCheck", true);
    }
}

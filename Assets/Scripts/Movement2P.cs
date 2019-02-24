using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement2P : MonoBehaviour {

    Animator anim;
    public GameObject bullet;
    float input_x = 0;
    float input_y = -1f;
    public bool canMove = true;
    public float speed = 3f;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
        canMove = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (canMove)
        {
            input_x = Input.GetAxisRaw("Horizontal2");

            bool isWalking = Mathf.Abs(input_x) > 0;

            anim.SetBool("isWalking", isWalking);
            if (isWalking)
            {
                anim.SetFloat("x", input_x);

                transform.position += new Vector3(input_x, 0, 0).normalized * speed * Time.deltaTime;
            }

            if (Input.GetKeyDown("space"))
            {
                //Attack();
                anim.SetTrigger("Attack");
            }
        }
    }

    /*private void Attack()
    {
        if (anim.GetFloat("x") == 1)
        {
            GameObject b = Instantiate(bullet, new Vector3(transform.position.x + 0.15f, transform.position.y, 0), transform.rotation);
            Bullet bb = b.GetComponent<Bullet>();
            bb.x = 1f;
            bb.y = 0;
        }
        if (anim.GetFloat("x") == -1)
        {
            GameObject b = Instantiate(bullet, new Vector3(transform.position.x - 0.15f, transform.position.y, 0), transform.rotation);
            Bullet bb = b.GetComponent<Bullet>();
            bb.x = -1f;
            bb.y = 0;
        }

    }
    */
}

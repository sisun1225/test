using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class char_test : MonoBehaviour
{

    private Rigidbody2D rigidbody;

    private float speed = 3;

    private float horizontal;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");


        PlayMove();

        ScreenChk();
    }

    private void PlayMove()
    {
        rigidbody.velocity = new Vector2(horizontal * speed, rigidbody.velocity.y);


    }

    private void ScreenChk()
    {
        Vector3 worlpos = Camera.main.WorldToViewportPoint(this.transform.position);
        if (worlpos.x < 0.05f) worlpos.x = 0.05f;
        if (worlpos.x > 0.95f) worlpos.x = 0.95f;
        this.transform.position = Camera.main.ViewportToWorldPoint(worlpos);
    }

}

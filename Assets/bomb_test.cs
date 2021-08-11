using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bomb_test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            GameManager.instance.Score();
            Destroy(this.gameObject);
        }

        if (collision.gameObject.tag == "Player")
        {
     
            GameManager.instance.GameOver();
            Destroy(this.gameObject);
        }
    }

}

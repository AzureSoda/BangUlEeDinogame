using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class jump : MonoBehaviour
{
    Rigidbody2D rb;
        
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * 9;
        }
    //화면 터치하면 점프
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        SceneManager.LoadScene("GameoverScene");
    }
}

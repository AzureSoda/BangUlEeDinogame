using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Wall : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] GameObject[] Ground = new GameObject[2];
    [SerializeField] GameObject wall;
    [SerializeField] Text score;
    public static bool isGame = true;
    int score_cnt = 0;
    void Update()
    {
        if (isGame)
        {
            speed += 0.1f * Time.deltaTime;

            score_cnt += 1;
            score.text = "score: " + score_cnt.ToString();
            

            Move(wall);
            if (wall.transform.position.x < -5)
            {
                wall.transform.position = new Vector3(7, wall.transform.position.y, 0);
            }

            for (int i = 0; i < 2; i++)
            {
                Move(Ground[i]);
                if (Ground[i].transform.position.x <= -5)
                {
                    Ground[i].transform.position = new Vector3(2, Ground[i].transform.position.y, 0);
                }
            }
          }

    }
    void Move(GameObject obj)
    {
        obj.transform.Translate(new Vector2(-speed * Time.deltaTime, 0));
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            isGame = false;
            GetComponent<AudioSource>().Play();
         
        }
    }
   
}

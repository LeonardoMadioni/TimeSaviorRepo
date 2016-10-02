using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class destroyer_player : MonoBehaviour
{
    
    public  float velocityTimeProblem = 2f;
    
    void Start()
    {

        GetComponent<Rigidbody2D>().velocity = Vector2.right * velocityTimeProblem;
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player") SceneManager.LoadScene("Level");

    }

  
}

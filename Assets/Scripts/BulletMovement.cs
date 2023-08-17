using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    public GameObject gameController;
    
    private void Awake()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position+= Vector3.up * speed * Time.deltaTime;
        if (transform.position.y >= GlobalUser.screenHeight / 2 + 1f)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Aeteroid")
        {
            Destroy(this.gameObject);
        }
        else if (other.gameObject.tag == "Enemy")
        {
            Destroy(other.gameObject);
            GameController.score++;
            Debug.Log(GameController.score);
        }
        // {
        //     GameController.score++;
        //     Debug.Log(GameController.score);
        //     if (GameController.score == 10)
        //     {
        //         GameController.win();
        //     }
        // }
    }
}

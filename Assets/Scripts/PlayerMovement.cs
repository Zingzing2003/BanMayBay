using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public GameController GameController;
    private float horizontal;
    private float vertical;
    public float speedMove;
    [SerializeField] private float timeFire;
    private float timeF;
    [SerializeField] private GameObject bulletGameObject;
    [SerializeField] private Transform positionIns;

    // [SerializeField] private int hp;
    public Text textHp;
    
    // Update is called once per frame
    private void Awake()
    {
        timeF = timeFire;
    }

    void Update()
    {
        
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
        transform.position += new Vector3(horizontal, vertical, 0).normalized * speedMove * Time.deltaTime;
        if (transform.position.x < -GlobalUser.screenWidth / 2)
        {
            transform.position = new Vector3(-GlobalUser.screenWidth / 2, transform.position.y, transform.position.z);
        }
        else if (transform.position.x > GlobalUser.screenWidth / 2)
        {
            transform.position = new Vector3(GlobalUser.screenWidth / 2, transform.position.y, transform.position.z);
        }
        if (transform.position.y < -GlobalUser.screenHeight / 2)
        {
            transform.position = new Vector3(transform.position.x, -GlobalUser.screenHeight/2, transform.position.z);
        }
        else if (transform.position.y > GlobalUser.screenHeight / 2)
        {
            transform.position = new Vector3(transform.position.x, GlobalUser.screenHeight/2, transform.position.z);
        }
        timeF -= Time.deltaTime;
        if (timeF <= 0)
        {
            Fire();
            timeF= timeFire;
        }

       

        if (GameController.score == 10)
        {
            GameController.win();
            
        }
    }

    private void Fire()
    {
        Instantiate(bulletGameObject, positionIns.position, quaternion.identity);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            //lose
            
            Die();
            //Debug.Log("chet !");
        } 
        else if (col.gameObject.tag == "EnemyBullet")
        {
            Destroy(col.gameObject);
            //hp--;
            GameController.hp--;
            textHp.text = "HP : " + GameController.hp;
            if (GameController.hp <= 0)
            {
                //lose
                Die();
            }
        }
        else if (col.gameObject.tag == "Aeteroid")
        {
            Destroy(col.gameObject);
            Die();
        }
    }

    public void Die()
    {
        GameController.lose();
    }

    
}

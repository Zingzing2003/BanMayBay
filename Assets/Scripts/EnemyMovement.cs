using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float timeInsBullet;
    [SerializeField] private GameObject BulletGameobject;
   
    [SerializeField] private Transform pos;
    private float timeWait;

   
    private void Awake()
    {
        timeWait = timeInsBullet;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= Vector3.up * Time.deltaTime * speed;
        timeWait -= Time.deltaTime;
        if (timeWait <= 0)
        {
            Instantiate(BulletGameobject, pos.position, quaternion.identity);
            timeWait = timeInsBullet; 
        }

      

        if (transform.position.y <= -GlobalUser.screenHeight / 2 - 1f)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "PlayerBullet")
        {
            
            Destroy(this.gameObject);
            Destroy(col.gameObject);
        }
    }
}

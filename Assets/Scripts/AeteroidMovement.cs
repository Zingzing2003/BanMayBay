using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AeteroidMovement : MonoBehaviour
{

    [SerializeField] private float speed;
    // Update is called once per frame
    void Update()
    {
        transform.position -= Vector3.up * speed * Time.deltaTime;
        
        if (transform.position.y <= -GlobalUser.screenHeight / 2 - 1f)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        //if( other.gameObject.tag)
    }
}

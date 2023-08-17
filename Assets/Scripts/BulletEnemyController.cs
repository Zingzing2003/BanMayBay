using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEnemyController : MonoBehaviour
{
    [SerializeField] private float speed;

    // Update is called once per frame
    void Update()
    {
        this.transform.position -= Vector3.up * speed * Time.deltaTime;
        if (transform.position.y <= -GlobalUser.screenHeight / 2 - 1f)
        {
            Destroy(this.gameObject);
        }

    }
    
}

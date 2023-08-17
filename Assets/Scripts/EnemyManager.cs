using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemyManager : MonoBehaviour
{
    [SerializeField] private float timeInsEnemy;
    
    [SerializeField] private float timeInsEnemy2;
     private float timeWait ;
     private float timeWaitA;
     [SerializeField] private GameObject aeteroidGameobject;
     
    
     [SerializeField] private GameObject enemyGameObject;
    // Update is called once per frame
    private void Awake()
    {
        timeWait = timeInsEnemy;
        timeWaitA = timeInsEnemy2;
    }

    private void Update()
    {
        timeWait -= Time.deltaTime;
        timeWaitA -= Time.deltaTime;
        if (timeWaitA <= 0)
        {
            InsAeteroid();
            timeWaitA = timeInsEnemy2;
        }
        
        if (timeWait <= 0)
        {
            InsEnemy();

            timeWait = timeInsEnemy;
        }
        
    }

    void InsAeteroid()
    {
        Vector3 pos = new Vector3(Random.Range(-GlobalUser.screenWidth / 2 + 1f, GlobalUser.screenWidth / 2 - 1f),
            GlobalUser.screenHeight / 2 + 1f);
        Instantiate(aeteroidGameobject, pos, quaternion.identity);
    }
    void InsEnemy()
    {

        Vector3 pos = new Vector3(Random.Range(-GlobalUser.screenWidth / 2 + 1f, GlobalUser.screenWidth / 2 - 1f),
            GlobalUser.screenHeight / 2 - 1f);
        Instantiate(enemyGameObject, pos, quaternion.identity);
    }
}

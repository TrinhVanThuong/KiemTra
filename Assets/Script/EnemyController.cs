using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : PlaneController
{
    void Start()
    {
       EnemyMove();
    }

    void EnemyMove()
    {
         Vector3 endpoint = new Vector3( Random.Range(-180,180),Random.Range(-50,50) );
        MoveTo(endpoint,EnemyMove); 
    }

    // Update is called once per frame
    void Update()
    {
        Shoot();
       
    }
}

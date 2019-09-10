using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : PlaneController
{

       void Start()
    {
        
    }
    void Update() {
        Vector3 EndPoint = new Vector3(
            Input.mousePosition.x - Screen.width/2,
            Input.mousePosition.y - Screen.height/2
        );
        MoveUpdate(EndPoint);
        Shoot();
    }


    protected override void OnCollection(Collider2D collider)
    {

    }

}

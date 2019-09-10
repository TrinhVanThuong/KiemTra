using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : BehavierController
{
        [SerializeField]
    private PlaneController _Own;
    public void throwBullet(PlaneController Own)
    {
        _Own = Own;
        Vector3 EndPoint = this.transform.localPosition + Own.transform.up*1280;
        durationmove = Own.durationBulletThrow;
        MoveTo(EndPoint,()=>
        {
            Destroy(this.gameObject);
        });
    }
    void Update()
    {
        CheckCollider();
    }


}

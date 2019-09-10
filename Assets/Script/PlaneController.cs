using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlaneController : BehavierController
{
    [SerializeField]
    private int delayFrameToShoot = 10;

    [SerializeField]
    protected int Damage = 100;

    [SerializeField]

    protected int Defence = 50;
    public float durationBulletThrow;
    private int Framecount = 0;

   protected void Shoot()
    {
        if (Framecount < delayFrameToShoot)
        {
            Framecount++;
            return;
        } 
        Framecount = 0;
        
    }


}

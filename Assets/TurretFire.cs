using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretFire : MonoBehaviour
{
    public float TimeBetweenShots = 0.25f;
    void Start()
    {
        StartCoroutine(FireTimer());
    }

    public virtual void Fire()
    {

    }

    IEnumerator FireTimer()
    {
        while (true)
        {
            yield return new WaitForSeconds(TimeBetweenShots);
            Fire();
        }
    }
}

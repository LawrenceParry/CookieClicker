using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretAim : MonoBehaviour
{
    List<Transform> targets = new List<Transform>();
    bool firing = false;
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy" && !targets.Contains(other.transform))
        {
            targets.Add(other.transform);
            firing = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Enemy" && targets.Contains(other.transform))
        {
            targets.Remove(other.transform);
        }
    }

    void Update()
    {
        if (targets.Count!=0)
            transform.LookAt(targets[0]);
    }
}
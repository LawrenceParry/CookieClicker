using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float Speed = 3;
    void Update()
    {
        transform.Translate(transform.forward * Speed * Time.deltaTime);
    }
}

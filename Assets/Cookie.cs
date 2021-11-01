using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cookie : MonoBehaviour
{
    public int ClickValue = 30;
    public void Clicked()
    {
        ScoreController.IncreaseScore(ClickValue);
    }
}

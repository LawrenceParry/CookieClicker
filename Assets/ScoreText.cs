using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreText : MonoBehaviour
{
    Text textElement;
    const string suffix = " Cookies";
    void Start()
    {
        textElement = GetComponent<Text>();
        ScoreController.ScoreIncreased += ScoreAdded; 
    }
    void OnDestroy()
    {
        ScoreController.ScoreIncreased -= ScoreAdded;
    }

    public void ScoreAdded()
    {
        textElement.text = ScoreController.Score + suffix;
        StartCoroutine(Flash());
    }

    IEnumerator Flash()
    {
        textElement.color = Color.white;
        float alpha = 1;
        while (alpha > 0)
        {
            textElement.color = Color.Lerp(Color.black, Color.white, alpha);
            alpha -= Time.deltaTime * 6;
            yield return new WaitForEndOfFrame();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreUI : MonoBehaviour
{
    private TMP_Text text;
    void Awake()
    {
        text = GetComponent<TMP_Text>();
    }

   

    // Update is called once per frame
    void Update()
    {
        text.text = "Score: "+ScoreManager.instance.amount;
    }
}

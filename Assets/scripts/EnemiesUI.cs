using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EnemiesUI : MonoBehaviour
{
    private TMP_Text text;
    void Awake()
    {
        text = GetComponent<TMP_Text>();
        EnemiesManager.instance.onChanged.AddListener(RefreshText);
    }

   

    // Update is called once per frame
    void RefreshText()
    {
        text.text = "Remaining Enemies: "+EnemiesManager.instance.enemies.Count;
    }
}

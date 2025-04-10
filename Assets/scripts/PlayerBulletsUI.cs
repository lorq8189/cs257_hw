using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerBulletsUI : MonoBehaviour
{
    // Start is called before the first frame update

    private TMP_Text text;
    public PlayerShooting targetShooting;
    void Awake()
    {
        text = GetComponent<TMP_Text>();
    }

   

    // Update is called once per frame
    void Update()
    {
        text.text = "Bullets: "+targetShooting.bulletsAmount;
    }
}

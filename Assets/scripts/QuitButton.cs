using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuitButton : MonoBehaviour
{
    // Start is called before the first frame update
    public Button button;
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(Quit);
    }

    // Update is called once per frame
    void Quit()
    {
        print("Quitting");
        Application.Quit();
    }
}

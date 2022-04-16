using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stopwatch : MonoBehaviour
{
    
    float timer;
    float seconds;
    float minutes;

    [SerializeField] public Text stopWatchText;
    
    void Start()
    {
        timer = 0;

    }

    // Update is called once per frame
    void Update()
    {
        calculate();
    }

    void calculate() {
        timer += Time.deltaTime;
        seconds = (int)(timer % 60);
        minutes = (int)(timer / 60);

        stopWatchText.text = minutes.ToString("00") + ":" + seconds.ToString("00");
    }
}

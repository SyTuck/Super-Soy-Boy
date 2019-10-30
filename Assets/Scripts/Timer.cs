using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private Text timerText;

    private void Awake()
    {
        timerText = this.GetComponent<Text>();
    }

    private void Update()
    {
        timerText.text = System.Math.Round((decimal)Time.timeSinceLevelLoad, 2).ToString();
    }

}

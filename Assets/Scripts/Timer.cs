using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float timer = 0;

    public TextMeshProUGUI TextoTimer;
    private void Update()
    {
        timer += Time.deltaTime;
        TextoTimer.text = "" + timer.ToString("f0");
    }

}

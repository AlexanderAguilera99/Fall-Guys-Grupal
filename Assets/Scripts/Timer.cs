using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float timer = 0;

    public TextMeshProUGUI TextoTimer;

    private static bool created = false;

    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);

        if (!created)
        {
            created = true;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    void Update()
    {
        timer += Time.deltaTime;
        TextoTimer.text = "" + timer.ToString("f0");
    }
}
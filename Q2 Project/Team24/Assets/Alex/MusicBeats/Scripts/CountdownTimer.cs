using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;
using UnityEngine.UI;
using TMPro;
using System;

public class CountdownTimer : MonoBehaviour
{

    public string levelToLoad;
    private float timer = 45f;
    private TMP_Text timerSeconds;
        
    // Start is called before the first frame update
    void Start()
    {
        timerSeconds = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        timerSeconds.text = timer.ToString("f0");
        if (timer <= 0)
        {
            Application.LoadLevel(levelToLoad);
        }
    }
}

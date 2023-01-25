using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using System;

public class CountdownTimer : MonoBehaviour
{

    public string levelToLoad;
    private float timer = 10f; //Change this to 45f later
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
        timerSeconds.text = timer.ToString("f2");
        if (timer <= 0)
        {
            SceneManager.LoadScene("MainLevel");
        }
    }
}

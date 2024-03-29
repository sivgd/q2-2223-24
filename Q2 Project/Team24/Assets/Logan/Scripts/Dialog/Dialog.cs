using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using UnityEngine.SceneManagement;

public class Dialog: MonoBehaviour
{
    public GameObject dialogBox;
    public TMP_Text dialogText;
    public string dialog;
    public bool playerInRange;
    //public int CustomAction = 0;
    //public bool talkToFrog = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && playerInRange)
        {
            if (dialogBox.activeInHierarchy)
            {
                dialogBox.SetActive(false);
            }
            else
            {
                dialogBox.SetActive(true);
                //talkToFrog = true;
                dialogText.text = dialog;
                //if (CustomAction == 1 && talkToFrog == true)
                //{
                //    Invoke("CustomAction1", 3f);
                //}
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            playerInRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            playerInRange = false;
            dialogBox.SetActive(false);
        }
    }

    private void CustomAction1()
    {
        SceneManager.LoadScene("Level 1");
    }

}
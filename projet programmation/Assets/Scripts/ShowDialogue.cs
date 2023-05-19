using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowDialogue : MonoBehaviour
{
    public GameObject dialogue;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        dialogue.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        dialogue.SetActive(false);
    }
}

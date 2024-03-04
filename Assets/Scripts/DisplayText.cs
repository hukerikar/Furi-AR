using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class DisplayText : MonoBehaviour
{
    public GameObject textObject; // Reference to the text object

    void Start()
    {
        HideText(); // Initially hide the text
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Assuming "Player" is the tag for the camera or player object
        {
            ShowText(); // Show the text when the player enters the trigger area
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            HideText(); // Hide the text when the player exits the trigger area
        }
    }

    void ShowText()
    {
        textObject.SetActive(true); // Set the text object to be active/displayed
    }

    void HideText()
    {
        textObject.SetActive(false); // Set the text object to be inactive/hidden
    }
}

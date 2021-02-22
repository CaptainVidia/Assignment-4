using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class DisplayText : MonoBehaviour
{
    [SerializeField] private string textToDisplay;
    public void Display()
    {
        gameObject.GetComponent<Text>().text = textToDisplay;
    }
    public void Display(string text)
    {
        textToDisplay = text;
        Display();
    }
    public void Display(PlayerTriggerZones playerTriggerZones)
    {
        textToDisplay = "";
        textToDisplay += "Speed: ";
        textToDisplay += playerTriggerZones.speed;
        textToDisplay += "\n";
        textToDisplay += "Trigger Zone: ";
        textToDisplay += playerTriggerZones.triggerZones;
        Display();
    }

}

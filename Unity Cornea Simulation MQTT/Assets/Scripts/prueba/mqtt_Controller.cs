using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class mqtt_Controller : MonoBehaviour
{
    public string nameController = "Controller 1";

    public mqtt_Receiver _eventSender;

    void Start()
    {
        _eventSender.OnMessageArrived += OnMessageArrivedHandler;
    }

    private void OnMessageArrivedHandler(string newMsg)
    {
        Debug.Log("Event Fired. The message, from Object " +nameController+" is = " + newMsg);
    }

}
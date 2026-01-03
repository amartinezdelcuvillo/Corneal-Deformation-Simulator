using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataTranslator : MonoBehaviour
{
    mqttReceiver receiverScript;
    public string ReceivedMessage;

    // Start is called before the first frame update
    void Start()
    {
        receiverScript = FindObjectOfType<mqttReceiver>();
    }

    // Update is called once per frame
    void Update()
    {
        ReceivedMessage = receiverScript.msg; //Contiene el mensaje recibido (0,0,0)
        
    }
}

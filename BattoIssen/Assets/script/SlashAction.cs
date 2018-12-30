using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlashAction : MonoBehaviour
{
    private float PushTime;
    SignalActive signalgetFlag;
    GameObject signal;

    // Use this for initialization
    void Start()
    {
        signal = GameObject.Find("signal");
        signalgetFlag = signal.GetComponent<SignalActive>();
        Debug.Log(signal.name);
        //Debug.LogError("notfind");
        Debug.Log(signalgetFlag);
        Debug.Log(signal);
        PushTime = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        Slash();
    }

    private void Slash()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            Debug.Log("斬");
            PushTime += Time.realtimeSinceStartup;
            Debug.Log(PushTime);
            if (signalgetFlag.Signalflag == true)
            {
                
                Debug.Log("斬殺");
            }
            else
            {
                Debug.Log("no");
            }
            
        }
    }
}

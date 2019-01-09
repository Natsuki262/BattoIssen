using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlashAction : MonoBehaviour
{
    [SerializeField]
    GameObject m_signal;
    SignalActive m_signalActive;//攻撃開始の合図がたったかのフラグを取得するためのオブジェクト
    private float SlashAction_P1;
    private float SlashAction_P2;
    void Start()
    {
        m_signalActive = m_signal.GetComponent<SignalActive>();
    }

    // Update is called once per frame
    void Update()
    {
        Slash();
    }
    void Slash()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            if (m_signalActive.IsActive)
            {
                Debug.Log("<color=red>斬殺</color>");
                SlashAction_P1 = Time.realtimeSinceStartup;
                Debug.Log(SlashAction_P1 + "Player1");
               // m_signalActive.IsActive = false;
            }
            if (SlashAction_P1 <SlashAction_P2)
            {
                    Debug.Log("<color=red>P1Win</color>");
            }

        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (m_signalActive.IsActive)
            {
                Debug.Log("<color=blue>斬殺</color>");
                SlashAction_P2 = Time.realtimeSinceStartup;
                Debug.Log(SlashAction_P2 + "Player2");
                //m_signalActive.IsActive = false;
            }
            if (SlashAction_P1>SlashAction_P2)
            {
                Debug.Log("<color=blue>P2Win</color>");
            }

        }
    }
}

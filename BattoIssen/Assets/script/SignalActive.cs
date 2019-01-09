using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SignalActive : MonoBehaviour
{

    bool m_isActive = false; //アクティブになったか

    public bool IsActive
    {
        get
        {
            return m_isActive;
        }
        set
        {
            m_isActive = value;
        }
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
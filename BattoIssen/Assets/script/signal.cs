using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class signal : MonoBehaviour
{

    private float m_time = 0.0f; //経過時間を測る
    GameObject m_signal;
    void Awake()
    {
        m_signal = transform.GetChild(0).gameObject;
        m_signal.SetActive(false);
    }
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (m_time < 3.0f)
        {
            m_time += Time.deltaTime;
        }
        if (3.0f < m_time)
        {
            m_signal.SetActive(true);
            m_signal.GetComponent<SignalActive>().IsActive = true;
            Debug.Log("びっくりマーク出た");
            m_time = 3.0f;
        }
    }
}
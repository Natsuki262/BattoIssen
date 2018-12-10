using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SignalActive : MonoBehaviour 
{
   [SerializeField]
  private  GameObject signal;
   
       
    
    void Start ()
    {
        //signalObjct=GameObject.Find("signal");
       // Debug.Log(signalObjct);
        

       // gameObject.transform.Find("signal").gameObject.SetActive(true);
        //signal = GameObject.Find("signal");
        Debug.Log(signal);
        signal.SetActive(false);
        // IEnumerator Dela
        Invoke("Delay", 1.5f);
    }
   /* IEnumerator Delay()
    {
        yield return null;
        gameObject.transform.Find("signal").gameObject.SetActive(true);
    }*/

    // Update is called once per frame
    void Update ()
    {

        
    }
    void Delay()
    {
       signal.SetActive(true);
       

    }    
}

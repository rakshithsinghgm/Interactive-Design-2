using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class update_text : MonoBehaviour
{

    private string text_1="Hello";
    private string text_2 = "Hey";

    public GameObject partner_gameOjb;
    private Text self_txtComp;
    private  Text partner_txtComp;
    private void Start()
    {
         
            self_txtComp = this.GetComponent<Text>();
            partner_txtComp = partner_gameOjb.GetComponent<Text>();
            StartCoroutine(GetRequest_1(("https://www.rakshithsingh.com/chatbot/" + text_2),partner_txtComp));
            StartCoroutine(GetRequest_2(("https://www.rakshithsingh.com/chatbot/" + text_1), self_txtComp));
        
    }
    IEnumerator GetRequest_1(string uri,Text txt1)
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            UnityWebRequest uwr = UnityWebRequest.Get(uri);
            yield return uwr.SendWebRequest();

            if (uwr.isNetworkError)
            {
                Debug.Log("Error While Sending: " + uwr.error);
            }
            else
            {
                Debug.Log("Received: for gameobj " + uwr.downloadHandler.text);
            }
            text_2 = uwr.downloadHandler.text;
            txt1.text = text_2;
            if(text_2.Contains(" "))
            {
                text_2.Replace(" ", "%20");
            }
            uri = "https://www.rakshithsingh.com/chatbot/" + text_2;
        }

    }
    
    IEnumerator GetRequest_2(string uri, Text txt1)
    {
        while (true)
        {
            yield return new WaitForSeconds(2);
            UnityWebRequest uwr = UnityWebRequest.Get(uri);
            yield return uwr.SendWebRequest();

            if (uwr.isNetworkError)
            {
                Debug.Log("Error While Sending: " + uwr.error);
            }
            else
            {
                Debug.Log("Received: " + uwr.downloadHandler.text);
            }
            text_1 = uwr.downloadHandler.text;
            txt1.text = text_1;
            if (text_1.Contains(" "))
            {
                text_1.Replace(" ", "%20");
            }
            uri = "https://www.rakshithsingh.com/chatbot/" + text_1;
        }
    }
    /*
    IEnumerator GetRequest_2(string uri)
    {
        while (true)
        {
            yield return new WaitForSeconds(5);
            UnityWebRequest uwr = UnityWebRequest.Get(uri);
            yield return uwr.SendWebRequest();

            if (uwr.isNetworkError)
            {
                Debug.Log("Error While Sending: " + uwr.error);
            }
            else
            {
                Debug.Log("Received: " + uwr.downloadHandler.text);
            }
            text_2 = uwr.downloadHandler.text;
            txt_2.text = text_2;
        }

    }
    void Update()
    {
        //StartCoroutine(GetRequest("http://127.0.0.1:5000/response/requestfromupdate"));
    }*/

}
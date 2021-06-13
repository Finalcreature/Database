using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using System.IO;
using System.Text;

public class Test : MonoBehaviour
{
    [SerializeField] WWWForm form;
    void Start()
    {
        
    }

    public void SendJson(string json)
    {
        StartCoroutine(PostData_Coroutine(json));
    }

    IEnumerator PostData_Coroutine(string json)
    {
        string url = "http://193.46.199.76:8087";
        //form = new WWWForm();
        //form.AddField("username", "tami");
        //form.AddField("phone","972547932000");
        byte[] bodyRaw = Encoding.UTF8.GetBytes(json);

        //using (UnityWebRequest request = UnityWebRequest.Put(url, bodyRaw))
        using (UnityWebRequest request = UnityWebRequest.Post(url,json))
        {
            yield return request.SendWebRequest();
            if (request.isNetworkError || request.isHttpError)
                Debug.Log(request.error);
            else
                Debug.Log(request.downloadHandler.text);
        }

        
    }
}


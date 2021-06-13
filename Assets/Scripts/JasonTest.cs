using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;




public class JasonTest : MonoBehaviour
{
    Info myClass;

    private void Start()
    {
        myClass = new Info();
        myClass.username = "tami";
        myClass.phone = "972547932000";
        

        string jsonString = JsonUtility.ToJson(myClass);
      
        File.WriteAllText(Application.dataPath + "/jsonText.json", jsonString);
        print(jsonString);
        FindObjectOfType<Test>().SendJson(jsonString);
     
    }

    private class Info
    {
        public string username;
        public string phone;

    }

    //public void writeFile()
    //{
    //    string jsonString = JsonUtility.ToJson(myClass);

    //}
}






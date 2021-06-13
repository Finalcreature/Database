using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;




public class JasonTest : MonoBehaviour
{
    MyClass myClass;

    private void Start()
    {
        myClass = new MyClass();
        myClass.test = false;
        

        string jsonString = JsonUtility.ToJson(myClass);
        File.WriteAllText(Application.dataPath + "/jsonText.json", jsonString);
        print(jsonString);
     
    }

    private class MyClass
    {
        public bool test;
    }

    public void writeFile()
    {
        string jsonString = JsonUtility.ToJson(myClass);

    }
}






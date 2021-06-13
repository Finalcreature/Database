using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SocketIO;
using UnityEngine.Networking;

public class TestSocket : SocketIOComponent
{
    // Start is called before the first frame update
    public override void Start()
    {
        base.Start();
        //GameObject go = GameObject.Find("SocketIO");
        //SocketIOComponent socket = go.GetComponent<SocketIOComponent>();
        //socket.On("boop", TestBoop);

        
    }

    public override void Update()
    {
        base.Update();
    }

    public  void TestBoop(SocketIOEvent e)
    {
        Debug.Log("e");
        Debug.Log(string.Format("[name: {0}, data: {1}]", e.name, e.data));
    }
}


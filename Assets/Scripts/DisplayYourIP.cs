using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Net;
using Sourav.Utilities.Scripts.Attributes;

public class DisplayYourIP : MonoBehaviour
{
    string hostname = Dns.GetHostName();

    // Use this for initialization
    void Start ()
    {
        DisplayIP();
    }

    [Button()]
    private void DisplayIP()
    {
        Debug.Log("Hostname = " + hostname);
        try
        {
            IPAddress[] addrs = Dns.GetHostEntry(hostname).AddressList;
            foreach (IPAddress addr in addrs)
            {
                string str = string.Format("{0}/{1}", hostname, addr);
                Debug.Log(str);
            }
        }
        catch (Exception e)
        {
            Debug.Log(e.Message);
        }
    }
}

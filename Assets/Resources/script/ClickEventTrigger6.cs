using System;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class ClickEventTrigger6 : MonoBehaviour
{
    public void OnClick()
    {
        if (Chu.f6 == 0 && Chu.fn < 2)
        {
            GameObject.Find("Ji(Clone)").GetComponent<Fan6>().enabled = true;
            Chu.fn++;
            Invoke("juess", 1.1f);  //��ȫ��ת������ж�
        }
        
    }
    private void Update()
    {
        if (Chu.fan % 2 == 0 && (Chu.f6 == 1 && Chu.f66 == 0))
        {
            GameObject.Find("Ji(Clone)").GetComponent<Fan6>().enabled = true;
            Chu.f6 = 0;
            Chu.fn = 0;
        }
    }
    private void juess()  //��������жϵĺ��� 
    {
        if (Chu.f6 == 0)
        {
            Chu.f6++;
            Chu.fan++;
        }
        if (Chu.f6 == 1 && Chu.f66 == 1)
        {
            GameObject.Destroy(GameObject.Find("Ji(Clone)"), 0.2f);
            GameObject.Destroy(GameObject.Find("Ji1(Clone)"), 0.2f);
            Chu.fn = 0;
        }
    }
}

using System;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class ClickEventTrigger4 : MonoBehaviour
{
    public void OnClick()
    {
        if (Chu.f4 == 0 && Chu.fn < 2)
        {
            GameObject.Find("Gou(Clone)").GetComponent<Fan4>().enabled = true;
            Chu.fn++;
            Invoke("juess", 1.1f);  //��ȫ��ת������ж�
        }
        
    }
    private void Update()
    {
        if (Chu.fan % 2 == 0 && (Chu.f4 == 1 && Chu.f44 == 0))
        {
            GameObject.Find("Gou(Clone)").GetComponent<Fan4>().enabled = true;
            Chu.f4 = 0;
            Chu.fn = 0;
        }
    }
    private void juess()  //��������жϵĺ��� 
    {
        if (Chu.f4 == 0)
        {
            Chu.f4++;
            Chu.fan++;
        }
        if (Chu.f4 == 1 && Chu.f44 == 1)
        {
            GameObject.Destroy(GameObject.Find("Gou(Clone)"), 0.2f);
            GameObject.Destroy(GameObject.Find("Gou1(Clone)"), 0.2f);
            Chu.fn = 0;
        }
    }
}

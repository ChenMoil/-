using System;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class ClickEventTrigger : MonoBehaviour
{
    public void OnClick()
    {
        print("MyOnClick ����ˣ���" + this.name);
        GameObject.Find("HuanXiong").GetComponent<Fan>().enabled = true;
        Invoke("juess", 1.1f);  //��ȫ��ת������ж�
    }
    private void Update()
    {
        
    }
    private void juess()
    {
        
    }
}

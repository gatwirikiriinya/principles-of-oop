using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Observer : MonoBehaviour
{
    public static UnityEvent onLog = new UnityEvent();

    private void Start()
    {
        StartCoroutine("Log");  
    }

    private IEnumerator Log()
    {
        yield return new WaitForSeconds(2f);

        Debug.Log("Testing Testing Observer PAttern");

        onLog.Invoke();
    }
}

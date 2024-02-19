using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Interactable : MonoBehaviour
{
    public UnityEvent OnInteract;
    void Start()
    {
        
    }
    public void CallEvent()
    {
        OnInteract.Invoke();
   
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Notes : MonoBehaviour
{
    public UnityEvent OnDestroy;
    public UnityEvent OnInteract;
    public GameObject Note;
    public GameObject player;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DestroyEvent()
    {
        Note.transform.parent = null;
    }
   
    public void CallEvent()
    {
        Note.transform.parent = player.transform;
    }



   



}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Refactoring is done! You may enter safely
public class Activator : MonoBehaviour
{
    public Item child;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetChildState(bool state)
    {
        child.gameObject.SetActive(state);
    }
}

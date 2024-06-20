using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(ProgressBar))]
public class Progress : MonoBehaviour
{
    [SerializeField] 
    private float speed = 1;

    private ProgressBar progressBar;

    void Start()
    {
        progressBar = GetComponent<ProgressBar>();
    }

    void Update()
    {
        progressBar.Increase(Time.deltaTime * speed);
    }
}

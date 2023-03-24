using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class time : MonoBehaviour
{

    private TextMeshPro ClockText;
    private TextMeshProUGUI ClockUGUI;
    private TMP_Text tmp_Text;

    // Use this for initialization
    void Start()
    {
        ClockText = GetComponentInChildren<TextMeshPro>();
    }

    // Update is called once per frame
    void Update()
    {
        ClockText.text = DateTime.Now.ToLongTimeString();
    }
}
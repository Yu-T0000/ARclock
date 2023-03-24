using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vb_memo : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject vbBtnObj;
    public GameObject memo;
    public GameObject memo1;


    // Start is called before the first frame update
    void Start()
    {
        vbBtnObj = GameObject.Find("1");
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        memo.SetActive(false);
        memo1.SetActive(false);


    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        memo.SetActive(true);
        memo1.SetActive(true);
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        memo.SetActive(false);
        memo1.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

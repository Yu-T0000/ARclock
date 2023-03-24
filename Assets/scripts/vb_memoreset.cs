using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using TMPro;

public class vb_memoreset : MonoBehaviour, IVirtualButtonEventHandler { 

    public GameObject vbBtnObj2;
    public GameObject inputFieldObj;  //InputField本体取得
    public TMP_InputField inputField;     //InputField取得
    public TMP_Text playerText;


    // Start is called before the first frame update
    void Start()
    {
        vbBtnObj2 = GameObject.Find("2");
        vbBtnObj2.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);


    }

    public void OnButtonPressed(VirtualButtonBehaviour vb2)
    {
        inputField.text = "";
        playerText.text = inputField.text;
        inputFieldObj.SetActive(true);
    }


    // Update is called once per frame
    void Update()
    {

    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        
    }
}

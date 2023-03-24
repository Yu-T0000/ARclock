using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class input : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject inputFieldObj;  //InputField本体取得
    public TMP_InputField inputField;     //InputField取得
    public TMP_Text playerText;           //プレイヤーテキスト取得

    public void TextReflect()
    {
        playerText.text = inputField.text;
        inputFieldObj.SetActive(false);
    }
}

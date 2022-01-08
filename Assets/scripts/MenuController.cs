using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    string code = "";
    public int codeLength;
    public Text intoClue;
    public LockScreen lockCode;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < codeLength; i++)
        {
            code += ((uint)Random.Range(1, 10)).ToString();
        }
        
    }

    public void StartButton()
    {
        lockCode.code = code;
        intoClue.text = code;
        Debug.Log("code is " + code);
    }
}

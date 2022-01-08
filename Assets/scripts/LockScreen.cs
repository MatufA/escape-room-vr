using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class LockScreen : MonoBehaviour
{
    public UnityEvent unlock;
    public string code = "1234";
    string currentCode;

    public Text m_codeDisplay;
    void KeyEntry(string key)
    {
        currentCode += key;
        if (currentCode == code)
        {
            m_codeDisplay.text = currentCode;
            unlock.Invoke();
        }
        else if (currentCode.Length == code.Length)
        {
            currentCode = "";
            m_codeDisplay.text = currentCode;
        }
        else
        {
            m_codeDisplay.text = currentCode;
        }
    }
}
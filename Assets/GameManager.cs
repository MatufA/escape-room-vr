using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager instance;

    private string doorKeyCode = "2395";
    private string RecivedDoorKeyCode = "";

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        } 
        else
        {
            Destroy(gameObject);
        }
    }

    public void RecivedDoorKey(string key)
    {
        RecivedDoorKeyCode += key;
        print(RecivedDoorKeyCode);
        if (RecivedDoorKeyCode.Length == 4)
        {
            if(doorKeyCode == RecivedDoorKeyCode)
            {
                print("Door Open");
            }
            else
            {
                RecivedDoorKeyCode = "";
            }
        }
    }
    
}

using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class ButtonPress : MonoBehaviour
{
    public Transform downTransform;
    public Transform buttonMesh;

    public GameObject lockPad;
    public string key;

    private Vector3 initialPosition;

    private void Start()
    {
        initialPosition = transform.position;
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            lockPad.SendMessage("KeyEntry", key);
            print(key);
            buttonMesh.position = downTransform.position;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            buttonMesh.localPosition = initialPosition;
        }
    }

    public void OnCodeButtonClicked()
    {
        transform.position = downTransform.position;
        GameManager.instance.RecivedDoorKey(key);
        StartCoroutine(ReturnPosition());
    }

    private IEnumerator ReturnPosition()
    {
        yield return new WaitForSeconds(1f);
        transform.position = initialPosition;
    }

}
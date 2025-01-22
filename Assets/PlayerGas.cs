using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerGas : MonoBehaviour
{
    public int gasGage = 100;
    public float targetTime = 0.1f;
    public int unitGas = 10;
    public TMP_Text gasText;

    public GameObject[] activeObjects;

    
    
    public void Start()
    {
        StartCoroutine(UsingGas());
    }

    IEnumerator UsingGas()
    {
        while(true)
        {
            yield return new WaitForSeconds(1f);
            LostGasGage(unitGas);
        }
    }
    
    public void GetGasGage(int gage)
    {
        gasGage += gage;
        gasText.text =  gasGage.ToString();
    }
    public void LostGasGage(int gage)
    {
        gasGage -= gage;
        
        if (gasGage <= 0)
        {
            GameOver();
        }
        gasText.text = gasGage.ToString();
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Gas"))
        {
            GetGasGage(30);
            Destroy(other.gameObject);
        }
    }

    public void GameOver()
    {
        foreach (var obj in activeObjects)
        {
            obj.SetActive(true);
        }
    }

    public void setGaseMax()
    {
        gasGage = 110;
    }
}

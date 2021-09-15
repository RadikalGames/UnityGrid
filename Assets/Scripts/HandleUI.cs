using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HandleUI : MonoBehaviour
{
    [SerializeField]
    private InputField xField;
    [SerializeField]
    private InputField yField;
    [SerializeField]
    private InputField zField;
    [SerializeField]
    private GenerateGrid gg;
    [SerializeField]
    GameObject GenerateButton;
    [SerializeField]
    GameObject Labeltext;

   public void SendForGeneration()
    {

        int i, j, k;
        try
        {
            i = int.Parse(xField.text);
             j = int.Parse(yField.text);
            k = int.Parse(zField.text);
        }
        catch (FormatException e)
        {
            i = 4;
            j = 4;
            k = 4;
        }
        gg.Generate(i, j, k);
        DisableUI();
    }

    private void DisableUI()
    {
        xField.gameObject.SetActive(false);
        yField.gameObject.SetActive(false);
        zField.gameObject.SetActive(false);
        Labeltext.SetActive(false);
        GenerateButton.SetActive(false);
    }
}


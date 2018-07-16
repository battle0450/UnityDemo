using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextSlow : MonoBehaviour {
    private Text uiText;
    private string words;
    private float timer;
    private bool isPrint = false;
    public float perCharSpeed;
    public int length = 20;
    public int i = 1;
	// Use this for initialization
	void Start () {
        uiText = GetComponent<Text>();
        words = GetComponent<Text>().text;
        isPrint = true;
	}
	
	// Update is called once per frame
	void Update () {
        printText();
	}
    void printText()
    {
            if (isPrint)
            {
                if (words.Length > length)
                {
                    uiText.text = words.Substring(0, length);
                    isPrint = false;
                }
            }
        try
        {
            if (Input.GetMouseButtonDown(0))
                {
                    uiText.text = " ";
                    uiText.text = words.Substring(0 + length * i, length);
                    i++;
                }
        }
        catch (System.Exception)
        {
            uiText.text = " ";
            uiText.text = words.Substring(0 + length * i, words.Length - (0 + length * i));
        }
    }
}

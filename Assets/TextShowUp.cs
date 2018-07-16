using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextShowUp : MonoBehaviour {
    public GameObject ShowObj_1;
    public GameObject ShowObj_2;
    public GameObject ShowObj_3;
    public GameObject ShowObj_4;
    public GameObject DelObj_1;
    public GameObject DelObj_2;
    public float timer;
	// Use this for initialization
	void Start () {
    }
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        if(timer > 2)
        {
            ShowObj_1.SetActive(true);
        }
        if(timer > 4)
        {
            DelObj_1.SetActive(false);
            DelObj_2.SetActive(false);
        }
        if(timer > 6)
        {
            ShowObj_2.SetActive(true);
        }
        if(timer > 8)
        {
            ShowObj_2.SetActive(false);
            ShowObj_3.SetActive(true);
        }
        if (timer > 10)
        {
            ShowObj_4.SetActive(true);
        }
        if(timer > 13)
        {
            Application.LoadLevel(2);
        }
	}
}

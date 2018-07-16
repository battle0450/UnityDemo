using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonScale : MonoBehaviour {
    Vector2 offMax;
    Vector2 offMin;
    RectTransform myRT;
    // Use this for initialization
    void Start () {
        myRT = transform as RectTransform;
        offMax = myRT.offsetMax;
        offMin = myRT.offsetMin;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OnSelect(BaseEventData data)
    {
        myRT.offsetMax = offMax * 1.1f;
        myRT.offsetMin = offMin * 1.1f;
        Debug.Log(gameObject.name + " Selected");
    }
    public void OnDeselect(BaseEventData data)
    {
        myRT.offsetMax = offMax;
        myRT.offsetMin = offMin;
        Debug.Log(gameObject.name + " Deselected");
    }
}

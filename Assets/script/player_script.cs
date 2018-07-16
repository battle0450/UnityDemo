using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_script : MonoBehaviour {
    
    public float maxSpeed = 2f;  //最大移動速度，因為變數為public, 可以直接在unity介面去更改    
    bool facingLeft = true;  //人物是否面朝左邊    
   // Animator anim;  //動畫資訊變數


    // Use this for initialization
    void Start () {
        
        //anim = GetComponent<Animator>();  //抓取該物件的動畫資訊
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void FixedUpdate()
    {        
        float move = Input.GetAxis("Horizontal");  //抓取左右方向按鍵，右向為+1，左向為-1        
        GetComponent<Rigidbody2D>().velocity = new Vector3(move * maxSpeed, GetComponent<Rigidbody2D>().velocity.y, 0);  //使用rigidbody物理引擎移動物件
        
        //anim.SetFloat("Speed", Mathf.Abs(move));  //將角色移動的速度量，設定到之前動畫的Speed變數
        
        if (move < 0 && !facingLeft)  //判斷動畫是否需要翻轉
        { Flip(); }
        else if (move > 0 && facingLeft)
        { Flip(); }
    }

    //看機器人是否面朝運動方向，不是則翻轉
    void Flip()
    {
        facingLeft = !facingLeft;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameover : MonoBehaviour
{
    //Gameover_texteというゲームオブジェクトの変数を作成
    public GameObject Gameover_text;
    public GameObject Retry_Bt;
    public score scoreComp; 

    //何かと触れるとゲームオーバーと表示
    void OnCollisionEnter2D (Collision2D coll){
        scoreComp.isGame = false;
        Gameover_text.SetActive (true);
        Retry_Bt.SetActive (true);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

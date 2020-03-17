using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//UIを使うために宣言
using UnityEngine.UI;

public class score : MonoBehaviour
{

    //変数作成
    int Point;
    public bool isGame = true;

    // Start is called before the first frame update
    void Start()
    {
        //点数を0にリセット
        Point = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isGame)
        {
            return;
        }
        //1秒毎に1ポイント加算
        if (Time.frameCount % 60 == 0)
        {
            Point++;
        }
        
        //PointTextに点数のテキストを更新
        gameObject.GetComponent<Text>().text = "Point : " + Point.ToString();
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloneObstacle : MonoBehaviour
{
    public GameObject ob1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //フレーム数を60で割ったあまりが0なら、ob1のクローンを作る（1secに1個生成）
        if(Time.frameCount % 60 == 0)
        {
            Instantiate(ob1);
        }
    }
}

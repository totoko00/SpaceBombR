using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSystem : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //スタートボタン挙動
    public void StartGame(){ //StartGameメソッドは自前のものなので適当な名前に設定
        SceneManager.LoadScene("SpaceBombR");
    }
}

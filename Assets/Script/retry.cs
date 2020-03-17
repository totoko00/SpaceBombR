using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

using UnityEngine.SceneManagement;

public class retry : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Button> ().onClick.AddListener (ReloadGame);
        
    }

    void ReloadGame()
    {
        //SpaceBombRという今のsceneを読み込み直す
        SceneManager.LoadScene("SpaceBombR");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameRestarter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //どんなキーでも入力があった場合スタートシーンに戻す
        if(Input.anyKey)
        {
            SceneManager.LoadScene("Start");
        }
    }
}

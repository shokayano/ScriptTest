using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kadai : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        // 要素数5の配列を初期化する
        int[] kadai = new int[5];

        // 配列の各要素に値を代入する
        kadai[0] = 11;
        kadai[1] = 22;
        kadai[2] = 33;
        kadai[3] = 44;
        kadai[4] = 55;

        // 配列の各要素の値を順番に表示する
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(kadai[i]);
        }

        // 配列の各要素の値を逆順に表示する
        for (int i = 4; i >= 0; i--)
        {
            Debug.Log(kadai[i]);
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}

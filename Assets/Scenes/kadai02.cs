using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int mp = 53; // 魔法力

    // 魔法用の関数
    public void Magic(int Magic)
    {
        if (this.mp < Magic)
        {
            Debug.Log("MPが足りないため魔法が使えない。" + this.mp);
        }
        else
        {
            // 残りmpを減らす
            this.mp -= Magic;

            Debug.Log("魔法攻撃をした。残りMPは" + this.mp + "。");
        }
    }
}


public class kadai02 : MonoBehaviour
{

    void Start()
    {
        // Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();

        for (int i = 0; i < 10; i++)
        {
            // 魔法用の関数を呼び出す
            lastboss.Magic(5);
        }
        lastboss.Magic(5);
    }

    // Update is called once per frame
    void Update()
    {

    }
}

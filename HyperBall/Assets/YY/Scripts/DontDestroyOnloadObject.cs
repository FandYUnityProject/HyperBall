/* -クラスの説明-
 * =======================================================
 *  DontDestroyOnloadObject.cs
 *  作成日：2016/1/17
 *  作成者：Yamaguchi Yohei
 *
 * 【機能】
 *  シーン遷移してもオブジェクトを消滅させない
 ========================================================== */

using UnityEngine;

public class DontDestroyOnloadObject : MonoBehaviour {

    void Awake()
    {
        // シーン遷移してもオブジェクトを消滅させない
        DontDestroyOnLoad(this);
    }
}

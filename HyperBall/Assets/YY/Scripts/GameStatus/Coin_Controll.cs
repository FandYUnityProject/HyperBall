/* -クラスの説明-
 * =======================================================
 *  Coin_Controll.cs
 *  作成日：2016/1/23
 *  作成者：Yamaguchi Yohei
 *
 * 【機能】
 *  取得コイン数の表示を行う
 ========================================================== */

using UnityEngine;
using UnityEngine.UI;

public class Coin_Controll : MonoBehaviour {
    
    private GameObject CointCount_Text;

    public static int GetCoin = 0;
    public static GameObject CointCountText;

    // 取得したコイン数を初期化
    void Start () {
        CointCount_Text = GameObject.Find("CointCount_Text");
        GetCoin = 0;
        CointCountText = CointCount_Text;
    }

    /// <summary>
    /// コインを取得したらカウントアップし、コイン数を表示します。
    /// </summary>
    public static void GetCoinEvent(){
        GetCoin++;
        CointCountText.GetComponent<Text>().text = GetCoin + " / 8";
        DebugInfo_Manager.DebugInfo_Update("現在のコイン数は" + CointCountText.GetComponent<Text>().text + "です。");
    }
}

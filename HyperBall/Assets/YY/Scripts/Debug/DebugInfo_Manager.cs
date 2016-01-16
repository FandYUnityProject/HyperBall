/* -クラスの説明-
 * =======================================================
 *  DebugInfo_Manager.cs
 *  作成日：2016/1/16
 *  作成者：Yamaguchi Yohei
 *
 * 【機能】
 *  ・デバッグ情報キャンバスの管理
 ========================================================== */

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DebugInfo_Manager : MonoBehaviour {

    public static string Debug_NetworkInfo_Str = "";
    public static bool isDebugInfo_Mode = false;

    public GameObject _DebugInfo_Canvas;
    public GameObject _DebugInfo_Text;
    
	void Update () {

        if(Input.GetKeyDown(KeyCode.F1))
        {
            isDebugInfo_Mode = !isDebugInfo_Mode;
        }

        // デバッグモード時
        if(isDebugInfo_Mode)
        {
            _DebugInfo_Canvas.SetActive(true);
            _DebugInfo_Text.GetComponent<Text>().text = Debug_NetworkInfo_Str;
        } else
        {
            _DebugInfo_Canvas.SetActive(false);
        }
    }
    
    /// <summary>
    /// デバッグのメッセージを追加します。
    /// </summary>
    /// <param name="message">追加するメッセージ</param>
    public static void DebugInfo_Update(string message)
    {
        Debug_NetworkInfo_Str += "\n" + message;
    }
}

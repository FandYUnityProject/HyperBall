/* -クラスの説明-
 * =======================================================
 *  Option_Menu_Controll.cs
 *  作成日：2016/1/23
 *  作成者：Yamaguchi Yohei
 *
 * 【概要】
 *  オプションメニューの表示/非表示を管理
 ========================================================== */

using UnityEngine;

public class Option_Menu_Controll : MonoBehaviour {

    public static bool isOption_MenuOpen = false;
    public static GameObject Option_Menu_Canvas;

    void Start() {
        // 初期化
        Option_Menu_Canvas = GameObject.Find("Option_Menu_Canvas");
        isOption_MenuOpen = false;
    }

    void Update() {
        // オプション表示/非表示(シーン遷移時で無い時)
        if (isOption_MenuOpen){ Option_Menu_Canvas.SetActive(true); }
        else { Option_Menu_Canvas.SetActive(false); }
    }
}

/* -クラスの説明-
 * ============================================================
 *  Return_GameSelectScene_Button.cs
 *  作成日：2016/1/30
 *  作成者：Yamaguchi Yohei
 *
 * 【概要】
 *  "Return_GameSelectScene_Button"押下時にメインメニューへ戻る
 ============================================================== */

using UnityEngine;

public class Return_GameSelectScene_Button : MonoBehaviour {

    public void Click_Return_GameSelectScene_Button() {
        FreeModeScene_Controll.Return_GameSelectScene_Button_Event();
    }
}

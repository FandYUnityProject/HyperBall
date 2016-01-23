/* =========================================================
 * -Info-
 *  Return_Option_Button.cs
 *  作成日：2015/12/29
 *  作成者：Yamaguchi Yohei
 *
 * 【機能】
 *  "戻る"ボタン押下時にオプションメニューを閉じる
 ========================================================== */

using UnityEngine;
using System.Collections;

public class Return_Option_Button : MonoBehaviour {

    public void OnClick_Return_Option_Button()
    {
        Option_Menu_Controll.isOption_MenuOpen = false;
    }
}

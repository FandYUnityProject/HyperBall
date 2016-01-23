/* =========================================================
 * -Info-
 *  Option_Button.cs
 *  作成日：2015/12/29
 *  作成者：Yamaguchi Yohei
 *
 * 【機能】
 *  "Option"ボタン押下時にオプションメニューを開く
 ========================================================== */

using UnityEngine;
using System.Collections;

public class Option_Button : MonoBehaviour {

	public void OnClick_Option_Button()
    {
        Option_Menu_Controll.isOption_MenuOpen = true;
    }
}
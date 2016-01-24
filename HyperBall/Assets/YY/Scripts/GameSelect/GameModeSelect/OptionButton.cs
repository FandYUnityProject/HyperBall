/* -クラスの説明-
 * =======================================================
 *  OptionButton.cs
 *  作成日：2016/1/23
 *  作成者：Yamaguchi Yohei
 *
 * 【概要】
 *  オプションメニューを表示させる
 ========================================================== */

using UnityEngine;

public class OptionButton : MonoBehaviour {

    public void OnClick_OptionButton() {
        Option_Menu_Controll.isOption_MenuOpen = true;
    }
}

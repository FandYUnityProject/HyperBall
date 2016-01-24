/* -クラスの説明-
 * ============================================================
 *  Game_PressButton_Button.cs
 *  作成日：2016/1/24
 *  作成者：Yamaguchi Yohei
 *
 * 【概要】
 *  "Return_GameModeSelect_Button"押下時にゲームモードボタンを表示
 =============================================================== */

using UnityEngine;
using System.Collections;

public class Return_GameModeSelect_Button : MonoBehaviour {

    public void Click_Return_GameModeSelect_Button()  {
        GameSelectScene_Controll.Return_GameModeSelect_Button_Event();
    }
}

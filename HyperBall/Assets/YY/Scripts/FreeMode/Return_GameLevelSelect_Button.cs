/* -クラスの説明-
 * =================================================================
 *  Return_GameLevelSelect_Button.cs
 *  作成日：2016/1/30
 *  作成者：Yamaguchi Yohei
 *
 * 【概要】
 *  "Return_GameLevelSelect_Button"押下時にゲームレベル選択画面に戻る
 =================================================================== */

using UnityEngine;

public class Return_GameLevelSelect_Button : MonoBehaviour
{
    public void Click_Return_GameLevelSelect_Button() {
        FreeModeScene_Controll.Return_GameLevelSelect_Button_Event();
    }
}

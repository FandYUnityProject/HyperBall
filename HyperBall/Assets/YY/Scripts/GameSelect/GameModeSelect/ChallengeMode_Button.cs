/* -クラスの説明-
 * =======================================================
 *  Game_PressButton_Button.cs
 *  作成日：2016/1/24
 *  作成者：Yamaguchi Yohei
 *
 * 【概要】
 *  "ChallengeMode_Button"押下時にゲームレベルボタンを表示
 ========================================================== */

using UnityEngine;

public class ChallengeMode_Button : MonoBehaviour {

    public void Click_ChallengeMode_Button() {
        GameSelectScene_Controll.ChallengeMode_Button_Event();
    }
}

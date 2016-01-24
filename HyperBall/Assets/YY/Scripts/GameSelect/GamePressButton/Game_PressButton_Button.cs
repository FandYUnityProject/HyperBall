/* -クラスの説明-
 * =======================================================
 *  Game_PressButton_Button.cs
 *  作成日：2016/1/24
 *  作成者：Yamaguchi Yohei
 *
 * 【概要】
 *  "PressButton"押下時にモードとオプションボタンを表示
 ========================================================== */

using UnityEngine;

public class Game_PressButton_Button : MonoBehaviour {

	public void Click_Game_PressButton_Button() {
        GameSelectScene_Controll.PressButton_Event();
    }
}

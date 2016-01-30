/* -クラスの説明-
 * =======================================================
 *  FreeMode_Easy_Button.cs
 *  作成日：2016/1/30
 *  作成者：Yamaguchi Yohei
 *
 * 【概要】
 *  "FreeMode_Easy_Button"押下時にEasyStage選択用の画面を表示
 ========================================================== */

using UnityEngine;

public class FreeMode_Easy_Button : MonoBehaviour {

    public void Click_FreeMode_Easy_Button() {
        FreeModeScene_Controll.FreeMode_Easy_Button_Event();
    }
}

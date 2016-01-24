/* -クラスの説明-
 * =======================================================
 *  FreeMode_Button.cs
 *  作成日：2016/1/24
 *  作成者：Yamaguchi Yohei
 *
 * 【概要】
 *  "Easy_Button"押下時に"EasyStage_1"画面へ遷移
 ========================================================== */

using UnityEngine;

public class Easy_Button : MonoBehaviour {

    public void Click_Easy_Button() {
        SceneTransition_Controll.NextScene_Transition("EasyStage_1");
    }
}

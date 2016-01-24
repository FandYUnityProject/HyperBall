/* -クラスの説明-
 * =======================================================
 *  FreeMode_Button.cs
 *  作成日：2016/1/24
 *  作成者：Yamaguchi Yohei
 *
 * 【概要】
 *  "Normal_Button"押下時に"NormalStage_1"画面へ遷移
 ========================================================== */

using UnityEngine;

public class Normal_Button : MonoBehaviour {

    public void Click_Normal_Button() {
        SceneTransition_Controll.NextScene_Transition("NormalStage_1");
    }
}

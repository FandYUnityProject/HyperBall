/* -クラスの説明-
 * =======================================================
 *  FreeMode_Button.cs
 *  作成日：2016/1/24
 *  作成者：Yamaguchi Yohei
 *
 * 【概要】
 *  "Hard_Button"押下時に"HardStage_1"画面へ遷移
 ========================================================== */

using UnityEngine;

public class Hard_Button : MonoBehaviour {

    public void Click_Hard_Button() {
        SceneTransition_Controll.NextScene_Transition("HardStage_1");
    }
}

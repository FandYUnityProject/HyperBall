/* -クラスの説明-
 * =======================================================
 *  FreeMode_Button.cs
 *  作成日：2016/1/24
 *  作成者：Yamaguchi Yohei
 *
 * 【概要】
 *  "FreeMode_Button"押下時にフリーモード画面へ遷移
 ========================================================== */

using UnityEngine;

public class FreeMode_Button : MonoBehaviour {

    public void Click_FreeMode_Button() {
        GameSelectScene_Controll.FreeMode_Button_Event();
    }
}

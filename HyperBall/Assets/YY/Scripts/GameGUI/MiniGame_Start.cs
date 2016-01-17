/* =========================================================
 * -Info-
 *  MiniGame_Start.cs
 *  作成日：2016/01/02
 *  作成者：Yamaguchi Yohei
 *
 * 【機能】
 *  ミニゲーム開始時に"START"の文字を表示
 ========================================================== */

using UnityEngine;

public class MiniGame_Start : MonoBehaviour {

    void Start() {
        // 初期化
        Operation_Permission_Controll._isOperation_Permission = false;

        // "START"の文字を表示
        Invoke("MiniGame_Start_Init", 0.8f);
        Invoke("MiniGame_Start_Final", 2.0f);
    }

    // "START"のイメージをアニメーション表示
    void MiniGame_Start_Init() {
        DebugInfo_Manager.DebugInfo_Update("\n========== ゲーム開始！ ==========");
        iTween.ScaleTo(gameObject, iTween.Hash("x", 1.0f, "y", 1.0f, "z", 1.0f, "time", 0.8f));
    }

    // "START"イメージの非表示アニメーション
    void MiniGame_Start_Final() {
        iTween.ScaleTo(gameObject, iTween.Hash("x", 1.0f, "y", 0.0f, "z", 1.0f, "time", 0.8f, "oncomplete", "StartImage_End"));
    }

    // "START"イメージの非表示アニメーション終了後、操作を許可
    void StartImage_End() {
        DebugInfo_Manager.DebugInfo_Update("操作を許可します。");
        Operation_Permission_Controll._isOperation_Permission = true;
    }
}

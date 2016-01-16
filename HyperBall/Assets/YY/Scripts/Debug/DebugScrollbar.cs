/* =========================================================
 * -Info-
 *  DebugScrollbar.cs
 *  作成日：2015/12/29
 *  作成者：Yamaguchi Yohei
 *
 * 【機能】
 *  全シーンで使用するグローバル変数を管理
 ========================================================== */

using UnityEngine;
using UnityEngine.UI;

public class DebugScrollbar : MonoBehaviour {

    // 変数宣言
    private float _scrollbarSize_Before = 1;    // 前フレームのスクロールバーのサイズ
    private float _scrollbarSize = 1;           // 現在のスクロールバーのサイズ
    private float _scrollbarSize_Distance = 1;  // 更新前後のスクロールバーのサイズ差

    void Update () {

        // スクロールバーのサイズ差を確認（メッセージが更新されたか）
        _scrollbarSize_Distance = _scrollbarSize_Before - _scrollbarSize;

        // メッセージが更新されたらスクロールバーを一番下に設定
        if (_scrollbarSize_Distance > 0.01 || _scrollbarSize_Distance < -0.01) {
            this.GetComponent<Scrollbar>().value = 0;
            _scrollbarSize_Before = _scrollbarSize;
        }

        // 現在のスクロールバーのサイズを取得
        _scrollbarSize = this.GetComponent<Scrollbar>().size;
    }
}

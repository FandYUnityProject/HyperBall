/* -クラスの説明-
 * =======================================================
 *  Timer_Controll.cs
 *  作成日：2016/1/23
 *  作成者：Yamaguchi Yohei
 *
 * 【機能】
 *  ステージ毎のクリアタイマー処理を行う
 ========================================================== */

using UnityEngine;
using UnityEngine.UI;

public class Timer_Controll : MonoBehaviour {

    private float _StageClear_Timer = 0.0f;
    private int _MinuteCount = 0;   // 分

    public GameObject Timer_Text;

    // タイマー初期化
	void Start () {
        _StageClear_Timer = 0.000f;
        _MinuteCount = 0;
    }
	
	// カウントアップ(少数第三位まで)してタイマー更新
	void Update () {

        // カウントがカンストしたらタイマー固定
        if(_MinuteCount == 9 && _StageClear_Timer >= 59.99f) {
            Timer_Text.GetComponent<Text>().text = "9:59:999";
            return;
        }

        // 操作可能時、カウントアップ
        if (Operation_Permission_Controll._isOperation_Permission) {
            _StageClear_Timer += Time.deltaTime;
        } else {
            return;
        }

        // 60秒ごとに1分上げる
        if (_StageClear_Timer >= 60.000f) {
            _MinuteCount++;
            _StageClear_Timer = 0.000f;
        }

        // 10秒以上と未満で表示方法を変更
        if (_StageClear_Timer >= 10.000f){
            Timer_Text.GetComponent<Text>().text = _MinuteCount + ":" + _StageClear_Timer.ToString("f3");
        } else {
            Timer_Text.GetComponent<Text>().text = _MinuteCount + ":0" + _StageClear_Timer.ToString("f3");
        }
    }
}

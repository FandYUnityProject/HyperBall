/* -クラスの説明-
 * =======================================================
 *  HyperBall_TouchCoin_Obj.cs
 *  作成日：2016/1/23
 *  作成者：Yamaguchi Yohei
 *
 * 【機能】
 *  ・コイン接触時に、コイン数をカウントアップする関数を呼び出す
 ========================================================== */

using UnityEngine;

public class HyperBall_TouchCoin_Obj : MonoBehaviour {

    void OnTriggerEnter(Collider coll) {
        // コイン接触時に、コイン数をカウントアップする関数を呼び出す
        if(coll.gameObject.tag == "Coin") {
            DebugInfo_Manager.DebugInfo_Update("コインを獲得しました。");
            Coin_Controll.GetCoinEvent();

            // コイン削除
            Destroy(coll.gameObject);
        }
    }
}

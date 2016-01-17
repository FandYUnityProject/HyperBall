/* -クラスの説明-
 * =======================================================
 *  HyperBall_TouchObj.cs
 *  作成日：2016/1/17
 *  作成者：Yamaguchi Yohei
 *
 * 【機能】
 *  ・プレイヤーのオブジェクト衝突イベント
 ========================================================== */

using UnityEngine;

public class HyperBall_TouchObj : MonoBehaviour {

	void OnTriggerEnter(Collider coll) {
        if(coll.gameObject.name == "Goal") {
            Debug.Log("Goal");
        }
    }
}

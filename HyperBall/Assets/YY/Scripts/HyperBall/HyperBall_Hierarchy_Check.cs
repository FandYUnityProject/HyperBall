/* -クラスの説明-
 * =======================================================
 *  HyperBall_Hierarchy_Check.cs
 *  作成日：2016/1/17
 *  作成者：Yamaguchi Yohei
 *
 * 【機能】
 *  ・HyperBall(プレイヤー)がStageの子オブジェクトか確認
 ========================================================== */
using UnityEngine;

public class HyperBall_Hierarchy_Check : MonoBehaviour {

    private GameObject HyperBall_Parent;

    void Start() {
        if(transform.root.gameObject.tag != "Stage") {
            Debug.LogError("HyperBall(プレイヤー)がStageの子オブジェクトに設定されていません。\nHyperBallをStage(Stageタグ)の子オブジェクトに設定してください。");
        }
    }
}

/* -クラスの説明-
 * =======================================================
 *  HyperBall_TouchGoal_Obj.cs
 *  作成日：2016/1/17
 *  作成者：Yamaguchi Yohei
 *
 * 【機能】
 *  ・プレイヤーのゴールオブジェクト衝突イベント
 ========================================================== */

using UnityEngine;

public class HyperBall_TouchGoal_Obj : MonoBehaviour {

    private GameObject MiniGame_Finish_Image;
    public string NextScene_Name;

    void Start() {
        // 初期化
        MiniGame_Finish_Image = GameObject.Find("MiniGame_Finish_Image");
        MiniGame_Finish_Image.transform.localScale = new Vector3(0, 0, 0);
    }

    void OnTriggerEnter(Collider coll) {
        // ゴールオブジェクト接触時に操作を非許可にし、FiniShの文字を表示 ⇒ 指定のシーンへ遷移
        if(coll.gameObject.name == "Goal") {
            DebugInfo_Manager.DebugInfo_Update("ゴールしました！");
            DebugInfo_Manager.DebugInfo_Update("操作を非許可にします。");
            Operation_Permission_Controll._isOperation_Permission = false;
            MiniGame_Finish_Image.transform.localScale = new Vector3(1, 1, 1);

            Invoke("NextScene", 1.0f);
        }
    }

    // 指定のシーンへ遷移
    void NextScene() {
        DebugInfo_Manager.DebugInfo_Update("シーン「" + NextScene_Name + "」へ遷移します。");
        SceneTransition_Controll.NextScene_Transition(NextScene_Name);
    }
}

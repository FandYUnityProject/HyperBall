/* -クラスの説明-
 * =====================================================
 *  StageNumber_Button.cs
 *  作成日：2016/1/30
 *  作成者：Yamaguchi Yohei
 *
 * 【概要】
 *  "StageNumber_Button"押下時に対象のゲームシーンへ移動
 ======================================================= */

using UnityEngine;

public class StageNumber_Button : MonoBehaviour {

    public void Click_StageNubmer_Button(){
        FreeModeScene_Controll.SceneTransition_SelectStage(gameObject.name);
    }
}

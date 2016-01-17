﻿/* -クラスの説明-
 * =======================================================
 *  GaneStart_Init.cs
 *  作成日：2016/1/16
 *  作成者：Yamaguchi Yohei
 *
 * 【概要】
 *  ゲーム開始時に初期化を行う。
 * 【機能】
 *  ・初プレイ時にゲームデータを初期化する
 ========================================================== */

using UnityEngine;

public class GameStart_Init : MonoBehaviour {

	void Awake () {
        // 初プレイ時の初期化処理
        if (PlayerPrefs.GetInt("isExistGameData") == 0){
            GameData_Init();
        }
    }

    // 初プレイ時の初期化処理
    void GameData_Init() {
        // 既プレイフラグを立て、セーブデータを初期化
        PlayerPrefs.SetInt("isExistGameData", 1);
        AllStage_Data_Init();
    }

    // セーブデータを初期化
    void AllStage_Data_Init() {
        for(int i=1; i<=30; i++) {
            // クリアフラグの初期化
            PlayerPrefs.SetInt("isClear_EasyStage_"   + i, 0);
            PlayerPrefs.SetInt("isClear_NormalStage_" + i, 0);
            PlayerPrefs.SetInt("isClear_HardStage_"   + i, 0);

            // クリアスコアの初期化
            PlayerPrefs.SetInt("Score_EasyStage_"   + i, 0);
            PlayerPrefs.SetInt("Score_NormalStage_" + i, 0);
            PlayerPrefs.SetInt("Score_HardStage_"   + i, 0);

            // クリアタイムの初期化
            PlayerPrefs.SetInt("Time_EasyStage_"   + i, 0);
            PlayerPrefs.SetInt("Time_NormalStage_" + i, 0);
            PlayerPrefs.SetInt("Time_HardStage_"   + i, 0);
        }
    }
}

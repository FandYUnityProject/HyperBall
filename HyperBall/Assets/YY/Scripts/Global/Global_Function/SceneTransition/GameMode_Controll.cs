/* -クラスの説明-
 * ============================================================
 *  GameMode_Controll.cs
 *  作成日：2016/1/30
 *  作成者：Yamaguchi Yohei
 *
 * 【概要】
 *  現在のゲームモードを管理（Challenge or Free)
 ============================================================== */

using UnityEngine;

public class GameMode_Controll : MonoBehaviour {

    public static string Now_GameMode = "";

    public static void GameMode_Name_Change(string GameMode_Name){
        Now_GameMode = GameMode_Name;
    }
}

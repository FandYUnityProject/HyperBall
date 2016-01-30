/* -クラスの説明-
 * =======================================================
 *  GameSelectScene_Controll.cs
 *  作成日：2016/1/30
 *  作成者：Yamaguchi Yohei
 *
 * 【概要】
 *  フリーモードシーンのUIコントロール
 ========================================================== */

using UnityEngine;
using System.Collections;

public class FreeModeScene_Controll : MonoBehaviour {

    // ＳＥ
    private GameObject SE_Source;
    public static AudioSource FreeMode_SeSource;

    // ＵＩ関連
    public static GameObject FreeModeTitle_Image;

    public static GameObject GameLevelSelectTitle_Image;
    public static GameObject FreeMode_Easy_Button;
    public static GameObject FreeMode_Normal_Button;
    public static GameObject FreeMode_Hard_Button;
    public static GameObject Return_GameSelectScene_Button;

    public static GameObject EasyStageNumber_Panel;
    public static GameObject NormalStageNumber_Panel;
    public static GameObject HardStageNumber_Panel;
    public static GameObject StageIntroduction_Panel;
    public static GameObject Return_GameLevelSelect_Button;

    void Start () {
        // SE取得
        SE_Source = GameObject.Find("SE_Source");
        FreeMode_SeSource = SE_Source.GetComponent<AudioSource>();

        // ゲームオブジェクト取得
        FreeModeTitle_Image           = GameObject.Find("FreeModeTitle_Image");
        GameLevelSelectTitle_Image    = GameObject.Find("GameLevelSelectTitle_Image");
        FreeMode_Easy_Button          = GameObject.Find("FreeMode_Easy_Button");
        FreeMode_Normal_Button        = GameObject.Find("FreeMode_Normal_Button");
        FreeMode_Hard_Button          = GameObject.Find("FreeMode_Hard_Button");
        Return_GameSelectScene_Button = GameObject.Find("Return_GameSelectScene_Button");
        EasyStageNumber_Panel         = GameObject.Find("EasyStageNumber_Panel");
        NormalStageNumber_Panel       = GameObject.Find("NormalStageNumber_Panel");
        HardStageNumber_Panel         = GameObject.Find("HardStageNumber_Panel");
        StageIntroduction_Panel       = GameObject.Find("StageIntroduction_Panel");
        Return_GameLevelSelect_Button = GameObject.Find("Return_GameLevelSelect_Button");

        // タイトルとゲームレベル選択関連以外を非活性
        FreeModeScene_All_HideImage();
        GameLevelSelectTitle_Image.SetActive(true);
        FreeMode_Easy_Button.SetActive(true);
        FreeMode_Normal_Button.SetActive(true);
        FreeMode_Hard_Button.SetActive(true);
        Return_GameSelectScene_Button.SetActive(true);
    }

    // 全てのボタンを非表示にする
    public static void FreeModeScene_All_HideImage() {
        GameLevelSelectTitle_Image.SetActive(false);
        FreeMode_Easy_Button.SetActive(false);
        FreeMode_Normal_Button.SetActive(false);
        FreeMode_Hard_Button.SetActive(false);
        Return_GameSelectScene_Button.SetActive(false);
        EasyStageNumber_Panel.SetActive(false);
        NormalStageNumber_Panel.SetActive(false);
        HardStageNumber_Panel.SetActive(false);
        StageIntroduction_Panel.SetActive(false);
        Return_GameLevelSelect_Button.SetActive(false);
    }

    // "FreeMode_Easy_Button"押下時にEasyStage一覧と成績欄を表示
    public static void FreeMode_Easy_Button_Event() {
        // 決定音に変更して音を鳴らす
        SE_Controll.SE_Change(0);
        FreeMode_SeSource.Play();

        FreeModeScene_All_HideImage();
        EasyStageNumber_Panel.SetActive(true);
        StageIntroduction_Panel.SetActive(true);
        Return_GameLevelSelect_Button.SetActive(true);
    }

    // "FreeMode_Normal_Button"押下時にEasyStage一覧と成績欄を表示
    public static void FreeMode_Normal_Button_Event() {
        // 決定音に変更して音を鳴らす
        SE_Controll.SE_Change(0);
        FreeMode_SeSource.Play();

        FreeModeScene_All_HideImage();
        NormalStageNumber_Panel.SetActive(true);
        StageIntroduction_Panel.SetActive(true);
        Return_GameLevelSelect_Button.SetActive(true);
    }

    // "FreeMode_Hard_Button"押下時にEasyStage一覧と成績欄を表示
    public static void FreeMode_Hard_Button_Event() {
        // 決定音に変更して音を鳴らす
        SE_Controll.SE_Change(0);
        FreeMode_SeSource.Play();

        FreeModeScene_All_HideImage();
        HardStageNumber_Panel.SetActive(true);
        StageIntroduction_Panel.SetActive(true);
        Return_GameLevelSelect_Button.SetActive(true);
    }

    // "Return_GameSelectScene_Button"押下時にメインメニューへ戻る
    public static void Return_GameSelectScene_Button_Event() {
        // キャンセル音に変更して音を鳴らす
        SE_Controll.SE_Change(1);
        FreeMode_SeSource.Play();

        SceneTransition_Controll.NextScene_Transition("GameSelect");
    }

    // "Return_GameLevelSelect_Button"押下時にゲームレベル選択画面を表示
    public static void Return_GameLevelSelect_Button_Event(){
        // キャンセル音に変更して音を鳴らす
        SE_Controll.SE_Change(1);
        FreeMode_SeSource.Play();

        FreeModeScene_All_HideImage();
        GameLevelSelectTitle_Image.SetActive(true);
        FreeMode_Easy_Button.SetActive(true);
        FreeMode_Normal_Button.SetActive(true);
        FreeMode_Hard_Button.SetActive(true);
        Return_GameSelectScene_Button.SetActive(true);
    }

    // 遊ぶステージを選択した時、対象のステージへ遷移
    public static void SceneTransition_SelectStage(string StageName){
        // 決定音に変更して音を鳴らす
        SE_Controll.SE_Change(2);
        FreeMode_SeSource.Play();

        SceneTransition_Controll.NextScene_Transition(StageName);
    }
}

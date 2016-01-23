/* -クラスの説明-
 * =======================================================
 *  Debug_DataManager.cs
 *  作成日：2016/1/16
 *  作成者：Yamaguchi Yohei
 *
 * 【概要】
 *  データ管理を行う
 ========================================================== */

using UnityEngine;

public class Debug_DataManager : MonoBehaviour
{
    public bool デバッグモード = false;
    public bool 全データを削除 = false;

    public int クリアステージ番号_Easy   = 0;
    public int クリアステージ番号_Normal = 0;
    public int クリアステージ番号_Hard   = 0;

    public int[] クリアスコア_Easy   = new int[30];
    public int[] クリアスコア_Normal = new int[30];
    public int[] クリアスコア_Hard   = new int[30];

    public int[] クリアタイム_Easy   = new int[30];
    public int[] クリアタイム_Normal = new int[30];
    public int[] クリアタイム_Hard   = new int[30];

    // 全データ削除フラグが立っていれば削除
    // それ以外は各ステージ毎にデータを設定
    void Awake()
    {
        if (!デバッグモード) {
            DebugInfo_Manager.DebugInfo_Update("デバッグモードではありません。");
            DebugInfo_Manager.DebugInfo_Update("デバッグモードを使用する際は、Debug_Scripts > Debug_DataManagerの'デバッグモード'をONにしてください。");
            return;
        } else {
            DebugInfo_Manager.DebugInfo_Update("デバッグモードを開始します。");
        }

        if (全データを削除) {
            DebugInfo_Manager.DebugInfo_Update("全データを削除します。");
            AllData_Delete();
        } else {
            Set_StageData_Easy();
            Set_StageData_Normal();
            Set_StageData_Hard();
        }
    }

    // 全データを削除
    void AllData_Delete() {

        // 既プレイフラグを下ろす
        PlayerPrefs.SetInt("isExistGameData", 1);

        // 音量の初期化
        PlayerPrefs.SetInt("Master_Volume", 80);
        PlayerPrefs.SetInt("BGM_Volume", 100);
        PlayerPrefs.SetInt("SE_Volume", 100);

        for (int i = 1; i <= 30; i++) {
            // クリアフラグの初期化
            PlayerPrefs.SetInt("isClear_EasyStage_" + i, 0);
            PlayerPrefs.SetInt("isClear_NormalStage_" + i, 0);
            PlayerPrefs.SetInt("isClear_HardStage_" + i, 0);

            // クリアスコアの初期化
            PlayerPrefs.SetInt("Score_EasyStage_" + i, 0);
            PlayerPrefs.SetInt("Score_NormalStage_" + i, 0);
            PlayerPrefs.SetInt("Score_HardStage_" + i, 0);

            // クリアタイムの初期化
            PlayerPrefs.SetInt("Time_EasyStage_" + i, 0);
            PlayerPrefs.SetInt("Time_NormalStage_" + i, 0);
            PlayerPrefs.SetInt("Time_HardStage_" + i, 0);
        }

        DebugInfo_Manager.DebugInfo_Update("全データを削除しました。");
    }

    // 指定したステージ番号までをクリアにし、クリアタイムとスコアを設定する（Easy）
    void Set_StageData_Easy() {
        if (クリアステージ番号_Easy == 0) {
            DebugInfo_Manager.DebugInfo_Update("クリアステージ番号_Easyの設定が'0'なため、Easyステージのデータは変更しません。");
            return;
        } else if (クリアステージ番号_Easy >= 30) {
            DebugInfo_Manager.DebugInfo_Update("クリアステージ番号_Easyの設定が'30'以上のため、全Easyステージのデータを変更します。");
            クリアステージ番号_Easy = 30;
        }

        DebugInfo_Manager.DebugInfo_Update("Easyステージ番号" + クリアステージ番号_Easy + "までのステージデータを変更します。");

        // 指定したステージ番号までをクリアにし、クリアタイムとスコアを設定
        for (int i=1; i<= クリアステージ番号_Easy; i++) {
            PlayerPrefs.SetInt("isClear_EasyStage_" + i, 1);
            Set_ClearScore_Easy(i);
            Set_ClearTime_Easy(i);
        }

        // それ以外は初期化
        for (int i= クリアステージ番号_Easy+1; i <= 30; i++)
        {
            PlayerPrefs.SetInt("isClear_EasyStage_" + i, 0);
            PlayerPrefs.SetInt("Score_EasyStage_"   + i, 0);
            PlayerPrefs.SetInt("Time_EasyStage_"    + i, 0);
        }
    }

    // 指定したステージ番号までをクリアにする（Normal）
    void Set_StageData_Normal()
    {
        if (クリアステージ番号_Normal == 0) {
            DebugInfo_Manager.DebugInfo_Update("クリアステージ番号_Normalの設定が'0'なため、Normalステージのデータは変更しません。");
            return;
        }
        else if (クリアステージ番号_Normal >= 30) {
            DebugInfo_Manager.DebugInfo_Update("クリアステージ番号_Normalの設定が'30'以上のため、全Normalステージのデータを変更します。");
            クリアステージ番号_Normal = 30;
        }

        DebugInfo_Manager.DebugInfo_Update("Normalステージ番号" + クリアステージ番号_Normal + "までのステージデータを変更します。");

        // 指定したステージ番号までをクリアにし、クリアタイムとスコアを設定
        for (int i = 1; i <= クリアステージ番号_Normal; i++)
        {
            PlayerPrefs.SetInt("isClear_NormalStage_" + i, 1);
            Set_ClearScore_Normal(i);
            Set_ClearTime_Normal(i);
        }

        // それ以外は初期化
        for (int i = クリアステージ番号_Normal + 1; i <= 30; i++)
        {
            PlayerPrefs.SetInt("isClear_NormalStage_" + i, 0);
            PlayerPrefs.SetInt("Score_NormalStage_" + i, 0);
            PlayerPrefs.SetInt("Time_NormalStage_" + i, 0);
        }
    }

    // 指定したステージ番号までをクリアにする（Hard）
    void Set_StageData_Hard()
    {
        if (クリアステージ番号_Hard == 0) {
            DebugInfo_Manager.DebugInfo_Update("クリアステージ番号_Hardの設定が'0'なため、Easyステージのデータは変更しません。");
            return;
        } else if (クリアステージ番号_Hard >= 30) {
            DebugInfo_Manager.DebugInfo_Update("クリアステージ番号_Hardの設定が'30'以上のため、全Easyステージのデータを変更します。");
            クリアステージ番号_Hard = 30;
        }

        DebugInfo_Manager.DebugInfo_Update("Hardステージ番号" + クリアステージ番号_Hard + "までのステージデータを変更します。");

        // 指定したステージ番号までをクリアにし、クリアタイムとスコアを設定
        for (int i = 1; i <= クリアステージ番号_Hard; i++)
        {
            PlayerPrefs.SetInt("isClear_HardStage_" + i, 1);
            Set_ClearScore_Hard(i);
            Set_ClearTime_Hard(i);
        }

        // それ以外は初期化
        for (int i = クリアステージ番号_Hard + 1; i <= 30; i++)
        {
            PlayerPrefs.SetInt("isClear_HardStage_" + i, 0);
            PlayerPrefs.SetInt("Score_HardStage_" + i, 0);
            PlayerPrefs.SetInt("Time_HardStage_" + i, 0);
        }
    }

    // 指定したステージ番号のクリアスコアを設定する（Easy）
    void Set_ClearScore_Easy(int StageNumber) {
        PlayerPrefs.SetInt("Score_EasyStage_" + StageNumber, クリアスコア_Easy[StageNumber-1]);
    }
    // 指定したステージ番号のクリアタイムを設定する（Easy）
    void Set_ClearTime_Easy(int StageNumber)
    {
        PlayerPrefs.SetInt("Time_EasyStage_" + StageNumber, クリアタイム_Easy[StageNumber - 1]);
    }

    // 指定したステージ番号のクリアスコアを設定する（Normal）
    void Set_ClearScore_Normal(int StageNumber)
    {
        PlayerPrefs.SetInt("Score_NormalStage_" + StageNumber, クリアスコア_Normal[StageNumber - 1]);
    }
    // 指定したステージ番号のクリアタイムを設定する（Normal）
    void Set_ClearTime_Normal(int StageNumber)
    {
        PlayerPrefs.SetInt("Time_NormalStage_" + StageNumber, クリアタイム_Normal[StageNumber - 1]);
    }

    // 指定したステージ番号のクリアスコアを設定する（Hard）
    void Set_ClearScore_Hard(int StageNumber)
    {
        PlayerPrefs.SetInt("Score_HardStage_" + StageNumber, クリアスコア_Hard[StageNumber - 1]);
    }
    // 指定したステージ番号のクリアタイムを設定する（Hard）
    void Set_ClearTime_Hard(int StageNumber)
    {
        PlayerPrefs.SetInt("Time_HardStage_" + StageNumber, クリアタイム_Hard[StageNumber - 1]);
    }
}

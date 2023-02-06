using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor;

public class DataManager : MonoBehaviour
{
    public TMP_Text tmpScore;
    public TMP_Text tmpBestScore;
    public TMP_Text tmpStage;
    public TMP_Text tmpBonusScore;

    public static int score;
    public static int bestScore;
    public static int stageCount;
    public static int bonusScore;

    public static bool CanJump = true;

    public GameObject gameOverTxtobj = default;
    public GameObject scoreObj = default;
    public GameObject bestScoreTxtobj = default;

    private const string SCENE_NAME = "SampleScene";
    private const string BEST_SCORE = "bestscore";
    private float _score = default;
    private bool isGameOver = false;
    private bool coroutineChk = false;

    void Start()
    {
        bonusScore = 5000;
    }

    void Update()
    {
        if (!coroutineChk)
        {
            coroutineChk = true;
            StartCoroutine("Bonus_minus");
            tmpScore.text = string.Format("1P - {0:D6}", score);
            tmpBestScore.text = string.Format("HI - {0:D6}", bestScore);
            tmpStage.text = string.Format("Stage - {0:D2}", stageCount);
            tmpBonusScore.text = string.Format("<color=#800020>BONUS</color> - {0:D4}", bonusScore);
            if (bonusScore > 0)
            {
                bonusScore -= 10;
            }
        }
       
    }

    public void EndGame()
    {
        isGameOver = true;
        gameOverTxtobj.SetActive(true);

        // BestTime Ű�� ����� ���������� �ְ� ��� ��������
        float bestscore = PlayerPrefs.GetFloat(BEST_SCORE);

        // ���������� �ְ� ��Ϻ��� ���� ���� �ð��� �� �� ���
        if (bestscore < _score)
        {
            //�÷��̾� �����ս��� ����Ʈ Ÿ���� �����ؼ� �����Ѵ�.
            bestscore = score;
            PlayerPrefs.SetFloat(BEST_SCORE, bestscore);
        }       // if: ���� surviveTime�� bestTime ���� ū ��� 
        //�ְ� ����� �ؽ�Ʈ�� ������.
        Util.SetTmpText(bestScoreTxtobj,
            $"Best Score : {Mathf.FloorToInt(bestscore)}");
    }       //EndGame()


    IEnumerator Bonus_minus()
    {
        yield return new WaitForSeconds(0.3f);
        coroutineChk = false;

    }
}

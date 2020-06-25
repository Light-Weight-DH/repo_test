using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScene_Stage2 : MonoBehaviour
{
    public void ChangeScene()
    {
        SceneManager.LoadScene("Stage2");//새로운 레벨을 로드
        print("여기 들어오는겨?");
        Debug.Log("들어옴");
    }
}

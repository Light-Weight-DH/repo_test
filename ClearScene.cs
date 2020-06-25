using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClearScene : MonoBehaviour
{
    public void ChangeScene()
    {
        SceneManager.LoadScene("Stage1");//새로운 레벨을 로드
        print("여기 들어오는겨?");
        Debug.Log("들어옴");
    }
    // Start is called before the first frame update
}

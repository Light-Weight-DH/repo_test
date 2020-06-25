using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScene : MonoBehaviour
{

    public void ChangeScene()
    {
        SceneManager.LoadScene("Dutorial");//새로운 레벨을 로드
    }
    // Start is called before the first frame update

}

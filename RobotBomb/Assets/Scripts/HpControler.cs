using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HpControler : MonoBehaviour
{
    GameObject hp;

    // Start is called before the first frame update
    void Start()
    {
        hp = GameObject.Find("Hp"); //object 이름으로 해당 object 찾기 가능
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HpControl() //BombControler에서 호출
    {
        hp.GetComponent<Image>().fillAmount -= 0.1f; //10%씩 깎이게끔 (10번 맞으면 끝)

        if (hp.GetComponent<Image>().fillAmount <= 0)
        {
            SceneManager.LoadScene("GameOverScene");
        }
    }
}

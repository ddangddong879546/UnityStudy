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
        hp = GameObject.Find("Hp"); //object �̸����� �ش� object ã�� ����
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HpControl() //BombControler���� ȣ��
    {
        hp.GetComponent<Image>().fillAmount -= 0.1f; //10%�� ���̰Բ� (10�� ������ ��)

        if (hp.GetComponent<Image>().fillAmount <= 0)
        {
            SceneManager.LoadScene("GameOverScene");
        }
    }
}

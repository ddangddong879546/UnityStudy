using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletGenerator : MonoBehaviour
{
    // ������ : ��Ȱ���ϱ� ���� ������Ʈ
    public GameObject bulletPrefab;

    private float time = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if (time > 0.5)
        {
            // �������� �̿��ؼ� ������Ʈ ����
            GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);

            // BulletController���� �Ѿ� �߻� �Լ� ����
            bullet.GetComponent<BulletControler>().ShootForEnemy();

            time = 0f;

        }
    }
}

using System.Collections.Generic;
using UnityEngine;


public class practice03 : MonoBehaviour
{
    [System.Serializable]
    public class money
    {
        public string name;
        public int rarity;
    }

    public List<money> moneyPool = new List<money>();

    void Start()
    {
        moneyPool.Add(new money { name = "$10�� �Ҿ���", rarity = 90 });
        moneyPool.Add(new money { name = "$50�� �����", rarity = 9 });
        moneyPool.Add(new money { name = "$1000�� �����", rarity = 1 });

        GachaOne();
        GachaTen();
    }

    money Gachamoney()
    {
        int rand = Random.Range(1, 101); // 1~100
        int cumulative = 0;

        foreach (money money in moneyPool)
        {
            cumulative += money.rarity;
            if (rand <= cumulative)
                return money;
        }

        return moneyPool[moneyPool.Count - 1];
    }

    public void GachaOne()
    {
        money result = Gachamoney();
        Debug.Log("��í! : " + result.name);
    }

    // 10ȸ �̱�
    public void GachaTen()
    {
        Debug.Log("��í��í!!");
        for (int i = 0; i < 10; i++)
        {
            money result = Gachamoney();
            Debug.Log((i + 1) + "��°: " + result.name);
        }
        Debug.Log("��í ����!!");
    }
}

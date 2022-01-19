using UnityEngine;

public class Pocket : MonoBehaviour
{
    [SerializeField] int money;

    public int Money => money;

    public void AddMoney(int count)
    {
        money += count;
    }

    public int GetMoney(int count)
    {
        if (money - count > 0)
        {
            money -= count;
            return count;
        }
                
        var remains = money;
        money = 0;
        return remains;
    }

    //TODO: Separate work with UI
    void Update()
    {
        PlayerUI.Instance.SetMoney(money);
    }
}

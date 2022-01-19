using TMPro;
using UnityEngine;

public class PlayerUI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI money;

    //TODO: Delete Singleton
    public static PlayerUI Instance;

    void Awake() => Instance = this;

    public void SetMoney(int count)
    {
        money.text = "Money: " + count;
    }
}

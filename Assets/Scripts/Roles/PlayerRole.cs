using UnityEngine;

public class PlayerRole : MonoBehaviour
{
    [SerializeField] Role role;

    public void Init(Role role)
    {
        this.role = role;
        gameObject.name = role.GetName();
    }
}

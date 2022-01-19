using UnityEngine;

public abstract class PlayerRole : MonoBehaviour
{
    [SerializeField] Role role;

    public virtual void Init(Role role)
    {
        this.role = role;
        gameObject.name = role.GetName();
    }
}

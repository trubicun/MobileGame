using UnityEngine;

public class PlayerRoleFactory: MonoBehaviour
{
    [SerializeField] PlayerRole playerRole;

    public PlayerRole CreateRole(RoleType roleType, Transform parent)
    {
        
        var role = Instantiate(playerRole, parent);

        //TODO: Use something else inns
        switch (roleType)
        {
            case RoleType.Electronics:
            {
                role.Init(new RoleElectronics());
                role.gameObject.AddComponent<BuildingSelector>();
                break;
            }
            default:
            {
                //role.gameObject.name = roleType.GetName();
                break;
            }
        }
        
        return role;
    }
}

public enum RoleType
{
    Electronics
}

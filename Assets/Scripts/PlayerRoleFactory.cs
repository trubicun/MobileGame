using UnityEngine;

public class PlayerRoleFactory: MonoBehaviour
{
    [SerializeField] PlayerRoleElectronics roleElectronics;
    [SerializeField] PlayerRoleUnknown roleUnknown;

    public PlayerRole CreateRole(RoleType roleType, Transform parent)
    {
        //TODO: Use something else instead of switch
        switch (roleType)
        {
            case RoleType.Electronics:
            {
                var role = Instantiate(roleElectronics, parent);
                role.Init(new RoleElectronics());
                
                return role;
            }
            default:
            {
                var role = Instantiate(roleUnknown, parent);
                role.Init(new RoleUnknown());
                
                return role;
            }
        }
    }
}

public enum RoleType
{
    Electronics
}

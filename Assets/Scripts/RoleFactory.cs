public class RoleFactory
{
    public static Role CreateRole(RoleType role)
    {
        switch (role)
        {
            case RoleType.Electronics:
                return new RoleElectronics();
            default:
                return new RoleUnknown();
        }
    }
}

public enum RoleType
{
    Electronics
}

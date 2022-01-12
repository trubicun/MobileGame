using UnityEngine;

public class Player : MonoBehaviour
{
    Role playerRole;
    
    //TODO: take out to factory
    public void SetRole<T>(T role) where T: Role
    {
        Debug.Log("ROLE: " + role);
        playerRole = gameObject.AddComponent<T>();
    }
}

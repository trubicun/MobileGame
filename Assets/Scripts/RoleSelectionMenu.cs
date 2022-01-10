using UnityEngine;

public class RoleSelectionMenu : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Awake");
        transform.GetChild(0).gameObject.SetActive(true);
    }

    public void SelectElectronics()
    {
        var role = new RoleElectronics();
        Debug.Log("Role Selected: " + role.GetName());
        
        Quit();
    }

    void Quit()
    {
        transform.GetChild(0).gameObject.SetActive(false);
    }
}

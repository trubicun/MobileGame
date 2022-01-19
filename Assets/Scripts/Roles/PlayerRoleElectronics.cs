using System;
using UnityEngine;

public class PlayerRoleElectronics : PlayerRole
{
    [SerializeField] Pocket pocket;
    [SerializeField] BuildingSelector selector;

    public override void Init(Role role)
    {
        base.Init(role);
    }

    void Update()
    {
        if (pocket.Money < 1000) return;
        if (!Input.GetMouseButton(0)) return;
        var building = selector.TryToSelect();
        if (building)
        {
            if (!building.GetComponent<Collector>())
            {
                pocket.GetMoney(1000);
                building.gameObject.AddComponent<Collector>().Init(pocket);
            }
        }
    }
}

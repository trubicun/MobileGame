using System;
using UnityEngine;

public class BuildingSelector : MonoBehaviour, IRoleComponent
{
    Transform lastHittedTransform;
    Vector3 lastHittedScale;

    void Init()
    {
        
    }
    
    //TODO: Split to RaycasterComponent
    RaycastHit Raycast()
    {
        RaycastHit hitInfo;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        Physics.Raycast(ray, out hitInfo);
        return hitInfo;
    }

    //TODO: Maybe Split to SelectorComponent
    Transform Select(RaycastHit hit)
    {
        if (hit.transform)
        {
            if (lastHittedTransform == hit.transform) return null;

            if (lastHittedTransform) lastHittedTransform.localScale = lastHittedScale;
            
            lastHittedTransform = hit.transform;
            lastHittedScale = lastHittedTransform.localScale;

            return hit.transform;
        }

        return null;
    }
    
    void Update()
    {
        var hit = Raycast();
        var selected = Select(hit);
        if (selected)
        {
            var building = selected.GetComponent<Building>();
            if (building && building.Type == Building.BuildingType.Commercial)
            {
                building.transform.localScale = building.transform.lossyScale * 1.3f;
                //Building (Selectable Object) Selected!
            }
        }
    }
}
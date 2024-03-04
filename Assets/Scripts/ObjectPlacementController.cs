using UnityEngine;

public class ObjectPlacementController : MonoBehaviour
{
    public GameObject objectToSpawn;
    private bool objectSpawned = false;

    void Update()
    {
        if (!objectSpawned && Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            SpawnObject();
        }
    }

    void SpawnObject()
    {
        
        Ray ray = Camera.main.ScreenPointToRay(Input.touches[0].position);
        if (Physics.Raycast(ray, out RaycastHit hit))
        {
            Instantiate(objectToSpawn, hit.point, Quaternion.identity);
            objectSpawned = true; 
        }
    }
}

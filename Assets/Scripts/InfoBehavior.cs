using UnityEngine;
public class InfoBehavior : MonoBehaviour {
    const float SPEED = 6f;
    [SerializeField]
    Transform InfoParent;
    Vector3 desiredScale = Vector3.zero;
    void Update() 
    {
        InfoParent.localScale = Vector3.Lerp(InfoParent.localScale, desiredScale, Time.deltaTime * SPEED);
    }
    public void Openlnfo() 
    {
        desiredScale = Vector3.one;
    }
    public void Closelnfo()
    {
        desiredScale = Vector3.zero;
    }
}
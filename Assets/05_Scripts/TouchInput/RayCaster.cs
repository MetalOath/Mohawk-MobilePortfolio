using UnityEngine;
public class Raycaster : MonoBehaviour
{
    public Camera mainCamera;
    // Start is called before the first frame update
    void Start()
    {
        if (!mainCamera)
        {
            mainCamera = Camera.main;
        }
    }
    // Update is called once per frame
    public void DrawRay(Vector3 position)
    {
        Ray ray = mainCamera.ScreenPointToRay(position);
        Debug.DrawRay(ray.origin, ray.direction);
    }
    public void Raycast(Vector3 position)
    {
        Ray ray = mainCamera.ScreenPointToRay(position);
    }
}
using UnityEngine;

public class HeadRotation : MonoBehaviour
{
    public Camera customCamera;
    public Transform pivotPoint;

    void Start()
    {
        if (customCamera == null)
        {
            customCamera = Camera.main;
        }
    }

    void Update()
    {
        RotateArm();
    }

    void RotateArm()
    {
        if (pivotPoint == null)
        {
            pivotPoint = transform;
        }

        Vector3 mousePosition = customCamera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, -customCamera.transform.position.z));
        Vector3 direction = (new Vector3(mousePosition.x, mousePosition.y, pivotPoint.position.z) - pivotPoint.position).normalized;

        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = rotation;
    }
}
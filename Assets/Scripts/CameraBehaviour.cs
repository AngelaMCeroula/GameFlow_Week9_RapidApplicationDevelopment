using UnityEngine;

public class CameraBehaviour : MonoBehaviour
{
    public GameObject targetObject;
    public float xOffSet, yOffSet, zOffSet;

    private void Update()
    {
        transform.position = targetObject.transform.position + new Vector3(xOffSet, yOffSet, zOffSet);
        transform.LookAt(targetObject.transform.position);
    }
}

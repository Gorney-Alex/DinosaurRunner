using UnityEngine;

public class ObjectMovementer : MonoBehaviour
{
    private void Update()
    {
        MoveAllObjects();
    }

    private void MoveAllObjects()
    {
        foreach (var obj in ObjectDataBase.Objects)
        {
            Debug.Log("I movement");
            if (obj.activeSelf)
            {
                obj.transform.Translate(Vector3.forward * 20 * Time.deltaTime, Space.World);
            }
        }
    }
}

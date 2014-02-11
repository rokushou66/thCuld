using UnityEngine;
using System.Collections;

namespace Extensions
{
    public static class Extensions
    {
        public static T GetSafeComponent<T>(this GameObject obj) where T : MonoBehaviour
        {
            T component = obj.GetComponent<T>();

            if (component == null)
            {
                Debug.LogError("Expected to find component of type "
                   + typeof(T) + " but found none", obj);
            }

            return component;
        }

        public static void SetX(this Transform transform, float x)
        {
            Vector3 newPosition =
               new Vector3(x, transform.position.y, transform.position.z);

            transform.position = newPosition;
        }
    }
}

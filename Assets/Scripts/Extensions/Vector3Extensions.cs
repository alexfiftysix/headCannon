using UnityEngine;

namespace Extensions
{
    public static class Vector3Extensions {
        public static Vector3 Clamp(this Vector3 vector3, float clamp)
        {
            return new Vector3(
                vector3.x < -clamp ? -clamp : vector3.x > clamp ? clamp : vector3.x,
                vector3.y < -clamp ? -clamp : vector3.y > clamp ? clamp : vector3.y,
                vector3.z < -clamp ? -clamp : vector3.z > clamp ? clamp : vector3.z
            );
        }

        public static Vector3 CreateRandom(float range, float y)
        {
            return new Vector3(Random.Range(-range, range), y, Random.Range(-range, range));
        }

        public static Vector3 AtY(this Vector3 vector3, float y)
        {
            return new Vector3(vector3.x, y, vector3.z);
        }
    }
}
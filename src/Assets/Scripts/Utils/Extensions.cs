﻿using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Utils
{
    public static class Extensions
    {
        public static float MoveTowards(this float current, float target, float moveTowards)
        {
            if (Math.Abs(current - target) < moveTowards)
            {
                return target;
            }

            if (current > target )
            {
                return current - moveTowards;
            }
            else
            {
                return current + moveTowards;
            }
        }

        public static T Random<T>(this List<T> list)
        {
            var index = UnityEngine.Random.Range(0, list.Count);
            return list[index];
        }

        public static Vector3 PositiveY(this Vector3 vector)
        {
            return new Vector3(vector.x, Math.Abs(vector.y), vector.z);
        }
    }
}

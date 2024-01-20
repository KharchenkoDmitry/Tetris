using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolManager<T> where T : MonoBehaviour
{
    [SerializeField] private T prefab { get; }
    
}

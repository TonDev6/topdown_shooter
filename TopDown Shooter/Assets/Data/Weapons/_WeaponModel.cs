using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "_WeaponModel", menuName = "TopDown Shooter/Weapon Base", order = 0)]

public class _WeaponModel : ScriptableObject {
    
    public GameObject bulletPrefab;

    public new string name;

    public int currentAmmo, maxAmmo;
    
    public int bulletDamage = 1;
    public float bulletSpeed = 20f;
    public float fireRate = 1.5f;

    public Sprite sprite;


}
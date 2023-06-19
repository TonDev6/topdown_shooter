using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _WpnSelectSys : MonoBehaviour
{
    public GameObject[] prefabArray;

    public int weaponIndex;

    public GameObject selectedWeapon;

    private void Awake() {
        weaponIndex = 0;
        selectedWeapon = prefabArray[0];
    }

    private void Update() {
        if (weaponIndex == 0) {
            selectedWeapon = prefabArray[0];
        } else if (weaponIndex == 1) {
            selectedWeapon = prefabArray[1];
        } else if (weaponIndex == 2) {
            selectedWeapon = prefabArray[2];
        }
    }
}

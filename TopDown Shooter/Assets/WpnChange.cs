using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WpnChange : MonoBehaviour
{
    public _PlayControl player;

    public _WpnSelectSys thisWeapon;

    public int thisWeaponIndex;

    public int wpnIndex;


    private void Start() {

        thisWeapon = player.weapon.GetComponent<_WpnSelectSys>();
        thisWeaponIndex = thisWeapon.weaponIndex;
    }
    

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.CompareTag("Player")) {
            thisWeapon.weaponIndex = wpnIndex;
        }
    }
}

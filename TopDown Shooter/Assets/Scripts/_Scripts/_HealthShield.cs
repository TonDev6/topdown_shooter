using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class _HealthShield : MonoBehaviour
{
    public Image[] healthPoints;
    public Image[] shieldPoints;

    public _HS_System hsCount;
    


    private void Awake() {
        hsCount = GetComponent<_HS_System>();
    }

    private void Update() {
        HealthBarFiller();
        ShieldBarFiller();
    }

    void HealthBarFiller() {
        for (int i = 0; i < healthPoints.Length; i++) {
            healthPoints[i].enabled = !DisplayHealthPoints(hsCount.health, i);
        }
    }

    void ShieldBarFiller() {
        for (int i = 0; i < shieldPoints.Length; i++) {
            shieldPoints[i].enabled = !DisplayShieldPoints(hsCount.shield, i);
        }
    }

    bool DisplayHealthPoints(float _health, int pointNumber) {
        return(pointNumber >= _health);
    }

    bool DisplayShieldPoints(float _shield, int pointNumber) {
        return(pointNumber >= _shield);
    }
}

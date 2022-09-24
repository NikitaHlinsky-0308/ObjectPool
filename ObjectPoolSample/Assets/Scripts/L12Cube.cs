using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 
    L12Cube : MonoBehaviour
{
    [SerializeField] private float lifeTime = 2f;

    private void OnEnable()
    {
        this.StartCoroutine("LifeRoutine");
    }

    private void OnDisable()
    {
        this.StopCoroutine("LifeRoutine");
    }

    private IEnumerator LifeRoutine()
    {
        yield return new WaitForSeconds(lifeTime);

        this.Diactivate();
    }

    private void Diactivate()
    {
        this.gameObject.SetActive(false);
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateTerrain : MonoBehaviour
{

    [SerializeField] GameObject cubePrefab;
    [SerializeField] int terrainSize;
    [SerializeField] float terrainHeight;   //-1.49f

    // Start is called before the first frame update
    void Start()
    {
        //CriandoPiso();
		CriandoAlturaPiso();
    }

    private void CriandoAlturaPiso()
    {
		int count = 0;
		for (int coluna = 1; coluna <= terrainSize; coluna++)
		{
			for (int linha = 1; linha <= terrainSize; linha++)
			{
				int randomHeight = Random.Range(1, 5);
				for (int height = 1; height <= randomHeight; height++)
				{
					Instantiate(cubePrefab,	
						new Vector3(coluna, height, linha),
						Quaternion.identity);
					count++;
				}
			}
		}
		Debug.Log($"total de prefab: {count}");
	}

    private void CriandoPiso()
    {
		for (int coluna = 1; coluna <= terrainSize; coluna++)
		{
			for (int linha = 1; linha <= terrainSize; linha++)
			{
				Instantiate(cubePrefab,
					new Vector3(coluna, terrainHeight, linha),
					Quaternion.identity);

				/* Quaternion.identity : não vai rotacionar.
                 */
			}
		}
	}


    /* Criar um GameObject empty (GOE).
     * Vincular esse script no GOE.
     * No atributo desse script, vincular um prefab.
     */
    
}

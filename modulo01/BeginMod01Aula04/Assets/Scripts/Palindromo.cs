using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Palindromo : MonoBehaviour
{

    [SerializeField] private string ehPalindromo;


    // Start is called before the first frame update
    void Start()
    {
        bool check = IsPalindromo(ehPalindromo);
        if (check)
        {
            Debug.Log($"É palindromo: {ehPalindromo}");
        } 
        else
        {
			Debug.Log($"Não é palindromo: {ehPalindromo}");
		}
    }

    private bool IsPalindromo(string str)
    {
        int countIguais = 0;
        for(int i = 0, j = str.Length - 1; i < str.Length / 2; i++, j--)
        {
            if (str[i] == str[j])
            {
                countIguais++;
            }
        }

        return countIguais == str.Length / 2;
    }
}
